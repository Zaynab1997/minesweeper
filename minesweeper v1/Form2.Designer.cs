namespace minesweeper_v1
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.meGlassButton1 = new minesweeper_v1.MeGlassButton();
            this.meGlassButton2 = new minesweeper_v1.MeGlassButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 53);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 164);
            this.listBox1.TabIndex = 1;
            // 
            // meGlassButton1
            // 
            this.meGlassButton1.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.meGlassButton1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton1.FontAntiAlias = true;
            this.meGlassButton1.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton1.Location = new System.Drawing.Point(272, 83);
            this.meGlassButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.meGlassButton1.Name = "meGlassButton1";
            this.meGlassButton1.RoundedCornerRadius = 6;
            this.meGlassButton1.Size = new System.Drawing.Size(100, 37);
            this.meGlassButton1.TabIndex = 3;
            this.meGlassButton1.Text = "CREATE";
            this.meGlassButton1.UseVisualStyleBackColor = false;
            this.meGlassButton1.Click += new System.EventHandler(this.meGlassButton1_Click);
            // 
            // meGlassButton2
            // 
            this.meGlassButton2.BackColor = System.Drawing.Color.Gold;
            this.meGlassButton2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meGlassButton2.FontAntiAlias = true;
            this.meGlassButton2.ForeColor = System.Drawing.Color.Black;
            this.meGlassButton2.Location = new System.Drawing.Point(272, 156);
            this.meGlassButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.meGlassButton2.Name = "meGlassButton2";
            this.meGlassButton2.RoundedCornerRadius = 6;
            this.meGlassButton2.Size = new System.Drawing.Size(100, 34);
            this.meGlassButton2.TabIndex = 4;
            this.meGlassButton2.Text = "DONE";
            this.meGlassButton2.UseVisualStyleBackColor = false;
            this.meGlassButton2.Click += new System.EventHandler(this.meGlassButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minesweeper_v1.Properties.Resources.Black_and_Yellow_Abstract_High_Resolution_Wallpaper13;
            this.ClientSize = new System.Drawing.Size(416, 248);
            this.Controls.Add(this.meGlassButton2);
            this.Controls.Add(this.meGlassButton1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "SIGN IN";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private MeGlassButton meGlassButton1;
        private MeGlassButton meGlassButton2;
    }
}