namespace minesweeper_v1
{
    partial class Form0
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.meGlassButton1 = new minesweeper_v1.MeGlassButton();
            this.meGlassButton2 = new minesweeper_v1.MeGlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "General help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::minesweeper_v1.Properties.Resources.acsdasc1;
            this.pictureBox1.Location = new System.Drawing.Point(40, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // meGlassButton1
            // 
            this.meGlassButton1.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton1.FontAntiAlias = true;
            this.meGlassButton1.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton1.Location = new System.Drawing.Point(360, 362);
            this.meGlassButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meGlassButton1.Name = "meGlassButton1";
            this.meGlassButton1.RoundedCornerRadius = 6;
            this.meGlassButton1.Size = new System.Drawing.Size(133, 39);
            this.meGlassButton1.TabIndex = 4;
            this.meGlassButton1.Text = "Next";
            this.meGlassButton1.UseVisualStyleBackColor = false;
            this.meGlassButton1.Click += new System.EventHandler(this.meGlassButton1_Click);
            // 
            // meGlassButton2
            // 
            this.meGlassButton2.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton2.FontAntiAlias = true;
            this.meGlassButton2.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton2.Location = new System.Drawing.Point(501, 362);
            this.meGlassButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meGlassButton2.Name = "meGlassButton2";
            this.meGlassButton2.RoundedCornerRadius = 6;
            this.meGlassButton2.Size = new System.Drawing.Size(133, 39);
            this.meGlassButton2.TabIndex = 5;
            this.meGlassButton2.Text = "Finish";
            this.meGlassButton2.UseVisualStyleBackColor = false;
            this.meGlassButton2.Visible = false;
            this.meGlassButton2.Click += new System.EventHandler(this.meGlassButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(61, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Created by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(11, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cirine Dandashli - Lama Mouhamad - Zaynab Mawas";
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minesweeper_v1.Properties.Resources.Black_and_Yellow_Abstract_High_Resolution_Wallpaper13;
            this.ClientSize = new System.Drawing.Size(651, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meGlassButton2);
            this.Controls.Add(this.meGlassButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form0";
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form0_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MeGlassButton meGlassButton1;
        private MeGlassButton meGlassButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}