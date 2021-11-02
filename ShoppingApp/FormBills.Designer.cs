namespace ShoppingApp
{
    partial class FormBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBills));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabControlCategories = new Guna.UI2.WinForms.Guna2TabControl();
            this.pending = new System.Windows.Forms.TabPage();
            this.Delivering = new System.Windows.Forms.TabPage();
            this.Canceled = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabControlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel1.Size = new System.Drawing.Size(717, 73);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(354, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bills";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBack
            // 
            this.buttonBack.BorderColor = System.Drawing.Color.White;
            this.buttonBack.BorderThickness = 1;
            this.buttonBack.CheckedState.Parent = this.buttonBack;
            this.buttonBack.CustomImages.Parent = this.buttonBack;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.DisabledState.Parent = this.buttonBack;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FillColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.HoverState.Parent = this.buttonBack;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(30, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonBack.ShadowDecoration.Parent = this.buttonBack;
            this.buttonBack.Size = new System.Drawing.Size(34, 33);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tabControlCategories);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(717, 539);
            this.guna2Panel1.TabIndex = 4;
            // 
            // tabControlCategories
            // 
            this.tabControlCategories.Controls.Add(this.pending);
            this.tabControlCategories.Controls.Add(this.Delivering);
            this.tabControlCategories.Controls.Add(this.Canceled);
            this.tabControlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCategories.ItemSize = new System.Drawing.Size(217, 40);
            this.tabControlCategories.Location = new System.Drawing.Point(30, 10);
            this.tabControlCategories.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCategories.Name = "tabControlCategories";
            this.tabControlCategories.SelectedIndex = 0;
            this.tabControlCategories.Size = new System.Drawing.Size(657, 519);
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
            this.tabControlCategories.TabButtonSize = new System.Drawing.Size(217, 40);
            this.tabControlCategories.TabIndex = 4;
            this.tabControlCategories.TabMenuBackColor = System.Drawing.SystemColors.Control;
            this.tabControlCategories.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabControlCategories.SelectedIndexChanged += new System.EventHandler(this.tabControlCategories_SelectedIndexChanged);
            // 
            // pending
            // 
            this.pending.AutoScroll = true;
            this.pending.BackColor = System.Drawing.SystemColors.Control;
            this.pending.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pending.Location = new System.Drawing.Point(4, 44);
            this.pending.Margin = new System.Windows.Forms.Padding(4);
            this.pending.Name = "pending";
            this.pending.Padding = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.pending.Size = new System.Drawing.Size(649, 471);
            this.pending.TabIndex = 0;
            this.pending.Text = "Pending";
            // 
            // Delivering
            // 
            this.Delivering.BackColor = System.Drawing.SystemColors.Control;
            this.Delivering.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivering.Location = new System.Drawing.Point(4, 44);
            this.Delivering.Margin = new System.Windows.Forms.Padding(4);
            this.Delivering.Name = "Delivering";
            this.Delivering.Padding = new System.Windows.Forms.Padding(4);
            this.Delivering.Size = new System.Drawing.Size(649, 471);
            this.Delivering.TabIndex = 1;
            this.Delivering.Text = "Delivering";
            // 
            // Canceled
            // 
            this.Canceled.BackColor = System.Drawing.SystemColors.Control;
            this.Canceled.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canceled.Location = new System.Drawing.Point(4, 44);
            this.Canceled.Margin = new System.Windows.Forms.Padding(4);
            this.Canceled.Name = "Canceled";
            this.Canceled.Size = new System.Drawing.Size(649, 471);
            this.Canceled.TabIndex = 2;
            this.Canceled.Text = "Canceled";
            // 
            // FormBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 612);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBills";
            this.Text = "FormBills";
            this.Load += new System.EventHandler(this.FormBills_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tabControlCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonBack;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TabControl tabControlCategories;
        private System.Windows.Forms.TabPage pending;
        private System.Windows.Forms.TabPage Delivering;
        private System.Windows.Forms.TabPage Canceled;
    }
}