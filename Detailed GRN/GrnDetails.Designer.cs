namespace GRN_Manager
{
    partial class GrnDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemListDataTbl = new System.Windows.Forms.DataGridView();
            this.grnNumberTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.supplierTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemListDataTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRN Number";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(402, 46);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(30, 13);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // itemListDataTbl
            // 
            this.itemListDataTbl.AllowUserToAddRows = false;
            this.itemListDataTbl.AllowUserToOrderColumns = true;
            this.itemListDataTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemListDataTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemListDataTbl.Location = new System.Drawing.Point(26, 153);
            this.itemListDataTbl.Name = "itemListDataTbl";
            this.itemListDataTbl.ReadOnly = true;
            this.itemListDataTbl.Size = new System.Drawing.Size(1026, 349);
            this.itemListDataTbl.TabIndex = 8;
            // 
            // grnNumberTxt
            // 
            this.grnNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnNumberTxt.Location = new System.Drawing.Point(100, 41);
            this.grnNumberTxt.Name = "grnNumberTxt";
            this.grnNumberTxt.ReadOnly = true;
            this.grnNumberTxt.Size = new System.Drawing.Size(232, 23);
            this.grnNumberTxt.TabIndex = 9;
            // 
            // dateTxt
            // 
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(450, 41);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(232, 23);
            this.dateTxt.TabIndex = 10;
            // 
            // supplierTxt
            // 
            this.supplierTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierTxt.Location = new System.Drawing.Point(816, 41);
            this.supplierTxt.Name = "supplierTxt";
            this.supplierTxt.ReadOnly = true;
            this.supplierTxt.Size = new System.Drawing.Size(232, 23);
            this.supplierTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Items";
            // 
            // GrnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplierTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.grnNumberTxt);
            this.Controls.Add(this.itemListDataTbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label1);
            this.Name = "GrnDetails";
            this.Text = "GRN Details";
            ((System.ComponentModel.ISupportInitialize)(this.itemListDataTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemListDataTbl;
        private System.Windows.Forms.TextBox grnNumberTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox supplierTxt;
        private System.Windows.Forms.Label label3;
    }
}