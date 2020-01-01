namespace EventManagement
{
    partial class ServiceProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceProvider));
            this.CenterDock = new System.Windows.Forms.Panel();
            this.stageDecorationDetails1 = new EventManagement.StageDecorationDetails();
            this.soundSysDetails1 = new EventManagement.SoundSysDetails();
            this.cateringDetails1 = new EventManagement.CateringDetails();
            this.veneuDetails1 = new EventManagement.VeneuDetails();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.venue2 = new EventManagement.Venue();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CenterDock.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterDock
            // 
            this.CenterDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.CenterDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CenterDock.Controls.Add(this.stageDecorationDetails1);
            this.CenterDock.Controls.Add(this.soundSysDetails1);
            this.CenterDock.Controls.Add(this.cateringDetails1);
            this.CenterDock.Controls.Add(this.veneuDetails1);
            this.CenterDock.Controls.Add(this.button7);
            this.CenterDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterDock.Location = new System.Drawing.Point(271, 0);
            this.CenterDock.Name = "CenterDock";
            this.CenterDock.Size = new System.Drawing.Size(573, 565);
            this.CenterDock.TabIndex = 13;
            // 
            // stageDecorationDetails1
            // 
            this.stageDecorationDetails1.BackColor = System.Drawing.Color.Transparent;
            this.stageDecorationDetails1.Location = new System.Drawing.Point(321, 305);
            this.stageDecorationDetails1.Name = "stageDecorationDetails1";
            this.stageDecorationDetails1.Size = new System.Drawing.Size(225, 145);
            this.stageDecorationDetails1.TabIndex = 6;
            // 
            // soundSysDetails1
            // 
            this.soundSysDetails1.BackColor = System.Drawing.Color.Transparent;
            this.soundSysDetails1.Location = new System.Drawing.Point(46, 260);
            this.soundSysDetails1.Name = "soundSysDetails1";
            this.soundSysDetails1.Size = new System.Drawing.Size(213, 159);
            this.soundSysDetails1.TabIndex = 5;
            // 
            // cateringDetails1
            // 
            this.cateringDetails1.BackColor = System.Drawing.Color.Transparent;
            this.cateringDetails1.Location = new System.Drawing.Point(46, 24);
            this.cateringDetails1.Name = "cateringDetails1";
            this.cateringDetails1.Size = new System.Drawing.Size(198, 168);
            this.cateringDetails1.TabIndex = 4;
            // 
            // veneuDetails1
            // 
            this.veneuDetails1.BackColor = System.Drawing.Color.Transparent;
            this.veneuDetails1.Location = new System.Drawing.Point(293, 24);
            this.veneuDetails1.Name = "veneuDetails1";
            this.veneuDetails1.Size = new System.Drawing.Size(184, 173);
            this.veneuDetails1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(667, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 41);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Transparent;
            this.panelSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSlide.BackgroundImage")));
            this.panelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSlide.Controls.Add(this.button5);
            this.panelSlide.Controls.Add(this.button4);
            this.panelSlide.Controls.Add(this.button3);
            this.panelSlide.Controls.Add(this.button2);
            this.panelSlide.Controls.Add(this.venue2);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.ForeColor = System.Drawing.Color.Transparent;
            this.panelSlide.Location = new System.Drawing.Point(52, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(219, 565);
            this.panelSlide.TabIndex = 12;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button5.Location = new System.Drawing.Point(19, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 65);
            this.button5.TabIndex = 38;
            this.button5.Text = "StageDecoration Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button4.Location = new System.Drawing.Point(19, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 65);
            this.button4.TabIndex = 37;
            this.button4.Text = "SoundSystem Details ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button3.Location = new System.Drawing.Point(19, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 65);
            this.button3.TabIndex = 36;
            this.button3.Text = "Venue Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(19, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 65);
            this.button2.TabIndex = 35;
            this.button2.Text = "Catering Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // venue2
            // 
            this.venue2.Location = new System.Drawing.Point(368, 198);
            this.venue2.Name = "venue2";
            this.venue2.Size = new System.Drawing.Size(346, 88);
            this.venue2.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.bunifuImageButton2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(52, 565);
            this.panelMenu.TabIndex = 11;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ImageActive")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(10, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 10;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServiceProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 565);
            this.Controls.Add(this.CenterDock);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceProvider";
            this.Text = "ServiceProvider";
            this.Load += new System.EventHandler(this.ServiceProvider_Load);
            this.CenterDock.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel CenterDock;
        private System.Windows.Forms.Timer timer1;
        private Venue venue2;
        private System.Windows.Forms.Panel panelSlide;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panelMenu;
        private StageDecorationDetails stageDecorationDetails1;
        private SoundSysDetails soundSysDetails1;
        private CateringDetails cateringDetails1;
        private VeneuDetails veneuDetails1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}