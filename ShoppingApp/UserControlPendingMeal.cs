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
    public partial class UserControlPendingMeal : UserControl
    {
        DataRow meal;
        int number;

        public UserControlPendingMeal(DataRow meal, int number)
        {
            InitializeComponent();
            this.meal = meal;
            this.number = number;
        }

        private void UserControlPendingMeal_Load(object sender, EventArgs e)
        {
            string name = meal[2].ToString();
            string img = meal[3].ToString();
            int price = (int)meal[4];

            pictureBoxThumb.Image = Image.FromFile(img);
            labelName.Text = name;
            labelUnitPrice.Text = price.ToString();
            labelNumber.Text = number.ToString();
            labelTotal.Text = (price * number).ToString();
        }
    }
}
