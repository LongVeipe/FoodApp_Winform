using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingApp.data;

namespace ShoppingApp
{
    public partial class UserControlDeliveringBill : UserControl
    {
        Bill bill;
        public UserControlDeliveringBill(Bill data)
        {
            InitializeComponent();
            bill = data;
        }

        private void UserControlPendingBill_Load(object sender, EventArgs e)
        {
            DataRow[] meals = bill.getMeals();
            int[] numbers = bill.getNumbers();
            string address = bill.getAddress();
            int totalPrice = 23000;

            for(int i = 0; i < meals.Length; i++)
            {
                UserControlPendingMeal userControl = new UserControlPendingMeal(meals[i], numbers[i]);
                userControl.Dock = DockStyle.Top;
                this.flowLayoutPanelBill.Controls.Add(userControl);
                totalPrice += (int)meals[i][4] * numbers[i];
            }

            this.labelTotalPrice.Text = totalPrice.ToString() + "  vnđ";
            this.labelDate.Text = bill.getDateOrder().ToString();
            this.labelAdress.Text = "Address: " + bill.getAddress();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
