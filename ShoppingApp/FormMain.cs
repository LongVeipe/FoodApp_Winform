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
    public partial class FormMain : Form
    {
        private Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
            OpenChildForm(new FormHome());
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                this.currentChildForm.Close();
                this.currentChildForm.Dispose();
            }

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.Parent = this;
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
