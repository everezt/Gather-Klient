namespace Gather_Klient
{
    partial class reg_scr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_scr));
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_repeat_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.steamid_input = new System.Windows.Forms.ComboBox();
            this.close_btn = new Gather_Klient.custom_button();
            this.reg_btn = new Gather_Klient.custom_button();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.username_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_input.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.username_input.Location = new System.Drawing.Point(160, 85);
            this.username_input.MaxLength = 20;
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(291, 33);
            this.username_input.TabIndex = 1;
            this.username_input.Text = "Kasutajanimi";
            this.username_input.Enter += new System.EventHandler(this.username_input_Enter);
            this.username_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_input_KeyDown);
            this.username_input.Leave += new System.EventHandler(this.username_input_Leave);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_input.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.password_input.Location = new System.Drawing.Point(160, 152);
            this.password_input.MaxLength = 20;
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(291, 33);
            this.password_input.TabIndex = 2;
            this.password_input.Text = "Parool";
            this.password_input.Enter += new System.EventHandler(this.password_input_Enter);
            this.password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_input_KeyDown);
            this.password_input.Leave += new System.EventHandler(this.password_input_Leave);
            // 
            // password_repeat_input
            // 
            this.password_repeat_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.password_repeat_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_repeat_input.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_repeat_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.password_repeat_input.Location = new System.Drawing.Point(160, 220);
            this.password_repeat_input.MaxLength = 20;
            this.password_repeat_input.Name = "password_repeat_input";
            this.password_repeat_input.Size = new System.Drawing.Size(291, 33);
            this.password_repeat_input.TabIndex = 3;
            this.password_repeat_input.Text = "Korda";
            this.password_repeat_input.Enter += new System.EventHandler(this.password_repeat_input_Enter);
            this.password_repeat_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_repeat_input_KeyDown);
            this.password_repeat_input.Leave += new System.EventHandler(this.password_repeat_input_Leave);
            // 
            // email_input
            // 
            this.email_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.email_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_input.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.email_input.Location = new System.Drawing.Point(160, 288);
            this.email_input.MaxLength = 40;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(291, 33);
            this.email_input.TabIndex = 4;
            this.email_input.Text = "Email";
            this.email_input.Enter += new System.EventHandler(this.email_input_Enter);
            this.email_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_input_KeyDown);
            this.email_input.Leave += new System.EventHandler(this.email_input_Leave);
            // 
            // steamid_input
            // 
            this.steamid_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.steamid_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steamid_input.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamid_input.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.steamid_input.FormattingEnabled = true;
            this.steamid_input.Location = new System.Drawing.Point(154, 351);
            this.steamid_input.Name = "steamid_input";
            this.steamid_input.Size = new System.Drawing.Size(303, 41);
            this.steamid_input.TabIndex = 5;
            this.steamid_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.steamid_input_KeyDown);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.close_btn;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(521, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 24);
            this.close_btn.TabIndex = 7;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.reg_btn_active;
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Location = new System.Drawing.Point(154, 420);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(303, 43);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            this.reg_btn.MouseEnter += new System.EventHandler(this.reg_btn_MouseEnter);
            this.reg_btn.MouseLeave += new System.EventHandler(this.reg_btn_MouseLeave);
            // 
            // reg_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 517);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.steamid_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.password_repeat_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reg_scr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registreeri";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reg_scr_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reg_scr_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reg_scr_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox password_repeat_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.ComboBox steamid_input;
        private custom_button reg_btn;
        private custom_button close_btn;
    }
}