namespace Gather_Klient
{
    partial class play_scr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lobby_name = new System.Windows.Forms.Label();
            this.lobby_score = new System.Windows.Forms.Label();
            this.lobby_players = new System.Windows.Forms.Label();
            this.lobby_map = new System.Windows.Forms.Label();
            this.lobby_status = new System.Windows.Forms.Label();
            this.team_b_label = new System.Windows.Forms.Label();
            this.team_a_label = new System.Windows.Forms.Label();
            this.team_b_players = new System.Windows.Forms.Label();
            this.team_a_players = new System.Windows.Forms.Label();
            this.play_lobby_grid = new Gather_Klient.play_datagridview();
            this.server_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_avg_elo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_btn = new Gather_Klient.custom_button();
            this.join_btn = new Gather_Klient.custom_button();
            ((System.ComponentModel.ISupportInitialize)(this.play_lobby_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lobby_name
            // 
            this.lobby_name.BackColor = System.Drawing.Color.Transparent;
            this.lobby_name.Font = new System.Drawing.Font("Open Sans Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lobby_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(147)))), ((int)(((byte)(217)))));
            this.lobby_name.Location = new System.Drawing.Point(28, 45);
            this.lobby_name.Name = "lobby_name";
            this.lobby_name.Size = new System.Drawing.Size(301, 38);
            this.lobby_name.TabIndex = 9;
            this.lobby_name.Text = "CSGO.ee #1 ALL 0/10";
            this.lobby_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lobby_score
            // 
            this.lobby_score.BackColor = System.Drawing.Color.Transparent;
            this.lobby_score.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lobby_score.ForeColor = System.Drawing.Color.White;
            this.lobby_score.Location = new System.Drawing.Point(31, 174);
            this.lobby_score.Name = "lobby_score";
            this.lobby_score.Size = new System.Drawing.Size(290, 30);
            this.lobby_score.TabIndex = 24;
            this.lobby_score.Text = "0 - 0";
            this.lobby_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lobby_players
            // 
            this.lobby_players.BackColor = System.Drawing.Color.Transparent;
            this.lobby_players.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lobby_players.ForeColor = System.Drawing.Color.White;
            this.lobby_players.Location = new System.Drawing.Point(31, 114);
            this.lobby_players.Name = "lobby_players";
            this.lobby_players.Size = new System.Drawing.Size(290, 30);
            this.lobby_players.TabIndex = 23;
            this.lobby_players.Text = "0/10";
            this.lobby_players.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lobby_map
            // 
            this.lobby_map.BackColor = System.Drawing.Color.Transparent;
            this.lobby_map.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lobby_map.ForeColor = System.Drawing.Color.White;
            this.lobby_map.Location = new System.Drawing.Point(31, 144);
            this.lobby_map.Name = "lobby_map";
            this.lobby_map.Size = new System.Drawing.Size(294, 30);
            this.lobby_map.TabIndex = 21;
            this.lobby_map.Text = "Pole valitud";
            this.lobby_map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lobby_status
            // 
            this.lobby_status.BackColor = System.Drawing.Color.Transparent;
            this.lobby_status.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lobby_status.ForeColor = System.Drawing.Color.White;
            this.lobby_status.Location = new System.Drawing.Point(31, 84);
            this.lobby_status.Name = "lobby_status";
            this.lobby_status.Size = new System.Drawing.Size(290, 30);
            this.lobby_status.TabIndex = 22;
            this.lobby_status.Text = "Vaba";
            this.lobby_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team_b_label
            // 
            this.team_b_label.BackColor = System.Drawing.Color.Transparent;
            this.team_b_label.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.team_b_label.ForeColor = System.Drawing.Color.White;
            this.team_b_label.Location = new System.Drawing.Point(723, 50);
            this.team_b_label.Name = "team_b_label";
            this.team_b_label.Size = new System.Drawing.Size(174, 31);
            this.team_b_label.TabIndex = 26;
            this.team_b_label.Text = "Tiim B";
            this.team_b_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.team_b_label.Visible = false;
            // 
            // team_a_label
            // 
            this.team_a_label.BackColor = System.Drawing.Color.Transparent;
            this.team_a_label.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.team_a_label.ForeColor = System.Drawing.Color.White;
            this.team_a_label.Location = new System.Drawing.Point(428, 50);
            this.team_a_label.Name = "team_a_label";
            this.team_a_label.Size = new System.Drawing.Size(174, 31);
            this.team_a_label.TabIndex = 25;
            this.team_a_label.Text = "Tiim A";
            this.team_a_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.team_a_label.Visible = false;
            // 
            // team_b_players
            // 
            this.team_b_players.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.team_b_players.BackColor = System.Drawing.Color.Transparent;
            this.team_b_players.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_b_players.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team_b_players.Location = new System.Drawing.Point(680, 96);
            this.team_b_players.Name = "team_b_players";
            this.team_b_players.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.team_b_players.Size = new System.Drawing.Size(168, 137);
            this.team_b_players.TabIndex = 28;
            this.team_b_players.Text = "everest\r\nmarilyn\r\neverest\r\nmarilyn\r\neverest";
            this.team_b_players.Visible = false;
            // 
            // team_a_players
            // 
            this.team_a_players.BackColor = System.Drawing.Color.Transparent;
            this.team_a_players.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_a_players.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.team_a_players.Location = new System.Drawing.Point(476, 96);
            this.team_a_players.Name = "team_a_players";
            this.team_a_players.Size = new System.Drawing.Size(168, 137);
            this.team_a_players.TabIndex = 27;
            this.team_a_players.Text = "everest\r\nmarilyn\r\neverest\r\nmarilyn\r\neverest";
            this.team_a_players.Visible = false;
            // 
            // play_lobby_grid
            // 
            this.play_lobby_grid.AllowUserToAddRows = false;
            this.play_lobby_grid.AllowUserToDeleteRows = false;
            this.play_lobby_grid.AllowUserToResizeColumns = false;
            this.play_lobby_grid.AllowUserToResizeRows = false;
            this.play_lobby_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.play_lobby_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.play_lobby_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.play_lobby_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.play_lobby_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.play_lobby_grid.ColumnHeadersVisible = false;
            this.play_lobby_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.server_name,
            this.server_status,
            this.server_map,
            this.server_players,
            this.server_score,
            this.server_avg_elo,
            this.server_id});
            this.play_lobby_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.play_lobby_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.play_lobby_grid.EnableHeadersVisualStyles = false;
            this.play_lobby_grid.Location = new System.Drawing.Point(0, 347);
            this.play_lobby_grid.MultiSelect = false;
            this.play_lobby_grid.Name = "play_lobby_grid";
            this.play_lobby_grid.ReadOnly = true;
            this.play_lobby_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.play_lobby_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.play_lobby_grid.RowHeadersVisible = false;
            this.play_lobby_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.play_lobby_grid.Size = new System.Drawing.Size(1261, 374);
            this.play_lobby_grid.TabIndex = 4;
            this.play_lobby_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.play_lobby_grid_CellClick);
            // 
            // server_name
            // 
            this.server_name.HeaderText = "Server name";
            this.server_name.Name = "server_name";
            this.server_name.ReadOnly = true;
            this.server_name.Width = 232;
            // 
            // server_status
            // 
            this.server_status.HeaderText = "Server status";
            this.server_status.Name = "server_status";
            this.server_status.ReadOnly = true;
            this.server_status.Width = 196;
            // 
            // server_map
            // 
            this.server_map.HeaderText = "Server map";
            this.server_map.Name = "server_map";
            this.server_map.ReadOnly = true;
            this.server_map.Width = 233;
            // 
            // server_players
            // 
            this.server_players.HeaderText = "Server players";
            this.server_players.Name = "server_players";
            this.server_players.ReadOnly = true;
            this.server_players.Width = 232;
            // 
            // server_score
            // 
            this.server_score.HeaderText = "server_score";
            this.server_score.Name = "server_score";
            this.server_score.ReadOnly = true;
            this.server_score.Width = 183;
            // 
            // server_avg_elo
            // 
            this.server_avg_elo.HeaderText = "Server avg elo";
            this.server_avg_elo.Name = "server_avg_elo";
            this.server_avg_elo.ReadOnly = true;
            this.server_avg_elo.Width = 181;
            // 
            // server_id
            // 
            this.server_id.HeaderText = "Server id";
            this.server_id.Name = "server_id";
            this.server_id.ReadOnly = true;
            this.server_id.Visible = false;
            // 
            // leave_btn
            // 
            this.leave_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.leave_btn_inactive;
            this.leave_btn.Enabled = false;
            this.leave_btn.FlatAppearance.BorderSize = 0;
            this.leave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leave_btn.Location = new System.Drawing.Point(997, 146);
            this.leave_btn.Name = "leave_btn";
            this.leave_btn.Size = new System.Drawing.Size(220, 87);
            this.leave_btn.TabIndex = 1;
            this.leave_btn.UseVisualStyleBackColor = true;
            this.leave_btn.Click += new System.EventHandler(this.leave_btn_Click);
            this.leave_btn.MouseEnter += new System.EventHandler(this.leave_btn_MouseEnter);
            this.leave_btn.MouseLeave += new System.EventHandler(this.leave_btn_MouseLeave);
            // 
            // join_btn
            // 
            this.join_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.join_btn_active;
            this.join_btn.FlatAppearance.BorderSize = 0;
            this.join_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_btn.Location = new System.Drawing.Point(997, 27);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(220, 87);
            this.join_btn.TabIndex = 0;
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            this.join_btn.MouseEnter += new System.EventHandler(this.join_btn_MouseEnter);
            this.join_btn.MouseLeave += new System.EventHandler(this.join_btn_MouseLeave);
            // 
            // play_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.play_scr_bg;
            this.ClientSize = new System.Drawing.Size(1261, 679);
            this.Controls.Add(this.team_b_players);
            this.Controls.Add(this.team_a_players);
            this.Controls.Add(this.team_b_label);
            this.Controls.Add(this.team_a_label);
            this.Controls.Add(this.lobby_score);
            this.Controls.Add(this.lobby_players);
            this.Controls.Add(this.lobby_map);
            this.Controls.Add(this.lobby_status);
            this.Controls.Add(this.lobby_name);
            this.Controls.Add(this.play_lobby_grid);
            this.Controls.Add(this.leave_btn);
            this.Controls.Add(this.join_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "play_scr";
            this.Text = "play_scr";
            ((System.ComponentModel.ISupportInitialize)(this.play_lobby_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private custom_button join_btn;
        private custom_button leave_btn;
        private play_datagridview play_lobby_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_map;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_players;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_avg_elo;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_id;
        private System.Windows.Forms.Label lobby_name;
        private System.Windows.Forms.Label lobby_score;
        private System.Windows.Forms.Label lobby_players;
        private System.Windows.Forms.Label lobby_map;
        private System.Windows.Forms.Label lobby_status;
        private System.Windows.Forms.Label team_b_label;
        private System.Windows.Forms.Label team_a_label;
        private System.Windows.Forms.Label team_b_players;
        private System.Windows.Forms.Label team_a_players;
    }
}