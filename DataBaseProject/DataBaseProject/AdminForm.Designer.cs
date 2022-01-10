namespace DataBaseProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFinancial = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbllogoname3 = new System.Windows.Forms.Label();
            this.btnclosesubform = new System.Windows.Forms.Button();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.btnMaximize3 = new System.Windows.Forms.Button();
            this.btnMinimize3 = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnFinancial);
            this.panelMenu.Controls.Add(this.btnPlayers);
            this.panelMenu.Controls.Add(this.btnGames);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.btnWorkers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(724, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 499);
            this.panelMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(170, 60);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "خروج";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFinancial
            // 
            this.btnFinancial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinancial.FlatAppearance.BorderSize = 0;
            this.btnFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancial.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancial.Image")));
            this.btnFinancial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinancial.Location = new System.Drawing.Point(0, 306);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnFinancial.Size = new System.Drawing.Size(170, 60);
            this.btnFinancial.TabIndex = 21;
            this.btnFinancial.Text = "اطلاعات مالی";
            this.btnFinancial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFinancial.UseVisualStyleBackColor = true;
            this.btnFinancial.Click += new System.EventHandler(this.btnFinancial_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayers.FlatAppearance.BorderSize = 0;
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayers.Image")));
            this.btnPlayers.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPlayers.Location = new System.Drawing.Point(0, 246);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnPlayers.Size = new System.Drawing.Size(170, 60);
            this.btnPlayers.TabIndex = 20;
            this.btnPlayers.Text = "آمار بازیکنان";
            this.btnPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnGames
            // 
            this.btnGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGames.Image = ((System.Drawing.Image)(resources.GetObject("btnGames.Image")));
            this.btnGames.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGames.Location = new System.Drawing.Point(0, 186);
            this.btnGames.Name = "btnGames";
            this.btnGames.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnGames.Size = new System.Drawing.Size(170, 60);
            this.btnGames.TabIndex = 19;
            this.btnGames.Text = "مسابقات";
            this.btnGames.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnShop
            // 
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShop.Location = new System.Drawing.Point(0, 126);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnShop.Size = new System.Drawing.Size(170, 60);
            this.btnShop.TabIndex = 18;
            this.btnShop.Text = "فروشگاه";
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWorkers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWorkers.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkers.Image")));
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkers.Location = new System.Drawing.Point(0, 66);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnWorkers.Size = new System.Drawing.Size(170, 60);
            this.btnWorkers.TabIndex = 6;
            this.btnWorkers.Text = "کارمندان";
            this.btnWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbllogoname3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 66);
            this.panelLogo.TabIndex = 0;
            // 
            // lbllogoname3
            // 
            this.lbllogoname3.AutoSize = true;
            this.lbllogoname3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogoname3.ForeColor = System.Drawing.Color.LightGray;
            this.lbllogoname3.Location = new System.Drawing.Point(36, 25);
            this.lbllogoname3.Name = "lbllogoname3";
            this.lbllogoname3.Size = new System.Drawing.Size(102, 21);
            this.lbllogoname3.TabIndex = 27;
            this.lbllogoname3.Text = "Football Club";
            // 
            // btnclosesubform
            // 
            this.btnclosesubform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclosesubform.FlatAppearance.BorderSize = 0;
            this.btnclosesubform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosesubform.Image = global::DataBaseProject.Properties.Resources.cross_out__2_;
            this.btnclosesubform.Location = new System.Drawing.Point(675, 3);
            this.btnclosesubform.Name = "btnclosesubform";
            this.btnclosesubform.Size = new System.Drawing.Size(49, 48);
            this.btnclosesubform.TabIndex = 23;
            this.btnclosesubform.UseVisualStyleBackColor = true;
            this.btnclosesubform.Click += new System.EventHandler(this.btnclosesubform_Click_1);
            // 
            // btnClose3
            // 
            this.btnClose3.FlatAppearance.BorderSize = 0;
            this.btnClose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose3.ForeColor = System.Drawing.Color.White;
            this.btnClose3.Location = new System.Drawing.Point(-1, 0);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(30, 31);
            this.btnClose3.TabIndex = 26;
            this.btnClose3.Text = "X";
            this.btnClose3.UseVisualStyleBackColor = true;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3_Click);
            // 
            // btnMaximize3
            // 
            this.btnMaximize3.FlatAppearance.BorderSize = 0;
            this.btnMaximize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize3.ForeColor = System.Drawing.Color.White;
            this.btnMaximize3.Location = new System.Drawing.Point(24, 0);
            this.btnMaximize3.Name = "btnMaximize3";
            this.btnMaximize3.Size = new System.Drawing.Size(30, 31);
            this.btnMaximize3.TabIndex = 25;
            this.btnMaximize3.Text = "O";
            this.btnMaximize3.UseVisualStyleBackColor = true;
            this.btnMaximize3.Click += new System.EventHandler(this.btnMaximize3_Click);
            // 
            // btnMinimize3
            // 
            this.btnMinimize3.FlatAppearance.BorderSize = 0;
            this.btnMinimize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize3.ForeColor = System.Drawing.Color.White;
            this.btnMinimize3.Location = new System.Drawing.Point(50, 0);
            this.btnMinimize3.Name = "btnMinimize3";
            this.btnMinimize3.Size = new System.Drawing.Size(30, 31);
            this.btnMinimize3.TabIndex = 24;
            this.btnMinimize3.Text = "-";
            this.btnMinimize3.UseVisualStyleBackColor = true;
            this.btnMinimize3.Click += new System.EventHandler(this.btnMinimize3_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnclosesubform);
            this.panelTitleBar.Controls.Add(this.btnClose3);
            this.panelTitleBar.Controls.Add(this.btnMaximize3);
            this.panelTitleBar.Controls.Add(this.btnMinimize3);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(724, 66);
            this.panelTitleBar.TabIndex = 27;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(302, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "صفحه اصلی";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 66);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(724, 433);
            this.panelDesktopPanel.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 499);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnFinancial;
        private Button btnPlayers;
        private Button btnGames;
        private Button btnShop;
        private Button btnWorkers;
        private Panel panelLogo;
        private Button btnclosesubform;
        private Button btnClose3;
        private Button btnMaximize3;
        private Button btnMinimize3;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Label lbllogoname3;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}