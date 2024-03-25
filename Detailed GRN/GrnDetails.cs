using GRN_Manager.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRN_Manager
{
    public partial class GrnDetails : Form
    {
        Grn grn;
        int index = -1;
        public GrnDetails()
        {
            InitializeComponent();
        }

        public void setDetails(Grn grn)
        {
            // add columns to the itemListDataTbl
            itemListDataTbl.Columns.Add("Item Name", "Item Name");
            itemListDataTbl.Columns.Add("Item Quantity", "Item Quantity");
            itemListDataTbl.Columns.Add("Item Description", "Item Description");


            // Set the grn object to the form
            this.grn = grn;
            // populate the itemListDataTbl
            foreach (GrnItem item in grn.items)
            {
                itemListDataTbl.Rows.Add(item.ItemName, item.ItemCode, item.ItemDescription);
            }


            // Set the text boxes with the grn details
            grnNumberTxt.Text = grn.number;
            DateTime date = DateTime.Parse(grn.date);
            dateTxt.Text = date.ToString("yyyy-MM-dd");
            supplierTxt.Text = grn.supplier;


        }

    }
}
