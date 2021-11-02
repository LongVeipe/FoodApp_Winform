using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class FormHome : Form
    {
        private FormMain prtFrm;
        public FormHome()
        {
            InitializeComponent();
            prtFrm =(FormMain) (this.Parent);
            initTag();
        }


        private void initTag()
        {
            buttonBeef.Tag = 0;
            buttonChicken.Tag = 1;
            buttonDessert.Tag = 2;
            buttonLamb.Tag = 3;
            buttonMiscellaneous.Tag = 4;
            buttonPasta.Tag = 5;
            buttonPork.Tag = 6;
            buttonSeafood.Tag = 7;
        }

        void OpenFormCategory(object sender)
        {
            Guna2Button button = (Guna2Button)sender;
            FormCategory formCategory = new FormCategory((int)button.Tag);
            ((FormMain)this.Parent).OpenChildForm(formCategory);
        }

        private void buttonBeef_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonChicken_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonLamb_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonMiscellaneous_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonPasta_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonPork_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void buttonSeafood_Click(object sender, EventArgs e)
        {
            OpenFormCategory(sender);
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FormSearch form = new FormSearch(textBoxSearch.Text);
                ((FormMain)this.Parent).OpenChildForm(form);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormCart form = new FormCart();
            ((FormMain)this.Parent).OpenChildForm(form);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FormSearch formSearch = new FormSearch(textBoxSearch.Text);
                ((FormMain)this.Parent).OpenChildForm(formSearch);
            }
        }

        private void buttonBills_Click(object sender, EventArgs e)
        {
            FormBills form = new FormBills();
            ((FormMain)this.Parent).OpenChildForm(form);
        }
    }
}
