namespace DataBaseProject
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomerSettings = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnLineUp = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbllogoname3 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnclosesubform = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize2 = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.btnCustomerSettings);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnRating);
            this.panelMenu.Controls.Add(this.btnLineUp);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(652, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 482);
            this.panelMenu.TabIndex = 0;
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
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "خروج";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomerSettings
            // 
            this.btnCustomerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerSettings.FlatAppearance.BorderSize = 0;
            this.btnCustomerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomerSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSettings.Image")));
            this.btnCustomerSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerSettings.Location = new System.Drawing.Point(0, 306);
            this.btnCustomerSettings.Name = "btnCustomerSettings";
            this.btnCustomerSettings.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnCustomerSettings.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerSettings.TabIndex = 21;
            this.btnCustomerSettings.Text = "تنظیمات";
            this.btnCustomerSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomerSettings.UseVisualStyleBackColor = true;
            this.btnCustomerSettings.Click += new System.EventHandler(this.btnCustomerSettings_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStats.Image = ((System.Drawing.Image)(resources.GetObject("btnStats.Image")));
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnStats.Location = new System.Drawing.Point(0, 246);
            this.btnStats.Name = "btnStats";
            this.btnStats.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnStats.Size = new System.Drawing.Size(200, 60);
            this.btnStats.TabIndex = 20;
            this.btnStats.Text = "آمار و ارقام";
            this.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnRating
            // 
            this.btnRating.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRating.Image = ((System.Drawing.Image)(resources.GetObject("btnRating.Image")));
            this.btnRating.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRating.Location = new System.Drawing.Point(0, 186);
            this.btnRating.Name = "btnRating";
            this.btnRating.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnRating.Size = new System.Drawing.Size(200, 60);
            this.btnRating.TabIndex = 19;
            this.btnRating.Text = "امتیاز دهی";
            this.btnRating.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnLineUp
            // 
            this.btnLineUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLineUp.FlatAppearance.BorderSize = 0;
            this.btnLineUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLineUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLineUp.Image")));
            this.btnLineUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLineUp.Location = new System.Drawing.Point(0, 126);
            this.btnLineUp.Name = "btnLineUp";
            this.btnLineUp.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnLineUp.Size = new System.Drawing.Size(200, 60);
            this.btnLineUp.TabIndex = 18;
            this.btnLineUp.Text = "نمایش ترکیب";
            this.btnLineUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLineUp.UseVisualStyleBackColor = true;
            this.btnLineUp.Click += new System.EventHandler(this.btnLineUp_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::DataBaseProject.Properties.Resources.shopping_cart__1_;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.Location = new System.Drawing.Point(0, 66);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 60);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = " فروشگاه";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbllogoname3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 66);
            this.panelLogo.TabIndex = 0;
            // 
            // lbllogoname3
            // 
            this.lbllogoname3.AutoSize = true;
            this.lbllogoname3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogoname3.ForeColor = System.Drawing.Color.LightGray;
            this.lbllogoname3.Location = new System.Drawing.Point(42, 23);
            this.lbllogoname3.Name = "lbllogoname3";
            this.lbllogoname3.Size = new System.Drawing.Size(102, 21);
            this.lbllogoname3.TabIndex = 1;
            this.lbllogoname3.Text = "Football Club";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnclosesubform);
            this.panelTitleBar.Controls.Add(this.btnClose2);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(652, 66);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // btnclosesubform
            // 
            this.btnclosesubform.FlatAppearance.BorderSize = 0;
            this.btnclosesubform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosesubform.Image = global::DataBaseProject.Properties.Resources.cross_out__2_;
            this.btnclosesubform.Location = new System.Drawing.Point(614, 10);
            this.btnclosesubform.Name = "btnclosesubform";
            this.btnclosesubform.Size = new System.Drawing.Size(49, 48);
            this.btnclosesubform.TabIndex = 7;
            this.btnclosesubform.UseVisualStyleBackColor = true;
            this.btnclosesubform.Click += new System.EventHandler(this.btnclosesubform_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.FlatAppearance.BorderSize = 0;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose2.ForeColor = System.Drawing.Color.White;
            this.btnClose2.Location = new System.Drawing.Point(0, 0);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(30, 31);
            this.btnClose2.TabIndex = 6;
            this.btnClose2.Text = "X";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(293, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "صفحه اصلی";
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(25, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 31);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize2
            // 
            this.btnMinimize2.FlatAppearance.BorderSize = 0;
            this.btnMinimize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize2.ForeColor = System.Drawing.Color.White;
            this.btnMinimize2.Location = new System.Drawing.Point(51, 0);
            this.btnMinimize2.Name = "btnMinimize2";
            this.btnMinimize2.Size = new System.Drawing.Size(30, 31);
            this.btnMinimize2.TabIndex = 4;
            this.btnMinimize2.Text = "-";
            this.btnMinimize2.UseVisualStyleBackColor = true;
            this.btnMinimize2.Click += new System.EventHandler(this.btnMinimize2_Click_1);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 66);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(652, 416);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 482);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
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
        private Panel panelLogo;
        private Button btnProducts;
        private Button btnCustomerSettings;
        private Button btnStats;
        private Button btnRating;
        private Button btnLineUp;
        private Panel panelTitleBar;
        private Panel panelDesktopPanel;
        private Label lbllogoname3;
        private Button btnClose2;
        private Label lblTitle;
        private Button btnMaximize;
        private Button btnMinimize2;
        private Button btnclosesubform;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}