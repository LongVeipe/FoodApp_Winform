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
    public partial class FormCart : Form
    {
        DataRow[] meals;
        public FormCart()
        {
            InitializeComponent();
        }

        public void CalcuTotalPrice()
        {
            int total = 0;
            foreach (DataRow item in meals)
            {
                total += (int)item[4] * (int)item[5];
            }

            labelTotalPrice.Text = (total + 23000).ToString() + "  vnđ";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            ((FormMain)this.Parent).OpenChildForm(formHome);
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            meals = Meals.getInstant().getSelectedMeals();
            int total = 0;
            foreach(DataRow item in meals)
            {
                UserControlCartItem userControl = new UserControlCartItem(item);
                userControl.Dock = DockStyle.Top;
                flowLayoutPanelCart.Controls.Add(userControl);
                total += (int)item[4] * (int)item[5];
            }

            labelTotalPrice.Text = (total+23000).ToString() + "  vnđ";
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            DateTime dateTimeOrder = DateTime.Now;
            Bill newBill = new Bill(meals, textBoxAddress.Text, dateTimeOrder);
            Bills.getInstant().add(newBill);

            Meals.getInstant().Pay();
            foreach(Control item in this.flowLayoutPanelCart.Controls)
            {
                this.flowLayoutPanelCart.Controls.Remove(item);
                flowLayoutPanelCart.Dispose();
            }

            labelTotalPrice.Text = "0  vnđ";
        }
    }
}
