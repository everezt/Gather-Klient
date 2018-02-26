namespace Gather_Klient
{
    partial class update_prof_pic_scr
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
            this.close_btn = new Gather_Klient.custom_button();
            this.url_input = new System.Windows.Forms.TextBox();
            this.update_btn = new Gather_Klient.custom_button();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.close_btn;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(322, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(24, 24);
            this.close_btn.TabIndex = 8;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // url_input
            // 
            this.url_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.url_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_input.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.url_input.Location = new System.Drawing.Point(41, 58);
            this.url_input.Name = "url_input";
            this.url_input.Size = new System.Drawing.Size(271, 22);
            this.url_input.TabIndex = 9;
            this.url_input.Text = "URL";
            this.url_input.Enter += new System.EventHandler(this.url_input_Enter);
            this.url_input.Leave += new System.EventHandler(this.url_input_Leave);
            // 
            // update_btn
            // 
            this.update_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.update_btn_active;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Location = new System.Drawing.Point(102, 122);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(151, 43);
            this.update_btn.TabIndex = 10;
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // update_prof_pic_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.update_prof_spic_scr_bg;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.url_input);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update_prof_pic_scr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uuenda profiili pilti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private custom_button close_btn;
        private System.Windows.Forms.TextBox url_input;
        private custom_button update_btn;
    }
}