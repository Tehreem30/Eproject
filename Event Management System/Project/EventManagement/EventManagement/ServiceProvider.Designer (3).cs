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
            this.venue2 = new EventManagement.Venue();
            this.button8 = new System.Windows.Forms.Button();
            this.sdd = new System.Windows.Forms.Button();
            this.sd = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.Button();
            this.Vd = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.CenterDock.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterDock
            // 
            this.CenterDock.BackColor = System.Drawing.Color.IndianRed;
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
            this.stageDecorationDetails1.Location = new System.Drawing.Point(321, 305);
            this.stageDecorationDetails1.Name = "stageDecorationDetails1";
            this.stageDecorationDetails1.Size = new System.Drawing.Size(225, 145);
            this.stageDecorationDetails1.TabIndex = 6;
            // 
            // soundSysDetails1
            // 
            this.soundSysDetails1.Location = new System.Drawing.Point(46, 260);
            this.soundSysDetails1.Name = "soundSysDetails1";
            this.soundSysDetails1.Size = new System.Drawing.Size(213, 159);
            this.soundSysDetails1.TabIndex = 5;
            // 
            // cateringDetails1
            // 
            this.cateringDetails1.Location = new System.Drawing.Point(46, 24);
            this.cateringDetails1.Name = "cateringDetails1";
            this.cateringDetails1.Size = new System.Drawing.Size(198, 168);
            this.cateringDetails1.TabIndex = 4;
            // 
            // veneuDetails1
            // 
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
            this.panelSlide.BackColor = System.Drawing.Color.Maroon;
            this.panelSlide.Controls.Add(this.button1);
            this.panelSlide.Controls.Add(this.venue2);
            this.panelSlide.Controls.Add(this.button8);
            this.panelSlide.Controls.Add(this.sdd);
            this.panelSlide.Controls.Add(this.sd);
            this.panelSlide.Controls.Add(this.cd);
            this.panelSlide.Controls.Add(this.Vd);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.ForeColor = System.Drawing.Color.Transparent;
            this.panelSlide.Location = new System.Drawing.Point(52, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(219, 565);
            this.panelSlide.TabIndex = 12;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // venue2
            // 
            this.venue2.Location = new System.Drawing.Point(368, 198);
            this.venue2.Name = "venue2";
            this.venue2.Size = new System.Drawing.Size(346, 88);
            this.venue2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(19, 471);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 65);
            this.button8.TabIndex = 32;
            this.button8.Text = "Previous Event";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // sdd
            // 
            this.sdd.BackColor = System.Drawing.Color.LightCoral;
            this.sdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sdd.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdd.ForeColor = System.Drawing.Color.Black;
            this.sdd.Location = new System.Drawing.Point(19, 260);
            this.sdd.Name = "sdd";
            this.sdd.Size = new System.Drawing.Size(181, 81);
            this.sdd.TabIndex = 30;
            this.sdd.Text = "StageDecoration Details";
            this.sdd.UseVisualStyleBackColor = false;
            this.sdd.Click += new System.EventHandler(this.sdd_Click);
            // 
            // sd
            // 
            this.sd.BackColor = System.Drawing.Color.LightCoral;
            this.sd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sd.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.ForeColor = System.Drawing.Color.Black;
            this.sd.Location = new System.Drawing.Point(19, 182);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(181, 81);
            this.sd.TabIndex = 29;
            this.sd.Text = "SoundSystem Details ";
            this.sd.UseVisualStyleBackColor = false;
            this.sd.Click += new System.EventHandler(this.sd_Click);
            // 
            // cd
            // 
            this.cd.BackColor = System.Drawing.Color.LightCoral;
            this.cd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cd.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd.ForeColor = System.Drawing.Color.Black;
            this.cd.Location = new System.Drawing.Point(19, 24);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(181, 81);
            this.cd.TabIndex = 28;
            this.cd.Text = "Catering Details";
            this.cd.UseVisualStyleBackColor = false;
            this.cd.Click += new System.EventHandler(this.cd_Click);
            // 
            // Vd
            // 
            this.Vd.BackColor = System.Drawing.Color.LightCoral;
            this.Vd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vd.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vd.ForeColor = System.Drawing.Color.Black;
            this.Vd.Location = new System.Drawing.Point(19, 102);
            this.Vd.Name = "Vd";
            this.Vd.Size = new System.Drawing.Size(181, 81);
            this.Vd.TabIndex = 27;
            this.Vd.Text = "Venue Details";
            this.Vd.UseVisualStyleBackColor = false;
            this.Vd.Click += new System.EventHandler(this.Vd_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.bunifuImageButton5);
            this.panelMenu.Controls.Add(this.bunifuImageButton4);
            this.panelMenu.Controls.Add(this.bunifuImageButton3);
            this.panelMenu.Controls.Add(this.bunifuImageButton2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(52, 565);
            this.panelMenu.TabIndex = 11;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ImageActive")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(8, 416);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton5.TabIndex = 13;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 20;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ImageActive")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(8, 305);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 12;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 20;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(10, 193);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 11;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Maroon;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel CenterDock;
        private System.Windows.Forms.Timer timer1;
        private Venue venue2;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button sdd;
        private System.Windows.Forms.Button sd;
        private System.Windows.Forms.Button cd;
        private System.Windows.Forms.Button Vd;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panelMenu;
        private StageDecorationDetails stageDecorationDetails1;
        private SoundSysDetails soundSysDetails1;
        private CateringDetails cateringDetails1;
        private VeneuDetails veneuDetails1;
        private System.Windows.Forms.Button button1;
    }
}