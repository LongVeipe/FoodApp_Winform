using ShoppingApp.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class FormBills : Form
    {
        FlowLayoutPanel crtFlowLayout;
        TabPage crtTabPage;
        public FormBills()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            ((FormMain)this.Parent).OpenChildForm(formHome);
        }

        private void FormBills_Load(object sender, EventArgs e)
        {
            List<Bill> pendingBills = Bills.getInstant().getPendingBills();
            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            crtFlowLayout = flowLayout;
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.AutoScroll = true;
            foreach (Bill bill in pendingBills)
            {
                UserControlPendingBill userControl = new UserControlPendingBill(bill);
                userControl.Dock = DockStyle.Top;
                flowLayout.Controls.Add(userControl);
            }
            crtTabPage = this.tabControlCategories.TabPages[0];
            crtTabPage.Controls.Add(flowLayout);
        }

        private void tabControlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            crtFlowLayout.Dispose();
            crtTabPage.Controls.Remove(crtFlowLayout);
            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.AutoScroll = true;
            crtFlowLayout = flowLayout;
            if(tabControlCategories.SelectedIndex == 0)
            {
                crtTabPage = tabControlCategories.TabPages[0];
                List<Bill> pendingBills = Bills.getInstant().getPendingBills();
                foreach (Bill bill in pendingBills)
                {
                    UserControlPendingBill userControl = new UserControlPendingBill(bill);
                    userControl.Dock = DockStyle.Top;
                    flowLayout.Controls.Add(userControl);
                }
            }
            else if(tabControlCategories.SelectedIndex == 1)
            {
                crtTabPage = tabControlCategories.TabPages[1];
                List<Bill> deliveringBills = Bills.getInstant().getDeliveringBills();
                foreach (Bill bill in deliveringBills)
                {
                    UserControlDeliveringBill userControl = new UserControlDeliveringBill(bill);
                    userControl.Dock = DockStyle.Top;
                    flowLayout.Controls.Add(userControl);
                }
            }
            else if(tabControlCategories.SelectedIndex == 2)
            {
                crtTabPage = tabControlCategories.TabPages[2];
                List<Bill> canceledBills = Bills.getInstant().getCanceledBills();
                foreach (Bill bill in canceledBills)
                {
                    UserControlCanceledBill userControl = new UserControlCanceledBill(bill);
                    userControl.Dock = DockStyle.Top;
                    flowLayout.Controls.Add(userControl);
                }
            }


            crtTabPage.Controls.Add(flowLayout);
        }
    }
}
