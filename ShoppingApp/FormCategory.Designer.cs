namespace ShoppingApp
{
    partial class FormCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlCategories = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabBeef = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPasta = new System.Windows.Forms.TabPage();
            this.tabPork = new System.Windows.Forms.TabPage();
            this.tabSeafood = new System.Windows.Forms.TabPage();
            this.tabSide = new System.Windows.Forms.TabPage();
            this.tabStarter = new System.Windows.Forms.TabPage();
            this.tabVegan = new System.Windows.Forms.TabPage();
            this.tabVegetarian = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel1.Size = new System.Drawing.Size(733, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Maroon;
            this.guna2CircleButton1.BorderThickness = 1;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(30, 20);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(34, 33);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControlCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30);
            this.panel2.Size = new System.Drawing.Size(733, 578);
            this.panel2.TabIndex = 1;
            // 
            // tabControlCategories
            // 
            this.tabControlCategories.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlCategories.Controls.Add(this.tabBeef);
            this.tabControlCategories.Controls.Add(this.tabPage2);
            this.tabControlCategories.Controls.Add(this.tabPage3);
            this.tabControlCategories.Controls.Add(this.tabPage1);
            this.tabControlCategories.Controls.Add(this.tabPage4);
            this.tabControlCategories.Controls.Add(this.tabPasta);
            this.tabControlCategories.Controls.Add(this.tabPork);
            this.tabControlCategories.Controls.Add(this.tabSeafood);
            this.tabControlCategories.Controls.Add(this.tabSide);
            this.tabControlCategories.Controls.Add(this.tabStarter);
            this.tabControlCategories.Controls.Add(this.tabVegan);
            this.tabControlCategories.Controls.Add(this.tabVegetarian);
            this.tabControlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCategories.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControlCategories.Location = new System.Drawing.Point(30, 30);
            this.tabControlCategories.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCategories.Name = "tabControlCategories";
            this.tabControlCategories.SelectedIndex = 0;
            this.tabControlCategories.Size = new System.Drawing.Size(673, 518);
            this.tabControlCategories.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlCategories.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.tabControlCategories.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlCategories.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlCategories.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlCategories.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControlCategories.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabControlCategories.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlCategories.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabControlCategories.TabButtonIdleState.InnerColor = System.Drawing.Color.Gainsboro;
            this.tabControlCategories.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlCategories.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.Control;
            this.tabControlCategories.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlCategories.TabButtonSelectedState.ForeColor = System.Drawing.Color.Maroon;
            this.tabControlCategories.TabButtonSelectedState.InnerColor = System.Drawing.Color.DarkRed;
            this.tabControlCategories.TabButtonSize = new System.Drawing.Size(100, 40);
            this.tabControlCategories.TabIndex = 3;
            this.tabControlCategories.TabMenuBackColor = System.Drawing.SystemColors.Control;
            this.tabControlCategories.SelectedIndexChanged += new System.EventHandler(this.tabControlCategories_SelectedIndexChanged);
            // 
            // tabBeef
            // 
            this.tabBeef.AutoScroll = true;
            this.tabBeef.BackColor = System.Drawing.SystemColors.Control;
            this.tabBeef.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBeef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabBeef.Location = new System.Drawing.Point(104, 4);
            this.tabBeef.Margin = new System.Windows.Forms.Padding(4);
            this.tabBeef.Name = "tabBeef";
            this.tabBeef.Padding = new System.Windows.Forms.Padding(4);
            this.tabBeef.Size = new System.Drawing.Size(565, 510);
            this.tabBeef.TabIndex = 0;
            this.tabBeef.Text = "Beef";
            this.tabBeef.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(565, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chicken";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(565, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dessert";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(565, 510);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Lamb";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Location = new System.Drawing.Point(104, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(565, 510);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Miscellaneous";
            // 
            // tabPasta
            // 
            this.tabPasta.BackColor = System.Drawing.SystemColors.Control;
            this.tabPasta.Location = new System.Drawing.Point(104, 4);
            this.tabPasta.Name = "tabPasta";
            this.tabPasta.Size = new System.Drawing.Size(565, 510);
            this.tabPasta.TabIndex = 5;
            this.tabPasta.Text = "pasta";
            // 
            // tabPork
            // 
            this.tabPork.BackColor = System.Drawing.SystemColors.Control;
            this.tabPork.Location = new System.Drawing.Point(104, 4);
            this.tabPork.Name = "tabPork";
            this.tabPork.Size = new System.Drawing.Size(565, 510);
            this.tabPork.TabIndex = 6;
            this.tabPork.Text = "Pork";
            // 
            // tabSeafood
            // 
            this.tabSeafood.BackColor = System.Drawing.SystemColors.Control;
            this.tabSeafood.Location = new System.Drawing.Point(104, 4);
            this.tabSeafood.Name = "tabSeafood";
            this.tabSeafood.Size = new System.Drawing.Size(565, 510);
            this.tabSeafood.TabIndex = 7;
            this.tabSeafood.Text = "Seafood";
            // 
            // tabSide
            // 
            this.tabSide.BackColor = System.Drawing.SystemColors.Control;
            this.tabSide.Location = new System.Drawing.Point(104, 4);
            this.tabSide.Name = "tabSide";
            this.tabSide.Size = new System.Drawing.Size(565, 510);
            this.tabSide.TabIndex = 8;
            this.tabSide.Text = "Side";
            // 
            // tabStarter
            // 
            this.tabStarter.BackColor = System.Drawing.SystemColors.Control;
            this.tabStarter.Location = new System.Drawing.Point(104, 4);
            this.tabStarter.Name = "tabStarter";
            this.tabStarter.Size = new System.Drawing.Size(565, 510);
            this.tabStarter.TabIndex = 9;
            this.tabStarter.Text = "Starter";
            // 
            // tabVegan
            // 
            this.tabVegan.BackColor = System.Drawing.SystemColors.Control;
            this.tabVegan.Location = new System.Drawing.Point(104, 4);
            this.tabVegan.Name = "tabVegan";
            this.tabVegan.Size = new System.Drawing.Size(565, 510);
            this.tabVegan.TabIndex = 10;
            this.tabVegan.Text = "Vegan";
            // 
            // tabVegetarian
            // 
            this.tabVegetarian.BackColor = System.Drawing.SystemColors.Control;
            this.tabVegetarian.Location = new System.Drawing.Point(104, 4);
            this.tabVegetarian.Name = "tabVegetarian";
            this.tabVegetarian.Size = new System.Drawing.Size(565, 510);
            this.tabVegetarian.TabIndex = 11;
            this.tabVegetarian.Text = "Vegetarian";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControlCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TabControl tabControlCategories;
        private System.Windows.Forms.TabPage tabBeef;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPasta;
        private System.Windows.Forms.TabPage tabPork;
        private System.Windows.Forms.TabPage tabSeafood;
        private System.Windows.Forms.TabPage tabSide;
        private System.Windows.Forms.TabPage tabStarter;
        private System.Windows.Forms.TabPage tabVegan;
        private System.Windows.Forms.TabPage tabVegetarian;
    }
}