
namespace TestBank
{
    partial class FrmAccounts
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewCustAcc = new System.Windows.Forms.ListView();
            this.colAccNo = new System.Windows.Forms.ColumnHeader();
            this.colBalance = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewCustAcc);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 1;
            // 
            // listViewCustAcc
            // 
            this.listViewCustAcc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccNo,
            this.colBalance});
            this.listViewCustAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewCustAcc.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewCustAcc.HideSelection = false;
            this.listViewCustAcc.Location = new System.Drawing.Point(0, 0);
            this.listViewCustAcc.MultiSelect = false;
            this.listViewCustAcc.Name = "listViewCustAcc";
            this.listViewCustAcc.Size = new System.Drawing.Size(184, 450);
            this.listViewCustAcc.TabIndex = 0;
            this.listViewCustAcc.UseCompatibleStateImageBehavior = false;
            this.listViewCustAcc.View = System.Windows.Forms.View.Details;
            this.listViewCustAcc.SelectedIndexChanged += new System.EventHandler(this.listViewCust_SelectedIndexChanged);
            // 
            // colAccNo
            // 
            this.colAccNo.Text = "Account No";
            this.colAccNo.Width = 100;
            // 
            // colBalance
            // 
            this.colBalance.Text = "Balance";
            this.colBalance.Width = 100;
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAccounts";
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewCustAcc;
        private System.Windows.Forms.ColumnHeader colAccNo;
        private System.Windows.Forms.ColumnHeader colBalance;
    }
}