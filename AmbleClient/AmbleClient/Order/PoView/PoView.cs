﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AmbleClient.Order.PoMgr;
using AmbleClient.Order;

namespace AmbleClient.Order.PoView
{

    public partial class PoView : Form
    {
        private int soId;


        private PoItemStateList poStateList = new PoItemStateList();

        private List<po> poList;
        List<PoViewControl> poViewControlList = new List<PoViewControl>();

        int? selectedPoItemId = null;



        public PoView(po poMain)
        {
            InitializeComponent();
            poList = new List<po>();
            poList.Add(poMain);
            this.Text = "PO Info for PO:" + poMain.poId;
        }

        public PoView(int poId,int? poItemId)
        {
            InitializeComponent();
            poList = new List<po>();
            poList.Add(PoMgr.PoMgr.GetPoAccordingToPoId(poId));
            this.Text = "PO Info for PO:" + poId;
            this.selectedPoItemId = poItemId;
        }


        private void GenerateGui()
        {
            po poMain = poList[tabControl1.SelectedIndex];

            PoItemState poState = poStateList.GetPoStateAccordingToValue((int)poMain.poStates);

            if (poState.WhoCanUpdate().Contains(UserInfo.Job))
            {
                tsbUpdate.Enabled = true;
            }
            else
            {
                tsbUpdate.Enabled = false;
            }
            //for list
            /*
            tscbStateList.Items.Clear();
            List<Operation> opList = poState.GetOperationList();
            foreach (Operation op in opList)
            {
                if (op.jobs.Contains(UserInfo.Job))
                {
                    tscbStateList.Items.Add(op.operationName);
                }
            }
            */

        }

        private void SoView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < poList.Count; i++)
            {
                PoViewControl poViewControlItem = new PoViewControl();
                poViewControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
                poViewControlItem.Location = new System.Drawing.Point(3, 3);
                poViewControlItem.Name = "poItem" + i;
                poViewControlItem.Size = new System.Drawing.Size(906, 456);
                poViewControlItem.TabIndex = 0;
                poViewControlItem.FillTheTable(poList[i],selectedPoItemId);
                poViewControlList.Add(poViewControlItem);
            }

            for (int i = 0; i < poViewControlList.Count; i++)
            {
                System.Windows.Forms.TabPage tabPage = new TabPage();

                tabPage.Controls.Add(poViewControlList[i]);
                tabPage.Location = new System.Drawing.Point(4, 22);
                tabPage.Name = "tabPage" + i;
                tabPage.Padding = new System.Windows.Forms.Padding(3);
                tabPage.Size = new System.Drawing.Size(941, 46297);
                tabPage.TabIndex = i;
                tabPage.Text = "PO " + i;
                tabPage.UseVisualStyleBackColor = true;
                this.tabControl1.Controls.Add(tabPage);
            }
            tabControl1_SelectedIndexChanged(this, null);

        }




        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateGui();
        }


        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            poViewControlList[tabControl1.SelectedIndex].PoUpdate();
            this.DialogResult = DialogResult.Yes;

        }

        private void tsbExportToExcel_Click(object sender, EventArgs e)
        {

            List<List<PoItemContentAndState>> poItemsListList = new List<List<PoItemContentAndState>>();

            for (int i = 0; i < poViewControlList.Count; i++)
            {
                poItemsListList.Add(poViewControlList[i].GetPoItemsStateList());
            }

            //if sales or sales Manager, the vendor and contact can not be seen


            if (UserInfo.Job == JobDescription.Sales || UserInfo.Job == JobDescription.SalesManager)
            {
                foreach (po po in poList)
                {
                    po.vendorName = "";
                    po.contact = "";
                }
            }
            SoPoExcelHelper.SavePoExcel(poList, poItemsListList);




        }

        private void tsbApprove_Click(object sender, EventArgs e)
        {
            po po = poList[tabControl1.SelectedIndex];
            PoMgr.PoMgr.WholeUpdatePoState(po.poId, (int)PoStatesEnum.Approved);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void tsbReject_Click(object sender, EventArgs e)
        {
            po po = poList[tabControl1.SelectedIndex];
            PoMgr.PoMgr.WholeUpdatePoState(po.poId, (int)PoStatesEnum.Rejected);
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            po po = poList[tabControl1.SelectedIndex];
            PoMgr.PoMgr.WholeUpdatePoState(po.poId, (int)PoStatesEnum.Cancel);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void tsbForceClose_Click(object sender, EventArgs e)
        {
            po po = poList[tabControl1.SelectedIndex];
            PoMgr.PoMgr.WholeUpdatePoState(po.poId, (int)PoStatesEnum.Closed);
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }
    }
}
