namespace minesweeper_v1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.meGlassButton4 = new minesweeper_v1.MeGlassButton();
            this.meGlassButton3 = new minesweeper_v1.MeGlassButton();
            this.meGlassButton2 = new minesweeper_v1.MeGlassButton();
            this.meGlassButton1 = new minesweeper_v1.MeGlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::minesweeper_v1.Properties.Resources.Screenshot__281_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // meGlassButton4
            // 
            this.meGlassButton4.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton4.FontAntiAlias = true;
            this.meGlassButton4.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton4.Location = new System.Drawing.Point(12, 359);
            this.meGlassButton4.Name = "meGlassButton4";
            this.meGlassButton4.RoundedCornerRadius = 6;
            this.meGlassButton4.Size = new System.Drawing.Size(69, 24);
            this.meGlassButton4.TabIndex = 8;
            this.meGlassButton4.Text = "HELP ?";
            this.meGlassButton4.UseVisualStyleBackColor = false;
            this.meGlassButton4.Click += new System.EventHandler(this.meGlassButton4_Click);
            this.meGlassButton4.MouseEnter += new System.EventHandler(this.meGlassButton4_MouseEnter);
            this.meGlassButton4.MouseLeave += new System.EventHandler(this.meGlassButton4_MouseLeave);
            // 
            // meGlassButton3
            // 
            this.meGlassButton3.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton3.FontAntiAlias = true;
            this.meGlassButton3.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton3.Location = new System.Drawing.Point(487, 259);
            this.meGlassButton3.Name = "meGlassButton3";
            this.meGlassButton3.RoundedCornerRadius = 6;
            this.meGlassButton3.Size = new System.Drawing.Size(100, 32);
            this.meGlassButton3.TabIndex = 7;
            this.meGlassButton3.Text = "EXIT";
            this.meGlassButton3.UseVisualStyleBackColor = false;
            this.meGlassButton3.Click += new System.EventHandler(this.meGlassButton3_Click);
            // 
            // meGlassButton2
            // 
            this.meGlassButton2.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton2.FontAntiAlias = true;
            this.meGlassButton2.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton2.Location = new System.Drawing.Point(487, 206);
            this.meGlassButton2.Name = "meGlassButton2";
            this.meGlassButton2.RoundedCornerRadius = 6;
            this.meGlassButton2.Size = new System.Drawing.Size(100, 32);
            this.meGlassButton2.TabIndex = 6;
            this.meGlassButton2.Text = "PLAYER";
            this.meGlassButton2.UseVisualStyleBackColor = false;
            this.meGlassButton2.Click += new System.EventHandler(this.meGlassButton2_Click);
            // 
            // meGlassButton1
            // 
            this.meGlassButton1.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton1.FontAntiAlias = true;
            this.meGlassButton1.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton1.Location = new System.Drawing.Point(487, 157);
            this.meGlassButton1.Name = "meGlassButton1";
            this.meGlassButton1.RoundedCornerRadius = 6;
            this.meGlassButton1.Size = new System.Drawing.Size(100, 29);
            this.meGlassButton1.TabIndex = 5;
            this.meGlassButton1.Text = "START";
            this.meGlassButton1.UseVisualStyleBackColor = false;
            this.meGlassButton1.Click += new System.EventHandler(this.meGlassButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 395);
            this.ControlBox = false;
            this.Controls.Add(this.meGlassButton4);
            this.Controls.Add(this.meGlassButton3);
            this.Controls.Add(this.meGlassButton2);
            this.Controls.Add(this.meGlassButton1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MeGlassButton meGlassButton1;
        private MeGlassButton meGlassButton2;
        private MeGlassButton meGlassButton3;
        private MeGlassButton meGlassButton4;
    }
}

