namespace WindowsApplication1
{
    partial class Menue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ruls = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsApplication1.Properties.Resources.cooltext473292510;
            this.pictureBox1.Location = new System.Drawing.Point(223, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(335, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.ImageKey = "(none)";
            this.Exit.Location = new System.Drawing.Point(335, 304);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 34);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ruls
            // 
            this.ruls.BackColor = System.Drawing.Color.Transparent;
            this.ruls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ruls.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ruls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ruls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ruls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruls.ForeColor = System.Drawing.Color.White;
            this.ruls.ImageKey = "(none)";
            this.ruls.Location = new System.Drawing.Point(335, 238);
            this.ruls.Name = "ruls";
            this.ruls.Size = new System.Drawing.Size(116, 34);
            this.ruls.TabIndex = 1;
            this.ruls.Text = "Ruls";
            this.ruls.UseVisualStyleBackColor = false;
            this.ruls.Click += new System.EventHandler(this.ruls_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.gaming_poker_cards;
            this.pictureBox2.Location = new System.Drawing.Point(572, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 189);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsApplication1.Properties.Resources.Ibex_Wallpaper_by_willwill100;
            this.ClientSize = new System.Drawing.Size(781, 505);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ruls);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(789, 539);
            this.MinimumSize = new System.Drawing.Size(789, 539);
            this.Name = "Menue";
            this.Text = "Menue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ruls;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

