namespace Gather_Klient
{
    partial class custom_messagebox
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
            this.msg_text = new System.Windows.Forms.Label();
            this.ok_btn = new Gather_Klient.custom_button();
            this.SuspendLayout();
            // 
            // msg_text
            // 
            this.msg_text.BackColor = System.Drawing.Color.Transparent;
            this.msg_text.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg_text.Location = new System.Drawing.Point(1, 23);
            this.msg_text.Name = "msg_text";
            this.msg_text.Size = new System.Drawing.Size(348, 95);
            this.msg_text.TabIndex = 0;
            this.msg_text.Text = "Main server on maas!";
            this.msg_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_btn
            // 
            this.ok_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.ok_btn_active;
            this.ok_btn.FlatAppearance.BorderSize = 0;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Location = new System.Drawing.Point(100, 126);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(151, 43);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ok_btn_MouseClick);
            this.ok_btn.MouseEnter += new System.EventHandler(this.ok_btn_MouseEnter);
            this.ok_btn.MouseLeave += new System.EventHandler(this.ok_btn_MouseLeave);
            // 
            // custom_messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.randomerror_ina;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.msg_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "custom_messagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label msg_text;
        private custom_button ok_btn;
    }
}