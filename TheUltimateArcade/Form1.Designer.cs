namespace WindowsFormsApplication1
{
    partial class theUltimateArcade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theUltimateArcade));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snakeLabel = new System.Windows.Forms.Label();
            this.pongLabel = new System.Windows.Forms.Label();
            this.pacLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.pacman;
            this.pictureBox3.Location = new System.Drawing.Point(505, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Pong_Screen;
            this.pictureBox2.Location = new System.Drawing.Point(296, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(89, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // snakeLabel
            // 
            this.snakeLabel.AutoSize = true;
            this.snakeLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.snakeLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeLabel.ForeColor = System.Drawing.Color.Red;
            this.snakeLabel.Location = new System.Drawing.Point(131, 249);
            this.snakeLabel.Name = "snakeLabel";
            this.snakeLabel.Size = new System.Drawing.Size(91, 22);
            this.snakeLabel.TabIndex = 7;
            this.snakeLabel.Text = "S N A K E";
            // 
            // pongLabel
            // 
            this.pongLabel.AutoSize = true;
            this.pongLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pongLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pongLabel.ForeColor = System.Drawing.Color.Red;
            this.pongLabel.Location = new System.Drawing.Point(350, 249);
            this.pongLabel.Name = "pongLabel";
            this.pongLabel.Size = new System.Drawing.Size(74, 22);
            this.pongLabel.TabIndex = 8;
            this.pongLabel.Text = "P O N G";
            // 
            // pacLabel
            // 
            this.pacLabel.AutoSize = true;
            this.pacLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pacLabel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacLabel.ForeColor = System.Drawing.Color.Red;
            this.pacLabel.Location = new System.Drawing.Point(533, 249);
            this.pacLabel.Name = "pacLabel";
            this.pacLabel.Size = new System.Drawing.Size(120, 22);
            this.pacLabel.TabIndex = 9;
            this.pacLabel.Text = "P A C - M A N";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Location = new System.Drawing.Point(202, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(354, 25);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "PRESS A BUTTON BELOW TO START ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // theUltimateArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.plastic_texture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 484);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pacLabel);
            this.Controls.Add(this.pongLabel);
            this.Controls.Add(this.snakeLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "theUltimateArcade";
            this.Text = "The Ultimate Arcade";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.theUltimateArcade_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label snakeLabel;
        private System.Windows.Forms.Label pongLabel;
        private System.Windows.Forms.Label pacLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

