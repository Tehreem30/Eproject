namespace EventManagement
{
    partial class EventManagmentModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagmentModule));
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.venue2 = new EventManagement.Venue();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CenterDock = new System.Windows.Forms.Panel();
            this.previouosEvents1 = new EventManagement.previouosEvents();
            this.addS_D1 = new EventManagement.AddS_D();
            this.addsound1 = new EventManagement.Addsound();
            this.addcatering1 = new EventManagement.addcatering();
            this.addvenue1 = new EventManagement.Addvenue();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.CenterDock.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(52, 568);
            this.panelMenu.TabIndex = 8;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 129);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Transparent;
            this.panelSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSlide.BackgroundImage")));
            this.panelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSlide.Controls.Add(this.button1);
            this.panelSlide.Controls.Add(this.button5);
            this.panelSlide.Controls.Add(this.button4);
            this.panelSlide.Controls.Add(this.button3);
            this.panelSlide.Controls.Add(this.button2);
            this.panelSlide.Controls.Add(this.venue2);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.ForeColor = System.Drawing.Color.Transparent;
            this.panelSlide.Location = new System.Drawing.Point(52, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(219, 568);
            this.panelSlide.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(19, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 65);
            this.button1.TabIndex = 44;
            this.button1.Text = "Previous Event";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button5.Location = new System.Drawing.Point(19, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 42);
            this.button5.TabIndex = 39;
            this.button5.Text = "Add Stage";
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
            this.button4.Location = new System.Drawing.Point(19, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 42);
            this.button4.TabIndex = 38;
            this.button4.Text = "Add Sound";
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
            this.button3.Size = new System.Drawing.Size(181, 42);
            this.button3.TabIndex = 37;
            this.button3.Text = "Add Catering";
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
            this.button2.Location = new System.Drawing.Point(19, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 42);
            this.button2.TabIndex = 36;
            this.button2.Text = "Add Venue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // venue2
            // 
            this.venue2.Location = new System.Drawing.Point(368, 198);
            this.venue2.Name = "venue2";
            this.venue2.Size = new System.Drawing.Size(346, 88);
            this.venue2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CenterDock
            // 
            this.CenterDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.CenterDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CenterDock.Controls.Add(this.previouosEvents1);
            this.CenterDock.Controls.Add(this.addS_D1);
            this.CenterDock.Controls.Add(this.addsound1);
            this.CenterDock.Controls.Add(this.addcatering1);
            this.CenterDock.Controls.Add(this.addvenue1);
            this.CenterDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterDock.Location = new System.Drawing.Point(271, 0);
            this.CenterDock.Name = "CenterDock";
            this.CenterDock.Size = new System.Drawing.Size(714, 568);
            this.CenterDock.TabIndex = 10;
            this.CenterDock.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterDock_Paint);
            // 
            // previouosEvents1
            // 
            this.previouosEvents1.BackColor = System.Drawing.Color.Transparent;
            this.previouosEvents1.Location = new System.Drawing.Point(41, 348);
            this.previouosEvents1.Name = "previouosEvents1";
            this.previouosEvents1.Size = new System.Drawing.Size(191, 122);
            this.previouosEvents1.TabIndex = 8;
            // 
            // addS_D1
            // 
            this.addS_D1.BackColor = System.Drawing.Color.Transparent;
            this.addS_D1.Location = new System.Drawing.Point(255, 31);
            this.addS_D1.Name = "addS_D1";
            this.addS_D1.Size = new System.Drawing.Size(240, 90);
            this.addS_D1.TabIndex = 7;
            // 
            // addsound1
            // 
            this.addsound1.BackColor = System.Drawing.Color.Transparent;
            this.addsound1.Location = new System.Drawing.Point(324, 247);
            this.addsound1.Name = "addsound1";
            this.addsound1.Size = new System.Drawing.Size(171, 147);
            this.addsound1.TabIndex = 6;
            // 
            // addcatering1
            // 
            this.addcatering1.BackColor = System.Drawing.Color.Transparent;
            this.addcatering1.Location = new System.Drawing.Point(41, 193);
            this.addcatering1.Name = "addcatering1";
            this.addcatering1.Size = new System.Drawing.Size(164, 139);
            this.addcatering1.TabIndex = 4;
            // 
            // addvenue1
            // 
            this.addvenue1.BackColor = System.Drawing.Color.Transparent;
            this.addvenue1.Location = new System.Drawing.Point(27, 12);
            this.addvenue1.Name = "addvenue1";
            this.addvenue1.Size = new System.Drawing.Size(165, 132);
            this.addvenue1.TabIndex = 3;
            // 
            // EventManagmentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 568);
            this.Controls.Add(this.CenterDock);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventManagmentModule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Managment Module";
            this.Load += new System.EventHandler(this.EventManagmentModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.CenterDock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panelMenu;
        private Venue venue2;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel CenterDock;
        private Addsound addsound1;

        private addcatering addcatering1;
        private Addvenue addvenue1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private AddS_D addS_D1;
        private System.Windows.Forms.Button button1;
        private previouosEvents previouosEvents1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}