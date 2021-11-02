namespace ShoppingApp
{
    partial class UserControlCartItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCartItem));
            this.shadowPanel80 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxThumb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            this.shadowPanel80.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // shadowPanel80
            // 
            this.shadowPanel80.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel80.Controls.Add(this.labelName);
            this.shadowPanel80.Controls.Add(this.pictureBoxThumb);
            this.shadowPanel80.Dock = System.Windows.Forms.DockStyle.Left;
            this.shadowPanel80.FillColor = System.Drawing.Color.White;
            this.shadowPanel80.Location = new System.Drawing.Point(30, 5);
            this.shadowPanel80.Margin = new System.Windows.Forms.Padding(4);
            this.shadowPanel80.Name = "shadowPanel80";
            this.shadowPanel80.Padding = new System.Windows.Forms.Padding(2);
            this.shadowPanel80.Radius = 5;
            this.shadowPanel80.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel80.ShadowShift = 2;
            this.shadowPanel80.Size = new System.Drawing.Size(159, 177);
            this.shadowPanel80.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(2, 138);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(10);
            this.labelName.Size = new System.Drawing.Size(155, 37);
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
            this.pictureBoxThumb.Size = new System.Drawing.Size(155, 136);
            this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumb.TabIndex = 0;
            this.pictureBoxThumb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelUnitPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(249, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.panel1.Size = new System.Drawing.Size(438, 177);
            this.panel1.TabIndex = 6;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.Location = new System.Drawing.Point(19, 50);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(167, 77);
            this.labelUnitPrice.TabIndex = 13;
            this.labelUnitPrice.Text = "label1";
            this.labelUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 77);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(221, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panel2.Size = new System.Drawing.Size(81, 77);
            this.panel2.TabIndex = 11;
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownNumber.BorderRadius = 10;
            this.numericUpDownNumber.BorderThickness = 0;
            this.numericUpDownNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownNumber.CustomizableEdges.BottomLeft = false;
            this.numericUpDownNumber.CustomizableEdges.TopLeft = false;
            this.numericUpDownNumber.CustomizableEdges.TopRight = false;
            this.numericUpDownNumber.DisabledState.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownNumber.FillColor = System.Drawing.SystemColors.Control;
            this.numericUpDownNumber.FocusedState.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownNumber.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownNumber.Location = new System.Drawing.Point(0, 20);
            this.numericUpDownNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.ShadowDecoration.Parent = this.numericUpDownNumber;
            this.numericUpDownNumber.Size = new System.Drawing.Size(81, 37);
            this.numericUpDownNumber.TabIndex = 12;
            this.numericUpDownNumber.TextOffset = new System.Drawing.Point(10, 0);
            this.numericUpDownNumber.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged_1);
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(302, 50);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(136, 77);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "label1";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControlCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shadowPanel80);
            this.Name = "UserControlCartItem";
            this.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.Size = new System.Drawing.Size(717, 187);
            this.Load += new System.EventHandler(this.UserControlCartItem_Load);
            this.shadowPanel80.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel80;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxThumb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label label1;
    }
}
