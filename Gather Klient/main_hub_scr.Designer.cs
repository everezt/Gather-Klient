namespace Gather_Klient
{
    partial class main_hub_scr
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
            this.btn_panel = new System.Windows.Forms.Panel();
            this.minimize_btn = new Gather_Klient.custom_button();
            this.close_btn = new Gather_Klient.custom_button();
            this.prof_pic_main = new System.Windows.Forms.PictureBox();
            this.stats_btn = new Gather_Klient.custom_button();
            this.warmup_btn = new Gather_Klient.custom_button();
            this.play_btn = new Gather_Klient.custom_button();
            this.home_btn = new Gather_Klient.custom_button();
            this.username_label = new System.Windows.Forms.Label();
            this.screen_panel = new System.Windows.Forms.Panel();
            this.btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prof_pic_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_panel
            // 
            this.btn_panel.BackColor = System.Drawing.Color.Transparent;
            this.btn_panel.Controls.Add(this.minimize_btn);
            this.btn_panel.Controls.Add(this.close_btn);
            this.btn_panel.Controls.Add(this.prof_pic_main);
            this.btn_panel.Controls.Add(this.stats_btn);
            this.btn_panel.Controls.Add(this.warmup_btn);
            this.btn_panel.Controls.Add(this.play_btn);
            this.btn_panel.Controls.Add(this.home_btn);
            this.btn_panel.Controls.Add(this.username_label);
            this.btn_panel.Location = new System.Drawing.Point(154, 2);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(1173, 132);
            this.btn_panel.TabIndex = 0;
            this.btn_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_panel_MouseDown);
            this.btn_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_panel_MouseMove);
            this.btn_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_panel_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.minimize_btn;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Location = new System.Drawing.Point(1119, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(24, 24);
            this.minimize_btn.TabIndex = 8;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.custom_button1_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.close_btn;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(1146, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 24);
            this.close_btn.TabIndex = 7;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // prof_pic_main
            // 
            this.prof_pic_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prof_pic_main.Location = new System.Drawing.Point(1013, 12);
            this.prof_pic_main.Name = "prof_pic_main";
            this.prof_pic_main.Size = new System.Drawing.Size(100, 100);
            this.prof_pic_main.TabIndex = 4;
            this.prof_pic_main.TabStop = false;
            this.prof_pic_main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prof_pic_main_MouseClick);
            // 
            // stats_btn
            // 
            this.stats_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.stats_btn_inactive;
            this.stats_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.stats_btn.FlatAppearance.BorderSize = 0;
            this.stats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_btn.Location = new System.Drawing.Point(624, 0);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(208, 132);
            this.stats_btn.TabIndex = 3;
            this.stats_btn.UseVisualStyleBackColor = true;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            this.stats_btn.MouseEnter += new System.EventHandler(this.stats_btn_MouseEnter);
            this.stats_btn.MouseLeave += new System.EventHandler(this.stats_btn_MouseLeave);
            // 
            // warmup_btn
            // 
            this.warmup_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.warmup_btn_inactive;
            this.warmup_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.warmup_btn.FlatAppearance.BorderSize = 0;
            this.warmup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warmup_btn.Location = new System.Drawing.Point(416, 0);
            this.warmup_btn.Name = "warmup_btn";
            this.warmup_btn.Size = new System.Drawing.Size(208, 132);
            this.warmup_btn.TabIndex = 2;
            this.warmup_btn.UseVisualStyleBackColor = true;
            this.warmup_btn.Click += new System.EventHandler(this.warmup_btn_Click);
            this.warmup_btn.MouseEnter += new System.EventHandler(this.warmup_btn_MouseEnter);
            this.warmup_btn.MouseLeave += new System.EventHandler(this.warmup_btn_MouseLeave);
            // 
            // play_btn
            // 
            this.play_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.play_btn_inactive;
            this.play_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Location = new System.Drawing.Point(208, 0);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(208, 132);
            this.play_btn.TabIndex = 1;
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            this.play_btn.MouseEnter += new System.EventHandler(this.play_btn_MouseEnter);
            this.play_btn.MouseLeave += new System.EventHandler(this.play_btn_MouseLeave);
            // 
            // home_btn
            // 
            this.home_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.home_btn_active;
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Location = new System.Drawing.Point(0, 0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(208, 132);
            this.home_btn.TabIndex = 0;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            this.home_btn.MouseEnter += new System.EventHandler(this.home_btn_MouseEnter);
            this.home_btn.MouseLeave += new System.EventHandler(this.home_btn_MouseLeave);
            // 
            // username_label
            // 
            this.username_label.Font = new System.Drawing.Font("Open Sans Semibold", 20.75F, System.Drawing.FontStyle.Bold);
            this.username_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username_label.Location = new System.Drawing.Point(808, 46);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(199, 42);
            this.username_label.TabIndex = 9;
            this.username_label.Text = "usrname_lbl";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // screen_panel
            // 
            this.screen_panel.Location = new System.Drawing.Point(33, 164);
            this.screen_panel.Name = "screen_panel";
            this.screen_panel.Size = new System.Drawing.Size(1261, 679);
            this.screen_panel.TabIndex = 1;
            // 
            // main_hub_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.main_hub_bg;
            this.ClientSize = new System.Drawing.Size(1326, 869);
            this.Controls.Add(this.screen_panel);
            this.Controls.Add(this.btn_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_hub_scr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gather Klient";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_hub_scr_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_hub_scr_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_hub_scr_MouseUp);
            this.Resize += new System.EventHandler(this.main_hub_scr_Resize);
            this.btn_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prof_pic_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btn_panel;
        private custom_button stats_btn;
        private custom_button warmup_btn;
        private custom_button play_btn;
        private custom_button home_btn;
        private System.Windows.Forms.PictureBox prof_pic_main;
        private System.Windows.Forms.Panel screen_panel;
        private custom_button close_btn;
        private custom_button minimize_btn;
        private System.Windows.Forms.Label username_label;
    }
}