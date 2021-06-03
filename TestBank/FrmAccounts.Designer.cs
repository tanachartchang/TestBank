
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewCustAcc = new System.Windows.Forms.ListView();
            this.colAccNo = new System.Windows.Forms.ColumnHeader();
            this.colBalance = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDeposite = new System.Windows.Forms.TabPage();
            this.numericDeptVal = new System.Windows.Forms.NumericUpDown();
            this.labelDeptTotal = new System.Windows.Forms.Label();
            this.textBoxDeptTotal = new System.Windows.Forms.TextBox();
            this.labelDeptFee = new System.Windows.Forms.Label();
            this.textBoxDeptFee = new System.Windows.Forms.TextBox();
            this.labelDeptVal = new System.Windows.Forms.Label();
            this.buttonDeposite = new System.Windows.Forms.Button();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.numericWitdrVal = new System.Windows.Forms.NumericUpDown();
            this.buttonWitdr = new System.Windows.Forms.Button();
            this.labelWitdrTotal = new System.Windows.Forms.Label();
            this.labelWitdr = new System.Windows.Forms.Label();
            this.textBoxWitdrTotal = new System.Windows.Forms.TextBox();
            this.textBoxWitdrFee = new System.Windows.Forms.TextBox();
            this.labelWitdrFee = new System.Windows.Forms.Label();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.numericTransVal = new System.Windows.Forms.NumericUpDown();
            this.labelTransTotal = new System.Windows.Forms.Label();
            this.labelTransTo = new System.Windows.Forms.Label();
            this.textBoxTransTotal = new System.Windows.Forms.TextBox();
            this.comboBoxTransTo = new System.Windows.Forms.ComboBox();
            this.labelTransFee = new System.Windows.Forms.Label();
            this.labelTransVal = new System.Windows.Forms.Label();
            this.textBoxTransFee = new System.Windows.Forms.TextBox();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDeposite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeptVal)).BeginInit();
            this.tabWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWitdrVal)).BeginInit();
            this.tabTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTransVal)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(578, 510);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 1;
            // 
            // listViewCustAcc
            // 
            this.listViewCustAcc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccNo,
            this.colBalance});
            this.listViewCustAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listViewCustAcc.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listViewCustAcc.HideSelection = false;
            this.listViewCustAcc.Location = new System.Drawing.Point(0, 0);
            this.listViewCustAcc.MultiSelect = false;
            this.listViewCustAcc.Name = "listViewCustAcc";
            this.listViewCustAcc.Size = new System.Drawing.Size(209, 510);
            this.listViewCustAcc.TabIndex = 0;
            this.listViewCustAcc.UseCompatibleStateImageBehavior = false;
            this.listViewCustAcc.View = System.Windows.Forms.View.Details;
            this.listViewCustAcc.SelectedIndexChanged += new System.EventHandler(this.listViewCustAcc_SelectedIndexChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDeposite);
            this.tabControl1.Controls.Add(this.tabWithdraw);
            this.tabControl1.Controls.Add(this.tabTransfer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 359);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 151);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDeposite
            // 
            this.tabDeposite.Controls.Add(this.numericDeptVal);
            this.tabDeposite.Controls.Add(this.labelDeptTotal);
            this.tabDeposite.Controls.Add(this.textBoxDeptTotal);
            this.tabDeposite.Controls.Add(this.labelDeptFee);
            this.tabDeposite.Controls.Add(this.textBoxDeptFee);
            this.tabDeposite.Controls.Add(this.labelDeptVal);
            this.tabDeposite.Controls.Add(this.buttonDeposite);
            this.tabDeposite.Location = new System.Drawing.Point(4, 24);
            this.tabDeposite.Name = "tabDeposite";
            this.tabDeposite.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposite.Size = new System.Drawing.Size(357, 123);
            this.tabDeposite.TabIndex = 0;
            this.tabDeposite.Text = "Deposite";
            this.tabDeposite.UseVisualStyleBackColor = true;
            // 
            // numericDeptVal
            // 
            this.numericDeptVal.DecimalPlaces = 2;
            this.numericDeptVal.Location = new System.Drawing.Point(65, 7);
            this.numericDeptVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDeptVal.Name = "numericDeptVal";
            this.numericDeptVal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericDeptVal.Size = new System.Drawing.Size(205, 23);
            this.numericDeptVal.TabIndex = 2;
            this.numericDeptVal.ValueChanged += new System.EventHandler(this.numericDeptVal_ValueChanged);
            // 
            // labelDeptTotal
            // 
            this.labelDeptTotal.AutoSize = true;
            this.labelDeptTotal.Location = new System.Drawing.Point(27, 67);
            this.labelDeptTotal.Name = "labelDeptTotal";
            this.labelDeptTotal.Size = new System.Drawing.Size(32, 15);
            this.labelDeptTotal.TabIndex = 14;
            this.labelDeptTotal.Text = "Total";
            // 
            // textBoxDeptTotal
            // 
            this.textBoxDeptTotal.Location = new System.Drawing.Point(65, 64);
            this.textBoxDeptTotal.Name = "textBoxDeptTotal";
            this.textBoxDeptTotal.ReadOnly = true;
            this.textBoxDeptTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDeptTotal.Size = new System.Drawing.Size(205, 23);
            this.textBoxDeptTotal.TabIndex = 15;
            // 
            // labelDeptFee
            // 
            this.labelDeptFee.AutoSize = true;
            this.labelDeptFee.Location = new System.Drawing.Point(6, 38);
            this.labelDeptFee.Name = "labelDeptFee";
            this.labelDeptFee.Size = new System.Drawing.Size(25, 15);
            this.labelDeptFee.TabIndex = 12;
            this.labelDeptFee.Text = "Fee";
            // 
            // textBoxDeptFee
            // 
            this.textBoxDeptFee.Location = new System.Drawing.Point(65, 35);
            this.textBoxDeptFee.Name = "textBoxDeptFee";
            this.textBoxDeptFee.ReadOnly = true;
            this.textBoxDeptFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDeptFee.Size = new System.Drawing.Size(205, 23);
            this.textBoxDeptFee.TabIndex = 13;
            // 
            // labelDeptVal
            // 
            this.labelDeptVal.AutoSize = true;
            this.labelDeptVal.Location = new System.Drawing.Point(26, 9);
            this.labelDeptVal.Name = "labelDeptVal";
            this.labelDeptVal.Size = new System.Drawing.Size(33, 15);
            this.labelDeptVal.TabIndex = 10;
            this.labelDeptVal.Text = "Cash";
            // 
            // buttonDeposite
            // 
            this.buttonDeposite.Location = new System.Drawing.Point(276, 6);
            this.buttonDeposite.Name = "buttonDeposite";
            this.buttonDeposite.Size = new System.Drawing.Size(75, 81);
            this.buttonDeposite.TabIndex = 11;
            this.buttonDeposite.Text = "Confirm";
            this.buttonDeposite.UseVisualStyleBackColor = true;
            this.buttonDeposite.Click += new System.EventHandler(this.buttonDeposite_Click);
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.Controls.Add(this.numericWitdrVal);
            this.tabWithdraw.Controls.Add(this.buttonWitdr);
            this.tabWithdraw.Controls.Add(this.labelWitdrTotal);
            this.tabWithdraw.Controls.Add(this.labelWitdr);
            this.tabWithdraw.Controls.Add(this.textBoxWitdrTotal);
            this.tabWithdraw.Controls.Add(this.textBoxWitdrFee);
            this.tabWithdraw.Controls.Add(this.labelWitdrFee);
            this.tabWithdraw.Location = new System.Drawing.Point(4, 24);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdraw.Size = new System.Drawing.Size(357, 123);
            this.tabWithdraw.TabIndex = 1;
            this.tabWithdraw.Text = "Withdraw";
            this.tabWithdraw.UseVisualStyleBackColor = true;
            // 
            // numericWitdrVal
            // 
            this.numericWitdrVal.DecimalPlaces = 2;
            this.numericWitdrVal.Location = new System.Drawing.Point(65, 7);
            this.numericWitdrVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericWitdrVal.Name = "numericWitdrVal";
            this.numericWitdrVal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericWitdrVal.Size = new System.Drawing.Size(205, 23);
            this.numericWitdrVal.TabIndex = 16;
            this.numericWitdrVal.ValueChanged += new System.EventHandler(this.numericWitdrVal_ValueChanged);
            // 
            // buttonWitdr
            // 
            this.buttonWitdr.Location = new System.Drawing.Point(276, 6);
            this.buttonWitdr.Name = "buttonWitdr";
            this.buttonWitdr.Size = new System.Drawing.Size(75, 81);
            this.buttonWitdr.TabIndex = 18;
            this.buttonWitdr.Text = "Confirm";
            this.buttonWitdr.UseVisualStyleBackColor = true;
            this.buttonWitdr.Click += new System.EventHandler(this.buttonWitdr_Click);
            // 
            // labelWitdrTotal
            // 
            this.labelWitdrTotal.AutoSize = true;
            this.labelWitdrTotal.Location = new System.Drawing.Point(27, 67);
            this.labelWitdrTotal.Name = "labelWitdrTotal";
            this.labelWitdrTotal.Size = new System.Drawing.Size(33, 15);
            this.labelWitdrTotal.TabIndex = 21;
            this.labelWitdrTotal.Text = "Cash";
            // 
            // labelWitdr
            // 
            this.labelWitdr.AutoSize = true;
            this.labelWitdr.Location = new System.Drawing.Point(1, 9);
            this.labelWitdr.Name = "labelWitdr";
            this.labelWitdr.Size = new System.Drawing.Size(58, 15);
            this.labelWitdr.TabIndex = 17;
            this.labelWitdr.Text = "Withdraw";
            // 
            // textBoxWitdrTotal
            // 
            this.textBoxWitdrTotal.Location = new System.Drawing.Point(65, 64);
            this.textBoxWitdrTotal.Name = "textBoxWitdrTotal";
            this.textBoxWitdrTotal.ReadOnly = true;
            this.textBoxWitdrTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxWitdrTotal.Size = new System.Drawing.Size(205, 23);
            this.textBoxWitdrTotal.TabIndex = 22;
            // 
            // textBoxWitdrFee
            // 
            this.textBoxWitdrFee.Location = new System.Drawing.Point(65, 35);
            this.textBoxWitdrFee.Name = "textBoxWitdrFee";
            this.textBoxWitdrFee.ReadOnly = true;
            this.textBoxWitdrFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxWitdrFee.Size = new System.Drawing.Size(205, 23);
            this.textBoxWitdrFee.TabIndex = 20;
            // 
            // labelWitdrFee
            // 
            this.labelWitdrFee.AutoSize = true;
            this.labelWitdrFee.Location = new System.Drawing.Point(6, 38);
            this.labelWitdrFee.Name = "labelWitdrFee";
            this.labelWitdrFee.Size = new System.Drawing.Size(25, 15);
            this.labelWitdrFee.TabIndex = 19;
            this.labelWitdrFee.Text = "Fee";
            // 
            // tabTransfer
            // 
            this.tabTransfer.Controls.Add(this.numericTransVal);
            this.tabTransfer.Controls.Add(this.labelTransTotal);
            this.tabTransfer.Controls.Add(this.labelTransTo);
            this.tabTransfer.Controls.Add(this.textBoxTransTotal);
            this.tabTransfer.Controls.Add(this.comboBoxTransTo);
            this.tabTransfer.Controls.Add(this.labelTransFee);
            this.tabTransfer.Controls.Add(this.labelTransVal);
            this.tabTransfer.Controls.Add(this.textBoxTransFee);
            this.tabTransfer.Controls.Add(this.buttonTrans);
            this.tabTransfer.Location = new System.Drawing.Point(4, 24);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfer.Size = new System.Drawing.Size(357, 123);
            this.tabTransfer.TabIndex = 2;
            this.tabTransfer.Text = "Transfer";
            this.tabTransfer.UseVisualStyleBackColor = true;
            // 
            // numericTransVal
            // 
            this.numericTransVal.DecimalPlaces = 2;
            this.numericTransVal.Location = new System.Drawing.Point(74, 35);
            this.numericTransVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTransVal.Name = "numericTransVal";
            this.numericTransVal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericTransVal.Size = new System.Drawing.Size(196, 23);
            this.numericTransVal.TabIndex = 20;
            this.numericTransVal.ValueChanged += new System.EventHandler(this.numericTransVal_ValueChanged);
            // 
            // labelTransTotal
            // 
            this.labelTransTotal.AutoSize = true;
            this.labelTransTotal.Location = new System.Drawing.Point(36, 96);
            this.labelTransTotal.Name = "labelTransTotal";
            this.labelTransTotal.Size = new System.Drawing.Size(32, 15);
            this.labelTransTotal.TabIndex = 18;
            this.labelTransTotal.Text = "Total";
            // 
            // labelTransTo
            // 
            this.labelTransTo.AutoSize = true;
            this.labelTransTo.Location = new System.Drawing.Point(6, 9);
            this.labelTransTo.Name = "labelTransTo";
            this.labelTransTo.Size = new System.Drawing.Size(62, 15);
            this.labelTransTo.TabIndex = 16;
            this.labelTransTo.Text = "Transfer to";
            // 
            // textBoxTransTotal
            // 
            this.textBoxTransTotal.Location = new System.Drawing.Point(74, 93);
            this.textBoxTransTotal.Name = "textBoxTransTotal";
            this.textBoxTransTotal.ReadOnly = true;
            this.textBoxTransTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTransTotal.Size = new System.Drawing.Size(196, 23);
            this.textBoxTransTotal.TabIndex = 19;
            // 
            // comboBoxTransTo
            // 
            this.comboBoxTransTo.FormattingEnabled = true;
            this.comboBoxTransTo.Location = new System.Drawing.Point(74, 6);
            this.comboBoxTransTo.Name = "comboBoxTransTo";
            this.comboBoxTransTo.Size = new System.Drawing.Size(196, 23);
            this.comboBoxTransTo.TabIndex = 15;
            // 
            // labelTransFee
            // 
            this.labelTransFee.AutoSize = true;
            this.labelTransFee.Location = new System.Drawing.Point(15, 67);
            this.labelTransFee.Name = "labelTransFee";
            this.labelTransFee.Size = new System.Drawing.Size(25, 15);
            this.labelTransFee.TabIndex = 16;
            this.labelTransFee.Text = "Fee";
            // 
            // labelTransVal
            // 
            this.labelTransVal.AutoSize = true;
            this.labelTransVal.Location = new System.Drawing.Point(28, 39);
            this.labelTransVal.Name = "labelTransVal";
            this.labelTransVal.Size = new System.Drawing.Size(35, 15);
            this.labelTransVal.TabIndex = 12;
            this.labelTransVal.Text = "Value";
            // 
            // textBoxTransFee
            // 
            this.textBoxTransFee.Location = new System.Drawing.Point(74, 64);
            this.textBoxTransFee.Name = "textBoxTransFee";
            this.textBoxTransFee.ReadOnly = true;
            this.textBoxTransFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTransFee.Size = new System.Drawing.Size(196, 23);
            this.textBoxTransFee.TabIndex = 17;
            // 
            // buttonTrans
            // 
            this.buttonTrans.Location = new System.Drawing.Point(276, 6);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(75, 110);
            this.buttonTrans.TabIndex = 14;
            this.buttonTrans.Text = "Confirm";
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAccNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCustID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(111, 138);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBalance.Size = new System.Drawing.Size(205, 23);
            this.textBoxBalance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balance";
            // 
            // textBoxAccNo
            // 
            this.textBoxAccNo.Location = new System.Drawing.Point(111, 109);
            this.textBoxAccNo.Name = "textBoxAccNo";
            this.textBoxAccNo.ReadOnly = true;
            this.textBoxAccNo.Size = new System.Drawing.Size(205, 23);
            this.textBoxAccNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Account Number";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(111, 80);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(205, 23);
            this.textBoxSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(205, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(111, 22);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.ReadOnly = true;
            this.textBoxCustID.Size = new System.Drawing.Size(205, 23);
            this.textBoxCustID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 510);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAccounts";
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDeposite.ResumeLayout(false);
            this.tabDeposite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeptVal)).EndInit();
            this.tabWithdraw.ResumeLayout(false);
            this.tabWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWitdrVal)).EndInit();
            this.tabTransfer.ResumeLayout(false);
            this.tabTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTransVal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewCustAcc;
        private System.Windows.Forms.ColumnHeader colAccNo;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeposite;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAccNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDeptFee;
        private System.Windows.Forms.TextBox textBoxDeptFee;
        private System.Windows.Forms.Label labelDeptVal;
        private System.Windows.Forms.Button buttonDeposite;
        private System.Windows.Forms.Label labelDeptTotal;
        private System.Windows.Forms.TextBox textBoxDeptTotal;
        private System.Windows.Forms.Label labelTransTo;
        private System.Windows.Forms.ComboBox comboBoxTransTo;
        private System.Windows.Forms.Label labelTransVal;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.NumericUpDown numericDeptVal;
        private System.Windows.Forms.Label labelTransTotal;
        private System.Windows.Forms.TextBox textBoxTransTotal;
        private System.Windows.Forms.Label labelTransFee;
        private System.Windows.Forms.TextBox textBoxTransFee;
        private System.Windows.Forms.NumericUpDown numericTransVal;
        private System.Windows.Forms.NumericUpDown numericWitdrVal;
        private System.Windows.Forms.Button buttonWitdr;
        private System.Windows.Forms.Label labelWitdrTotal;
        private System.Windows.Forms.Label labelWitdr;
        private System.Windows.Forms.TextBox textBoxWitdrTotal;
        private System.Windows.Forms.TextBox textBoxWitdrFee;
        private System.Windows.Forms.Label labelWitdrFee;
    }
}