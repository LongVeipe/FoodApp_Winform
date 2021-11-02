namespace ShoppingApp
{
    partial class UserControlMeal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMeal));
            this.shadowPanel80 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPrice = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDownNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxThumb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.shadowPanel80.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // shadowPanel80
            // 
            this.shadowPanel80.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel80.Controls.Add(this.panel2);
            this.shadowPanel80.Controls.Add(this.panel1);
            this.shadowPanel80.Controls.Add(this.labelName);
            this.shadowPanel80.Controls.Add(this.pictureBoxThumb);
            this.shadowPanel80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel80.FillColor = System.Drawing.Color.White;
            this.shadowPanel80.Location = new System.Drawing.Point(10, 10);
            this.shadowPanel80.Margin = new System.Windows.Forms.Padding(4);
            this.shadowPanel80.Name = "shadowPanel80";
            this.shadowPanel80.Padding = new System.Windows.Forms.Padding(2);
            this.shadowPanel80.Radius = 5;
            this.shadowPanel80.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel80.ShadowShift = 2;
            this.shadowPanel80.Size = new System.Drawing.Size(238, 325);
            this.shadowPanel80.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPrice);
            this.panel2.Controls.Add(this.numericUpDownNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 49);
            this.panel2.TabIndex = 3;
            // 
            // buttonPrice
            // 
            this.buttonPrice.BorderRadius = 10;
            this.buttonPrice.CheckedState.Parent = this.buttonPrice;
            this.buttonPrice.CustomImages.Parent = this.buttonPrice;
            this.buttonPrice.CustomizableEdges.BottomRight = false;
            this.buttonPrice.CustomizableEdges.TopLeft = false;
            this.buttonPrice.CustomizableEdges.TopRight = false;
            this.buttonPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrice.DisabledState.Parent = this.buttonPrice;
            this.buttonPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrice.FillColor = System.Drawing.Color.White;
            this.buttonPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrice.HoverState.Parent = this.buttonPrice;
            this.buttonPrice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrice.Image")));
            this.buttonPrice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonPrice.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonPrice.Location = new System.Drawing.Point(0, 0);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonPrice.ShadowDecoration.Parent = this.buttonPrice;
            this.buttonPrice.Size = new System.Drawing.Size(164, 49);
            this.buttonPrice.TabIndex = 6;
            this.buttonPrice.Text = "guna2Button1";
            this.buttonPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownNumber.BorderColor = System.Drawing.Color.Transparent;
            this.numericUpDownNumber.BorderRadius = 10;
            this.numericUpDownNumber.BorderThickness = 0;
            this.numericUpDownNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownNumber.CustomizableEdges.BottomLeft = false;
            this.numericUpDownNumber.CustomizableEdges.TopLeft = false;
            this.numericUpDownNumber.CustomizableEdges.TopRight = false;
            this.numericUpDownNumber.DisabledState.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.numericUpDownNumber.FocusedState.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownNumber.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDownNumber.Location = new System.Drawing.Point(164, 0);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.ShadowDecoration.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Size = new System.Drawing.Size(70, 49);
            this.numericUpDownNumber.TabIndex = 5;
            this.numericUpDownNumber.UpDownButtonFillColor = System.Drawing.Color.White;
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 1);
            this.panel1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(2, 222);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(10);
            this.labelName.Size = new System.Drawing.Size(234, 51);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Beef and Mustard Pie";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxThumb
            // 
            this.pictureBoxThumb.BorderRadius = 10;
            this.pictureBoxThumb.CustomizableEdges.BottomLeft = false;
            this.pictureBoxThumb.CustomizableEdges.BottomRight = false;
            this.pictureBoxThumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxThumb.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThumb.Image")));
            this.pictureBoxThumb.ImageRotate = 0F;
            this.pictureBoxThumb.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxThumb.Name = "pictureBoxThumb";
            this.pictureBoxThumb.ShadowDecoration.Parent = this.pictureBoxThumb;
            this.pictureBoxThumb.Size = new System.Drawing.Size(234, 220);
            this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumb.TabIndex = 0;
            this.pictureBoxThumb.TabStop = false;
            // 
            // UserControlMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.shadowPanel80);
            this.Name = "UserControlMeal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(258, 345);
            this.Load += new System.EventHandler(this.UserControlMeal_Load);
            this.shadowPanel80.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel80;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxThumb;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button buttonPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownNumber;
    }
}
