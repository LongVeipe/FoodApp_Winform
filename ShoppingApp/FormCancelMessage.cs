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
    public partial class FormCancelMessage : Form
    {
        Bill bill;
        public FormCancelMessage(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void FormCancelMessage_Load(object sender, EventArgs e)
        {
            labelMess.Text = "Please enter the reason \n for canceling the order";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bill.CancelOrder(textBoxReason.Text);
            this.Dispose();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReason.Text != "")
                buttonYes.Enabled = true;
            else
                buttonYes.Enabled = false;
        }
    }
}
