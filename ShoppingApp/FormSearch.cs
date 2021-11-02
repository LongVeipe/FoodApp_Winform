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
    public partial class FormSearch : Form
    {
        FlowLayoutPanel currentFlowLayoutPanel;
        public FormSearch(string textSearch)
        {
            InitializeComponent();
            textBoxSearch.Text = textSearch;
            labelKeyWords.Text = "Showing results for \"" + textSearch + "\"";
            SearchMeals();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            ((FormMain)this.Parent).OpenChildForm(formHome);
        }

        void SearchMeals()
        {
            if(currentFlowLayoutPanel != null)
                this.panelSearch.Controls.Remove(currentFlowLayoutPanel);
            DataRow[] meals = Meals.getInstant().getMealsByName(textBoxSearch.Text);
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            currentFlowLayoutPanel = flowLayoutPanel;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;

            foreach (DataRow row in meals)
            {
                UserControlMealSearch userControlMeal = new UserControlMealSearch(row);
                flowLayoutPanel.Controls.Add(userControlMeal);
            }
            this.panelSearch.Controls.Add(flowLayoutPanel);
            labelKeyWords.Text = "Showing results for \"" + textBoxSearch.Text + "\"";
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SearchMeals();
            }
        }

    }
}
