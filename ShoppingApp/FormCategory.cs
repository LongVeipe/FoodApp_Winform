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
    public partial class FormCategory : Form
    {
        public FormCategory(int categorySelected)
        {
            InitializeComponent();
            tabControlCategories.SelectedIndex = categorySelected;
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 12; i++)
            {
                int category = i+1;
                DataRow[] meals = Meals.getInstant().getMealsByCategory(category); 
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.Dock = DockStyle.Fill;
                
                foreach (DataRow row in meals)
                {
                    UserControlMeal userControlMeal = new UserControlMeal(row);
                    flowLayoutPanel.Controls.Add(userControlMeal);
                }
                tabControlCategories.TabPages[i].Controls.Add(flowLayoutPanel);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            ((FormMain)this.Parent).OpenChildForm(formHome);
        }

        private void tabControlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
