using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class UserControlMeal : UserControl
    {
        DataRow meal;
        public UserControlMeal(DataRow data)
        {
            InitializeComponent();
            this.meal = data;
        }

        private void UserControlMeal_Load(object sender, EventArgs e)
        {
            string id = meal[0].ToString();
            int category = (int)meal[1];
            string name = meal[2].ToString();
            string img = meal[3].ToString();
            int price = (int)meal[4];
            int number = (int)meal[5];

            pictureBoxThumb.Image = Image.FromFile(img);
            labelName.Text = name;
            buttonPrice.Text = price.ToString() + " vnđ";
            numericUpDownNumber.Value = number;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int number = (int)numericUpDownNumber.Value;
            Meals.getInstant().changeNumber(meal[0].ToString(), number);
        }
    }
}
