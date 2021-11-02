namespace ShoppingApp
{
    partial class FormCancelMessage
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
            this.labelMess = new System.Windows.Forms.Label();
            this.textBoxReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.No = new Guna.UI2.WinForms.Guna2Button();
            this.buttonYes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMess
            // 
            this.labelMess.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMess.Location = new System.Drawing.Point(30, 30);
            this.labelMess.Name = "labelMess";
            this.labelMess.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelMess.Size = new System.Drawing.Size(383, 66);
            this.labelMess.TabIndex = 0;
            this.labelMess.Text = "Please enter the reason for canceling the order";
            this.labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReason
            // 
            this.textBoxReason.BackColor = System.Drawing.Color.Transparent;
            this.textBoxReason.BorderRadius = 15;
            this.textBoxReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReason.DefaultText = "";
            this.textBoxReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReason.DisabledState.Parent = this.textBoxReason;
            this.textBoxReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReason.FocusedState.Parent = this.textBoxReason;
            this.textBoxReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReason.HoverState.Parent = this.textBoxReason;
            this.textBoxReason.Location = new System.Drawing.Point(30, 96);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.PasswordChar = '\0';
            this.textBoxReason.PlaceholderText = "because...";
            this.textBoxReason.SelectedText = "";
            this.textBoxReason.ShadowDecoration.BorderRadius = 15;
            this.textBoxReason.ShadowDecoration.Depth = 10;
            this.textBoxReason.ShadowDecoration.Enabled = true;
            this.textBoxReason.ShadowDecoration.Parent = this.textBoxReason;
            this.textBoxReason.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.textBoxReason.Size = new System.Drawing.Size(383, 36);
            this.textBoxReason.TabIndex = 1;
            this.textBoxReason.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.buttonYes);
            this.guna2Panel1.Controls.Add(this.No);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(30, 191);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(70, 5, 70, 5);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(383, 52);
            this.guna2Panel1.TabIndex = 3;
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.BorderColor = System.Drawing.Color.DarkGray;
            this.No.BorderRadius = 20;
            this.No.BorderThickness = 1;
            this.No.CheckedState.Parent = this.No;
            this.No.CustomImages.Parent = this.No;
            this.No.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.No.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.No.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.No.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.No.DisabledState.Parent = this.No;
            this.No.Dock = System.Windows.Forms.DockStyle.Left;
            this.No.FillColor = System.Drawing.Color.White;
            this.No.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.No.ForeColor = System.Drawing.Color.Black;
            this.No.HoverState.Parent = this.No;
            this.No.Location = new System.Drawing.Point(70, 5);
            this.No.Name = "No";
            this.No.ShadowDecoration.BorderRadius = 20;
            this.No.ShadowDecoration.Enabled = true;
            this.No.ShadowDecoration.Parent = this.No;
            this.No.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.No.Size = new System.Drawing.Size(96, 42);
            this.No.TabIndex = 0;
            this.No.Text = "No";
            this.No.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonYes.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonYes.BorderRadius = 20;
            this.buttonYes.BorderThickness = 1;
            this.buttonYes.CheckedState.Parent = this.buttonYes;
            this.buttonYes.CustomImages.Parent = this.buttonYes;
            this.buttonYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonYes.DisabledState.Parent = this.buttonYes;
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonYes.Enabled = false;
            this.buttonYes.FillColor = System.Drawing.Color.White;
            this.buttonYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonYes.ForeColor = System.Drawing.Color.Black;
            this.buttonYes.HoverState.Parent = this.buttonYes;
            this.buttonYes.Location = new System.Drawing.Point(217, 5);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.ShadowDecoration.BorderRadius = 20;
            this.buttonYes.ShadowDecoration.Enabled = true;
            this.buttonYes.ShadowDecoration.Parent = this.buttonYes;
            this.buttonYes.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.buttonYes.Size = new System.Drawing.Size(96, 42);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FormCancelMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 273);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.labelMess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCancelMessage";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "FormCancelMessage";
            this.Load += new System.EventHandler(this.FormCancelMessage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMess;
        private Guna.UI2.WinForms.Guna2TextBox textBoxReason;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonYes;
        private Guna.UI2.WinForms.Guna2Button No;
    }
}