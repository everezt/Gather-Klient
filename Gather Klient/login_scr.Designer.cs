namespace Gather_Klient
{
    partial class login_scr
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
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.version_label = new System.Windows.Forms.Label();
            this.remember_me = new System.Windows.Forms.CheckBox();
            this.login_btn = new Gather_Klient.custom_button();
            this.close_btn = new Gather_Klient.custom_button();
            this.info_btn = new Gather_Klient.custom_label();
            this.reg_btn = new Gather_Klient.custom_label();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.username_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_input.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.username_input.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username_input.Location = new System.Drawing.Point(158, 101);
            this.username_input.MaxLength = 20;
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(291, 33);
            this.username_input.TabIndex = 0;
            this.username_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_input_KeyDown);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_input.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.password_input.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.password_input.Location = new System.Drawing.Point(158, 170);
            this.password_input.MaxLength = 20;
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(291, 33);
            this.password_input.TabIndex = 1;
            this.password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_input_KeyDown);
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.Transparent;
            this.version_label.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version_label.Location = new System.Drawing.Point(189, 8);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(77, 15);
            this.version_label.TabIndex = 3;
            this.version_label.Text = "version_label";
            // 
            // remember_me
            // 
            this.remember_me.AutoSize = true;
            this.remember_me.BackColor = System.Drawing.Color.Transparent;
            this.remember_me.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember_me.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.remember_me.Location = new System.Drawing.Point(378, 217);
            this.remember_me.Name = "remember_me";
            this.remember_me.Size = new System.Drawing.Size(84, 19);
            this.remember_me.TabIndex = 2;
            this.remember_me.Text = "Pea meeles";
            this.remember_me.UseVisualStyleBackColor = false;
            this.remember_me.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remember_me_KeyDown);
            // 
            // login_btn
            // 
            this.login_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.login_btn_active;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Location = new System.Drawing.Point(152, 235);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(303, 43);
            this.login_btn.TabIndex = 3;
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseEnter += new System.EventHandler(this.login_btn_MouseEnter);
            this.login_btn.MouseLeave += new System.EventHandler(this.login_btn_MouseLeave);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.close_btn;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(551, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 24);
            this.close_btn.TabIndex = 6;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_btn_MouseClick);
            // 
            // info_btn
            // 
            this.info_btn.AutoSize = true;
            this.info_btn.BackColor = System.Drawing.Color.Transparent;
            this.info_btn.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.info_btn.Location = new System.Drawing.Point(400, 60);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(62, 28);
            this.info_btn.TabIndex = 5;
            this.info_btn.Text = "INFO";
            this.info_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.info_btn_MouseClick);
            // 
            // reg_btn
            // 
            this.reg_btn.AutoSize = true;
            this.reg_btn.BackColor = System.Drawing.Color.Transparent;
            this.reg_btn.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reg_btn.Location = new System.Drawing.Point(146, 60);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(138, 28);
            this.reg_btn.TabIndex = 4;
            this.reg_btn.Text = "REGISTREERI";
            this.reg_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reg_btn_MouseClick);
            // 
            // login_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.login_bg;
            this.ClientSize = new System.Drawing.Size(580, 380);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.remember_me);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_scr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.login_scr_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_scr_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_scr_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_scr_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private custom_button login_btn;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label version_label;
        private custom_label reg_btn;
        private custom_label info_btn;
        private custom_button close_btn;
        private System.Windows.Forms.CheckBox remember_me;
    }
}

