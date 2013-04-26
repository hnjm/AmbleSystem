﻿namespace AmbleClient.Order.PoView
{
    partial class PoViewControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVendor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVendorNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPoDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPoNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShipMethod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPaymentTerms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbShipToLocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBillTo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbShipTo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbPa = new System.Windows.Forms.ComboBox();
            this.btSplit = new System.Windows.Forms.Button();
            this.cbFreight = new System.Windows.Forms.ComboBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorIntPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRecd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyCorrected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyReject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QcPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor*:";
            // 
            // tbVendor
            // 
            this.tbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVendor.Location = new System.Drawing.Point(91, 26);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.Size = new System.Drawing.Size(215, 21);
            this.tbVendor.TabIndex = 1;
            this.tbVendor.Leave += new System.EventHandler(this.tbVendor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact*:";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(391, 24);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(184, 21);
            this.tbContact.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "P/A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendor Number:";
            // 
            // tbVendorNumber
            // 
            this.tbVendorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVendorNumber.Location = new System.Drawing.Point(132, 87);
            this.tbVendorNumber.Name = "tbVendorNumber";
            this.tbVendorNumber.Size = new System.Drawing.Size(131, 21);
            this.tbVendorNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PO Date:";
            // 
            // tbPoDate
            // 
            this.tbPoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPoDate.Location = new System.Drawing.Point(348, 83);
            this.tbPoDate.Name = "tbPoDate";
            this.tbPoDate.ReadOnly = true;
            this.tbPoDate.Size = new System.Drawing.Size(114, 21);
            this.tbPoDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "PO No.";
            // 
            // tbPoNo
            // 
            this.tbPoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPoNo.Location = new System.Drawing.Point(543, 83);
            this.tbPoNo.Name = "tbPoNo";
            this.tbPoNo.ReadOnly = true;
            this.tbPoNo.Size = new System.Drawing.Size(100, 21);
            this.tbPoNo.TabIndex = 12;
            this.tbPoNo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Freight:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ship Method:";
            // 
            // tbShipMethod
            // 
            this.tbShipMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipMethod.Location = new System.Drawing.Point(117, 138);
            this.tbShipMethod.Name = "tbShipMethod";
            this.tbShipMethod.Size = new System.Drawing.Size(175, 21);
            this.tbShipMethod.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Payment Terms:";
            // 
            // tbPaymentTerms
            // 
            this.tbPaymentTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaymentTerms.Location = new System.Drawing.Point(409, 138);
            this.tbPaymentTerms.Name = "tbPaymentTerms";
            this.tbPaymentTerms.Size = new System.Drawing.Size(144, 21);
            this.tbPaymentTerms.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(581, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ship Location:";
            // 
            // tbShipToLocation
            // 
            this.tbShipToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipToLocation.Location = new System.Drawing.Point(672, 140);
            this.tbShipToLocation.Name = "tbShipToLocation";
            this.tbShipToLocation.Size = new System.Drawing.Size(137, 21);
            this.tbShipToLocation.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Bill To:";
            // 
            // tbBillTo
            // 
            this.tbBillTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillTo.Location = new System.Drawing.Point(97, 183);
            this.tbBillTo.Multiline = true;
            this.tbBillTo.Name = "tbBillTo";
            this.tbBillTo.Size = new System.Drawing.Size(294, 65);
            this.tbBillTo.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ship To:";
            // 
            // tbShipTo
            // 
            this.tbShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipTo.Location = new System.Drawing.Point(498, 183);
            this.tbShipTo.Multiline = true;
            this.tbShipTo.Name = "tbShipTo";
            this.tbShipTo.Size = new System.Drawing.Size(311, 65);
            this.tbShipTo.TabIndex = 24;
            this.tbShipTo.Enter += new System.EventHandler(this.tbShipTo_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PartNo,
            this.Mfg,
            this.Dc,
            this.VendorIntPartNo,
            this.Org,
            this.Qty,
            this.QtyRecd,
            this.QtyCorrected,
            this.QtyAccept,
            this.QtyReject,
            this.QtyRTV,
            this.QcPending,
            this.Currency,
            this.UnitPrice,
            this.Total,
            this.DueDate,
            this.RecvDate,
            this.StepCode,
            this.SalesAgent});
            this.dataGridView1.Location = new System.Drawing.Point(33, 316);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 173);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Items:";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(97, 273);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(72, 23);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(196, 273);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(67, 23);
            this.btDelete.TabIndex = 28;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbPa
            // 
            this.cbPa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPa.FormattingEnabled = true;
            this.cbPa.Location = new System.Drawing.Point(656, 24);
            this.cbPa.Name = "cbPa";
            this.cbPa.Size = new System.Drawing.Size(153, 23);
            this.cbPa.TabIndex = 5;
            // 
            // btSplit
            // 
            this.btSplit.Location = new System.Drawing.Point(293, 273);
            this.btSplit.Name = "btSplit";
            this.btSplit.Size = new System.Drawing.Size(67, 23);
            this.btSplit.TabIndex = 30;
            this.btSplit.Text = "Split";
            this.btSplit.UseVisualStyleBackColor = true;
            this.btSplit.Click += new System.EventHandler(this.btSplit_Click);
            // 
            // cbFreight
            // 
            this.cbFreight.FormattingEnabled = true;
            this.cbFreight.Items.AddRange(new object[] {
            "We Pay",
            "Vendor Pay"});
            this.cbFreight.Location = new System.Drawing.Point(712, 83);
            this.cbFreight.Name = "cbFreight";
            this.cbFreight.Size = new System.Drawing.Size(99, 21);
            this.cbFreight.TabIndex = 31;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 46;
            // 
            // PartNo
            // 
            this.PartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.PartNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.PartNo.HeaderText = "MPN";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            this.PartNo.Width = 56;
            // 
            // Mfg
            // 
            this.Mfg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mfg.HeaderText = "Mfg";
            this.Mfg.Name = "Mfg";
            this.Mfg.ReadOnly = true;
            this.Mfg.Width = 50;
            // 
            // Dc
            // 
            this.Dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dc.HeaderText = "D/C";
            this.Dc.Name = "Dc";
            this.Dc.ReadOnly = true;
            this.Dc.Width = 52;
            // 
            // VendorIntPartNo
            // 
            this.VendorIntPartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VendorIntPartNo.HeaderText = "VendorIntPart #";
            this.VendorIntPartNo.Name = "VendorIntPartNo";
            this.VendorIntPartNo.ReadOnly = true;
            this.VendorIntPartNo.Width = 98;
            // 
            // Org
            // 
            this.Org.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Org.HeaderText = "Org";
            this.Org.Name = "Org";
            this.Org.ReadOnly = true;
            this.Org.Width = 49;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 48;
            // 
            // QtyRecd
            // 
            this.QtyRecd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyRecd.HeaderText = "Qty Recd";
            this.QtyRecd.Name = "QtyRecd";
            this.QtyRecd.ReadOnly = true;
            this.QtyRecd.Width = 71;
            // 
            // QtyCorrected
            // 
            this.QtyCorrected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyCorrected.HeaderText = "Qty Corrected";
            this.QtyCorrected.Name = "QtyCorrected";
            this.QtyCorrected.ReadOnly = true;
            this.QtyCorrected.Width = 89;
            // 
            // QtyAccept
            // 
            this.QtyAccept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyAccept.HeaderText = "Qty Accept";
            this.QtyAccept.Name = "QtyAccept";
            this.QtyAccept.ReadOnly = true;
            this.QtyAccept.Width = 79;
            // 
            // QtyReject
            // 
            this.QtyReject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyReject.HeaderText = "Qty Reject";
            this.QtyReject.Name = "QtyReject";
            this.QtyReject.ReadOnly = true;
            this.QtyReject.Width = 76;
            // 
            // QtyRTV
            // 
            this.QtyRTV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyRTV.HeaderText = "Qty RTV";
            this.QtyRTV.Name = "QtyRTV";
            this.QtyRTV.ReadOnly = true;
            this.QtyRTV.Width = 68;
            // 
            // QcPending
            // 
            this.QcPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QcPending.HeaderText = "QC/Pending";
            this.QcPending.Name = "QcPending";
            this.QcPending.ReadOnly = true;
            this.QcPending.Width = 91;
            // 
            // Currency
            // 
            this.Currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Width = 74;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 72;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // DueDate
            // 
            this.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DueDate.HeaderText = "Dock Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 78;
            // 
            // RecvDate
            // 
            this.RecvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RecvDate.HeaderText = "Recv Date";
            this.RecvDate.Name = "RecvDate";
            this.RecvDate.ReadOnly = true;
            this.RecvDate.Width = 78;
            // 
            // StepCode
            // 
            this.StepCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StepCode.HeaderText = "Step Code";
            this.StepCode.Name = "StepCode";
            this.StepCode.ReadOnly = true;
            this.StepCode.Width = 76;
            // 
            // SalesAgent
            // 
            this.SalesAgent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalesAgent.HeaderText = "Sales Agent";
            this.SalesAgent.Name = "SalesAgent";
            this.SalesAgent.ReadOnly = true;
            this.SalesAgent.Width = 82;
            // 
            // PoViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFreight);
            this.Controls.Add(this.btSplit);
            this.Controls.Add(this.cbPa);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbShipTo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbBillTo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbShipToLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPaymentTerms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbShipMethod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPoNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPoDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVendorNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVendor);
            this.Controls.Add(this.label1);
            this.Name = "PoViewControl";
            this.Size = new System.Drawing.Size(880, 508);
            this.Load += new System.EventHandler(this.PoViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVendorNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPoDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPoNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShipMethod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPaymentTerms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbShipToLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBillTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbShipTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbPa;
        private System.Windows.Forms.Button btSplit;
        private System.Windows.Forms.ComboBox cbFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorIntPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRecd;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyCorrected;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QcPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesAgent;
    }
}
