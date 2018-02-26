namespace Gather_Klient
{
    partial class home_scr
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
            this.users_online = new System.Windows.Forms.Label();
            this.online_users_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // users_online
            // 
            this.users_online.AutoSize = true;
            this.users_online.BackColor = System.Drawing.Color.Transparent;
            this.users_online.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.users_online.ForeColor = System.Drawing.Color.White;
            this.users_online.Location = new System.Drawing.Point(128, 1);
            this.users_online.Name = "users_online";
            this.users_online.Size = new System.Drawing.Size(44, 37);
            this.users_online.TabIndex = 3;
            this.users_online.Text = "(-)";
            // 
            // online_users_list
            // 
            this.online_users_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.online_users_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.online_users_list.Font = new System.Drawing.Font("Open Sans", 12F);
            this.online_users_list.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.online_users_list.FormattingEnabled = true;
            this.online_users_list.ItemHeight = 22;
            this.online_users_list.Location = new System.Drawing.Point(3, 52);
            this.online_users_list.Name = "online_users_list";
            this.online_users_list.Size = new System.Drawing.Size(210, 616);
            this.online_users_list.TabIndex = 21;
            // 
            // home_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.home_scr_bg;
            this.ClientSize = new System.Drawing.Size(1261, 679);
            this.Controls.Add(this.online_users_list);
            this.Controls.Add(this.users_online);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_scr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home_scr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label users_online;
        private System.Windows.Forms.ListBox online_users_list;
    }
}