namespace GRN_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grnNumberLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grnNumberTxt = new System.Windows.Forms.TextBox();
            this.itemListDataTbl = new System.Windows.Forms.DataGridView();
            this.grnDate = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.itemQuantityTxt = new System.Windows.Forms.TextBox();
            this.itemDescriptionTxt = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.supplierCmb = new System.Windows.Forms.ComboBox();
            this.filterTbl = new System.Windows.Forms.DataGridView();
            this.filterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.filterGrnNumTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filterSupplierCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterClearBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.genReportBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemListDataTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterTbl)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grnNumberLbl
            // 
            this.grnNumberLbl.AutoSize = true;
            this.grnNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnNumberLbl.Location = new System.Drawing.Point(49, 65);
            this.grnNumberLbl.Name = "grnNumberLbl";
            this.grnNumberLbl.Size = new System.Drawing.Size(93, 17);
            this.grnNumberLbl.TabIndex = 0;
            this.grnNumberLbl.Text = "GRN Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier";
            // 
            // grnNumberTxt
            // 
            this.grnNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnNumberTxt.Location = new System.Drawing.Point(169, 62);
            this.grnNumberTxt.MaxLength = 20;
            this.grnNumberTxt.Name = "grnNumberTxt";
            this.grnNumberTxt.Size = new System.Drawing.Size(335, 23);
            this.grnNumberTxt.TabIndex = 1;
            // 
            // itemListDataTbl
            // 
            this.itemListDataTbl.AllowUserToAddRows = false;
            this.itemListDataTbl.AllowUserToOrderColumns = true;
            this.itemListDataTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemListDataTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemListDataTbl.Location = new System.Drawing.Point(535, 237);
            this.itemListDataTbl.Name = "itemListDataTbl";
            this.itemListDataTbl.ReadOnly = true;
            this.itemListDataTbl.Size = new System.Drawing.Size(692, 184);
            this.itemListDataTbl.TabIndex = 8;
            this.itemListDataTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.itemListDataTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grnDate
            // 
            this.grnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnDate.Location = new System.Drawing.Point(840, 62);
            this.grnDate.Name = "grnDate";
            this.grnDate.Size = new System.Drawing.Size(270, 22);
            this.grnDate.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1140, 455);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 38);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Submit GRN";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item Description";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTxt.Location = new System.Drawing.Point(169, 237);
            this.itemNameTxt.MaxLength = 50;
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(335, 22);
            this.itemNameTxt.TabIndex = 4;
            // 
            // itemQuantityTxt
            // 
            this.itemQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityTxt.Location = new System.Drawing.Point(169, 286);
            this.itemQuantityTxt.MaxLength = 10;
            this.itemQuantityTxt.Name = "itemQuantityTxt";
            this.itemQuantityTxt.Size = new System.Drawing.Size(335, 23);
            this.itemQuantityTxt.TabIndex = 5;
            this.itemQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemQuantityTxt__KeyPress);
            // 
            // itemDescriptionTxt
            // 
            this.itemDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionTxt.Location = new System.Drawing.Point(169, 333);
            this.itemDescriptionTxt.MaxLength = 100;
            this.itemDescriptionTxt.Multiline = true;
            this.itemDescriptionTxt.Name = "itemDescriptionTxt";
            this.itemDescriptionTxt.Size = new System.Drawing.Size(335, 44);
            this.itemDescriptionTxt.TabIndex = 6;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(402, 383);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(102, 38);
            this.addItemBtn.TabIndex = 7;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.Location = new System.Drawing.Point(294, 383);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(102, 38);
            this.updateItemBtn.TabIndex = 9;
            this.updateItemBtn.Text = "Update";
            this.updateItemBtn.UseVisualStyleBackColor = true;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(186, 383);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(102, 38);
            this.deleteItemBtn.TabIndex = 10;
            this.deleteItemBtn.Text = "Delete";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // supplierCmb
            // 
            this.supplierCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierCmb.FormattingEnabled = true;
            this.supplierCmb.Location = new System.Drawing.Point(169, 112);
            this.supplierCmb.Name = "supplierCmb";
            this.supplierCmb.Size = new System.Drawing.Size(335, 24);
            this.supplierCmb.Sorted = true;
            this.supplierCmb.TabIndex = 3;
            // 
            // filterTbl
            // 
            this.filterTbl.AllowUserToAddRows = false;
            this.filterTbl.AllowUserToOrderColumns = true;
            this.filterTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filterTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterTbl.Location = new System.Drawing.Point(535, 576);
            this.filterTbl.Name = "filterTbl";
            this.filterTbl.ReadOnly = true;
            this.filterTbl.Size = new System.Drawing.Size(692, 354);
            this.filterTbl.TabIndex = 18;
            this.filterTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filterTable_CellContentClick);
            // 
            // filterDatePicker
            // 
            this.filterDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDatePicker.Location = new System.Drawing.Point(157, 153);
            this.filterDatePicker.Name = "filterDatePicker";
            this.filterDatePicker.Size = new System.Drawing.Size(335, 22);
            this.filterDatePicker.TabIndex = 12;
            this.filterDatePicker.Value = new System.DateTime(2024, 3, 11, 22, 43, 52, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date";
            // 
            // filterGrnNumTxt
            // 
            this.filterGrnNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGrnNumTxt.Location = new System.Drawing.Point(157, 46);
            this.filterGrnNumTxt.MaxLength = 20;
            this.filterGrnNumTxt.Name = "filterGrnNumTxt";
            this.filterGrnNumTxt.Size = new System.Drawing.Size(335, 23);
            this.filterGrnNumTxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "GRN Number";
            // 
            // filterSupplierCmb
            // 
            this.filterSupplierCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSupplierCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSupplierCmb.FormattingEnabled = true;
            this.filterSupplierCmb.Location = new System.Drawing.Point(169, 629);
            this.filterSupplierCmb.Name = "filterSupplierCmb";
            this.filterSupplierCmb.Size = new System.Drawing.Size(335, 24);
            this.filterSupplierCmb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Supplier";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(390, 181);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(102, 38);
            this.filterBtn.TabIndex = 15;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterClearBtn
            // 
            this.filterClearBtn.Location = new System.Drawing.Point(282, 181);
            this.filterClearBtn.Name = "filterClearBtn";
            this.filterClearBtn.Size = new System.Drawing.Size(102, 38);
            this.filterClearBtn.TabIndex = 16;
            this.filterClearBtn.Text = "Clear";
            this.filterClearBtn.UseVisualStyleBackColor = true;
            this.filterClearBtn.Click += new System.EventHandler(this.filterClearBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1217, 119);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRN General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1250, 501);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add GRN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(13, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1217, 270);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Select a row to update or delete.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filterBtn);
            this.groupBox4.Controls.Add(this.genReportBtn);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.filterClearBtn);
            this.groupBox4.Controls.Add(this.filterGrnNumTxt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.filterDatePicker);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 530);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1250, 438);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View GRN";
            // 
            // genReportBtn
            // 
            this.genReportBtn.Location = new System.Drawing.Point(390, 362);
            this.genReportBtn.Name = "genReportBtn";
            this.genReportBtn.Size = new System.Drawing.Size(102, 38);
            this.genReportBtn.TabIndex = 17;
            this.genReportBtn.Text = "Report...";
            this.genReportBtn.UseVisualStyleBackColor = true;
            this.genReportBtn.Click += new System.EventHandler(this.genReportBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Select a row to view item details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 1002);
            this.Controls.Add(this.filterSupplierCmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filterTbl);
            this.Controls.Add(this.supplierCmb);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.updateItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.itemDescriptionTxt);
            this.Controls.Add(this.itemQuantityTxt);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.grnDate);
            this.Controls.Add(this.itemListDataTbl);
            this.Controls.Add(this.grnNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grnNumberLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Manage GRN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemListDataTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterTbl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grnNumberLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grnNumberTxt;
        private System.Windows.Forms.DataGridView itemListDataTbl;
        private System.Windows.Forms.DateTimePicker grnDate;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.TextBox itemQuantityTxt;
        private System.Windows.Forms.TextBox itemDescriptionTxt;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.DataGridView filterTbl;
        private System.Windows.Forms.DateTimePicker filterDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filterGrnNumTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filterSupplierCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button filterClearBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox supplierCmb;
        private System.Windows.Forms.Button genReportBtn;
    }
}

