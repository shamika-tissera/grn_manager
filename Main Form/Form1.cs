using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GRN_Manager.Report;

namespace GRN_Manager
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_filter = new DataTable();
        int rowIndex;
        
        string connString = Config.getConnectionString();
        public Form1()
        {
            InitializeComponent();
            // Disable the buttons initially
            deleteItemBtn.Enabled = false;
            updateItemBtn.Enabled = false;

            // Set the max date to today's date
            filterDatePicker.MaxDate = DateTime.Now;

            grnDate.MaxDate = DateTime.Now;
        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = itemListDataTbl.Rows[rowIndex];
            itemNameTxt.Text = row.Cells[0].Value.ToString();
            itemQuantityTxt.Text = row.Cells[1].Value.ToString();
            itemDescriptionTxt.Text = row.Cells[2].Value.ToString();

            // Enable the buttons when a row is selected
            deleteItemBtn.Enabled = true;
            updateItemBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var supplier = supplierCmb.Text;
            var grnNumber = grnNumberTxt.Text;
            var Date = grnDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(supplier) || string.IsNullOrEmpty(grnNumber))
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            // check if the GRN number already exists

            // store items in a list
            List<GrnItem> items = new List<GrnItem>();
            foreach (DataRow row in dt.Rows)
            {
                GrnItem item = new GrnItem();
                item.ItemName = row["Item Name"].ToString();
                item.ItemCode = row["Item Quantity"].ToString();
                item.ItemDescription = row["Item Description"].ToString();
                items.Add(item);
            }

            // create a new GRN object
            Grn grn = new Grn();
            grn.number = grnNumber;
            grn.date = Date;
            grn.supplier = supplier;
            grn.items = items;

            // get the supplier id from the database
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id FROM supplier WHERE name = '" + supplier + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            var supplierId = reader["id"].ToString();
            reader.Close();

            // check if the GRN number already exists
            cmd = new SqlCommand("SELECT * FROM grn_details WHERE grn_number = '" + grnNumber + "'", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("GRN number already exists!");
                return;
            }
            // check if no items were added
            if (grn.items.Count == 0)
            {
                MessageBox.Show("You haven't added any items. Please add at least one.");
                return;
            }

            reader.Close();
            // insert into grn table
            cmd = new SqlCommand("INSERT INTO grn_details (grn_number, date, supplier_id) VALUES ('" + grn.number + "', '" + grn.date + "', " + supplierId + ")", conn);
            cmd.ExecuteNonQuery();

            

            foreach (GrnItem item in grn.items)
            {
                var item_uuid = Guid.NewGuid().ToString();
                cmd = new SqlCommand("INSERT INTO item (id, name, quantity, description) VALUES ('" + item_uuid + "', '" + item.ItemName + "', " + item.ItemCode + ", '" + item.ItemDescription + "')", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Insert INTO grn_details_item (grn_number, item_id) VALUES ('" + grn.number + "', '" + item_uuid + "')", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            MessageBox.Show("GRN added successfully");

            // clear the form
            grnNumberTxt.Text = String.Empty;
            supplierCmb.Text = String.Empty;
            dt.Clear();

            // refresh the filter table
            dt_filter.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM grn_details", conn);
            reader = cmd.ExecuteReader();
            List<string[]> grnDetails = new List<string[]>();
            while (reader.Read())
            {
                var supplier_id = reader["supplier_id"].ToString();
                var grn_number = reader["grn_number"].ToString();
                var date = reader["date"].ToString();

                grnDetails.Add(new string[] { supplier_id, grn_number, date });
            }
            reader.Close();

            foreach (var detail in grnDetails)
            {
                cmd = new SqlCommand("SELECT name FROM supplier WHERE id = " + detail[0], conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                var supplier_name = reader2["name"].ToString();
                reader2.Close();

                dt_filter.Rows.Add(detail[1], detail[2], supplier_name);
            }

            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Item Name", Type.GetType("System.String"));
            dt.Columns.Add("Item Quantity", Type.GetType("System.String"));
            dt.Columns.Add("Item Description", Type.GetType("System.String"));

            itemListDataTbl.DataSource = dt;

            dt_filter.Columns.Add("GRN Number", Type.GetType("System.String"));
            dt_filter.Columns.Add("Date", typeof(DateTime));
            dt_filter.Columns.Add("Supplier", Type.GetType("System.String"));

            filterTbl.DataSource = dt_filter;


            // load suppliers from database
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("Error: Couldn't connect to the database. Please ensure that you have changed the connection string to suit your environment. You may consult the user manual for more info.");
                Console.WriteLine(ex.Message);
                Application.Exit();
                return;
            }
                
            SqlCommand cmd = new SqlCommand("SELECT * FROM supplier", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                supplierCmb.Items.Add(reader["name"].ToString());
                filterSupplierCmb.Items.Add(reader["name"].ToString());
            }
            reader.Close();

            // load grn details from database. Also, get the supplier name for the supplier id
            cmd = new SqlCommand("SELECT * FROM grn_details", conn);
            reader = cmd.ExecuteReader();
            List<string[]> grnDetails = new List<string[]>();
            while (reader.Read())
            {
                var supplier_id = reader["supplier_id"].ToString();
                var grn_number = reader["grn_number"].ToString();
                var date = reader["date"].ToString();

                grnDetails.Add(new string[] { supplier_id, grn_number, date });
            }
            reader.Close();

            foreach (var detail in grnDetails)
            {
                cmd = new SqlCommand("SELECT name FROM supplier WHERE id = " + detail[0], conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                var supplier_name = reader2["name"].ToString();
                reader2.Close();

                dt_filter.Rows.Add(detail[1], detail[2], supplier_name);
            }

            conn.Close();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            // check if the item name or quantity is empty
            if (string.IsNullOrEmpty(itemNameTxt.Text) || string.IsNullOrEmpty(itemQuantityTxt.Text))
            {
                MessageBox.Show("Please fill in the item name and quantity");
                return;
            }

            dt.Rows.Add(itemNameTxt.Text, itemQuantityTxt.Text, itemDescriptionTxt.Text);
            itemNameTxt.Text = String.Empty;
            itemQuantityTxt.Text = String.Empty;
            itemDescriptionTxt.Text = String.Empty;
        }

        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            //check if the item name or quantity is empty
            if (string.IsNullOrEmpty(itemNameTxt.Text) || string.IsNullOrEmpty(itemQuantityTxt.Text))
            {
                MessageBox.Show("Please fill in the item name and quantity");
                return;
            }

            DataGridViewRow newDataRow = itemListDataTbl.Rows[rowIndex];
            newDataRow.Cells[0].Value = itemNameTxt.Text;
            newDataRow.Cells[1].Value = itemQuantityTxt.Text;
            newDataRow.Cells[2].Value = itemDescriptionTxt.Text;

            itemNameTxt.Text = String.Empty;
            itemQuantityTxt.Text = String.Empty;
            itemDescriptionTxt.Text = String.Empty;
                    
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            itemListDataTbl.Rows.RemoveAt(rowIndex);

            itemNameTxt.Text = String.Empty;
            itemQuantityTxt.Text = String.Empty;
            itemDescriptionTxt.Text = String.Empty;

            // Disable the buttons after deleting a row
            deleteItemBtn.Enabled = false;
            updateItemBtn.Enabled = false;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string date = filterDatePicker.Value.ToString("yyyy-MM-dd");
            string supplier = filterSupplierCmb.Text;
            string grnNumber = filterGrnNumTxt.Text;

            // Clear the existing rows in the data table
            dt_filter.Rows.Clear();

            // Open the connection
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            // Start building the SQL query
            StringBuilder sql = new StringBuilder("SELECT grn_details.grn_number, grn_details.date, supplier.name FROM grn_details INNER JOIN supplier ON grn_details.supplier_id = supplier.id WHERE 1=1");

            // Add conditions to the SQL query if they are not empty
            if (!string.IsNullOrEmpty(date))
            {
                sql.Append(" AND grn_details.date = '" + date + "'");
            }
            if (!string.IsNullOrEmpty(supplier))
            {
                sql.Append(" AND supplier.name = '" + supplier + "'");
            }
            if (!string.IsNullOrEmpty(grnNumber))
            {
                sql.Append(" AND grn_details.grn_number = '" + grnNumber + "'");
            }

            // Get the GRN details from the database
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Read the GRN details from the reader
            while (reader.Read())
            {
                var grn_number = reader["grn_number"].ToString();
                var grn_date = ((DateTime)reader["date"]).ToString("yyyy-MM-dd");
                var supplier_name = reader["name"].ToString();

                // Add the GRN number, date, and supplier name to the data table
                dt_filter.Rows.Add(grn_number, grn_date, supplier_name);
            }

            // Close the reader and the connection
            reader.Close();
            conn.Close();

        }

        private void filterClearBtn_Click(object sender, EventArgs e)
        {
            // clear the filter form
            //filterDatePicker.Value = DateTime.Now;
            filterSupplierCmb.SelectedIndex = -1;
            filterGrnNumTxt.Text = String.Empty;

            // clear the filter table
            dt_filter.Rows.Clear();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM grn_details", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string[]> grnDetails = new List<string[]>();
            while (reader.Read())
            {
                var supplier_id = reader["supplier_id"].ToString();
                var grn_number = reader["grn_number"].ToString();
                var date = reader["date"].ToString();

                grnDetails.Add(new string[] { supplier_id, grn_number, date });
            }
            reader.Close();

            foreach (var detail in grnDetails)
            {
                cmd = new SqlCommand("SELECT name FROM supplier WHERE id = " + detail[0], conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                var supplier_name = reader2["name"].ToString();
                reader2.Close();

                dt_filter.Rows.Add(detail[1], detail[2], supplier_name);
            }

            conn.Close();

        }

        private void filterTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0)
            {
                return;
            }

            //create a window to display the GRN details
            GrnDetails grnDetails = new GrnDetails();
            
            // get items from the database based on the grn number
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT item.name, item.quantity, item.description FROM grn_details_item INNER JOIN item ON grn_details_item.item_id = item.id WHERE grn_details_item.grn_number = '" + dt_filter.Rows[index]["GRN Number"].ToString() + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string[]> items = new List<string[]>();
            while (reader.Read())
            {
                items.Add(new string[] { reader["name"].ToString(), reader["quantity"].ToString(), reader["description"].ToString() });
            }
            reader.Close();

            // create a new GRN object
            Grn grn = new Grn();
            grn.number = dt_filter.Rows[index]["GRN Number"].ToString();
            grn.date = dt_filter.Rows[index]["Date"].ToString();
            grn.supplier = dt_filter.Rows[index]["Supplier"].ToString();
            grn.items = new List<GrnItem>();

            // add items to the GRN object
            foreach (var item in items)
            {
                GrnItem grnItem = new GrnItem();
                grnItem.ItemName = item[0];
                grnItem.ItemCode = item[1];
                grnItem.ItemDescription = item[2];
                grn.items.Add(grnItem);
            }

            // set the details in the window
            grnDetails.setDetails(grn);

            // show the window
            grnDetails.Show();
        }

        private void genReportBtn_Click(object sender, EventArgs e)
        {
            ReportViewer report = new ReportViewer();
            report.Show();

            string connString = Config.getConnectionString();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "Select grn_number, SupplierName, ItemName, quantity, description, date from View_1";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ds.Tables.Add("View_1");

            adapter.Fill(ds);

            // Check if the dataset has any tables and rows
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                GRNReport crystalReport = new GRNReport();
                crystalReport.SetDataSource(ds);
                report.setReport(crystalReport);
            }
            else
            {
                Console.WriteLine("No data returned from the query.");
            }
        }

        private void itemQuantityTxt__KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ensure that only numbers are entered in the quantity field

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
