namespace Gather_Klient
{
    partial class warmup_scr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.warmup_servers_grid = new Gather_Klient.warmup_datagridview();
            this.server_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sever_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copy_ip_btn = new Gather_Klient.custom_button();
            this.join_btn = new Gather_Klient.custom_button();
            this.current_server_name_label = new System.Windows.Forms.Label();
            this.players_in_current_server_label = new System.Windows.Forms.Label();
            this.current_server_map_label = new System.Windows.Forms.Label();
            this.current_server_location_label = new System.Windows.Forms.Label();
            this.map_pool_label = new System.Windows.Forms.Label();
            this.current_server_map_pool_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warmup_servers_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // warmup_servers_grid
            // 
            this.warmup_servers_grid.AllowUserToAddRows = false;
            this.warmup_servers_grid.AllowUserToDeleteRows = false;
            this.warmup_servers_grid.AllowUserToResizeColumns = false;
            this.warmup_servers_grid.AllowUserToResizeRows = false;
            this.warmup_servers_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.warmup_servers_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warmup_servers_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warmup_servers_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.warmup_servers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warmup_servers_grid.ColumnHeadersVisible = false;
            this.warmup_servers_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.server_name,
            this.server_map,
            this.server_players,
            this.server_ip,
            this.sever_id});
            this.warmup_servers_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.warmup_servers_grid.DefaultCellStyle = dataGridViewCellStyle7;
            this.warmup_servers_grid.EnableHeadersVisualStyles = false;
            this.warmup_servers_grid.Location = new System.Drawing.Point(1, 307);
            this.warmup_servers_grid.MultiSelect = false;
            this.warmup_servers_grid.Name = "warmup_servers_grid";
            this.warmup_servers_grid.ReadOnly = true;
            this.warmup_servers_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warmup_servers_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.warmup_servers_grid.RowHeadersVisible = false;
            this.warmup_servers_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.warmup_servers_grid.Size = new System.Drawing.Size(1260, 374);
            this.warmup_servers_grid.TabIndex = 3;
            this.warmup_servers_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warmup_servers_grid_CellClick);
            // 
            // server_name
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.server_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.server_name.HeaderText = "Server name";
            this.server_name.Name = "server_name";
            this.server_name.ReadOnly = true;
            this.server_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.server_name.Width = 322;
            // 
            // server_map
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            this.server_map.DefaultCellStyle = dataGridViewCellStyle3;
            this.server_map.HeaderText = "Server map";
            this.server_map.Name = "server_map";
            this.server_map.ReadOnly = true;
            this.server_map.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.server_map.Width = 278;
            // 
            // server_players
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            this.server_players.DefaultCellStyle = dataGridViewCellStyle4;
            this.server_players.HeaderText = "Server players";
            this.server_players.Name = "server_players";
            this.server_players.ReadOnly = true;
            this.server_players.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.server_players.Width = 330;
            // 
            // server_ip
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            this.server_ip.DefaultCellStyle = dataGridViewCellStyle5;
            this.server_ip.HeaderText = "Server ip";
            this.server_ip.Name = "server_ip";
            this.server_ip.ReadOnly = true;
            this.server_ip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.server_ip.Width = 325;
            // 
            // sever_id
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            this.sever_id.DefaultCellStyle = dataGridViewCellStyle6;
            this.sever_id.HeaderText = "server id";
            this.sever_id.Name = "sever_id";
            this.sever_id.ReadOnly = true;
            this.sever_id.Visible = false;
            // 
            // copy_ip_btn
            // 
            this.copy_ip_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.copy_ip_btn_active;
            this.copy_ip_btn.FlatAppearance.BorderSize = 0;
            this.copy_ip_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_ip_btn.Location = new System.Drawing.Point(968, 87);
            this.copy_ip_btn.Name = "copy_ip_btn";
            this.copy_ip_btn.Size = new System.Drawing.Size(246, 87);
            this.copy_ip_btn.TabIndex = 2;
            this.copy_ip_btn.UseVisualStyleBackColor = true;
            this.copy_ip_btn.Click += new System.EventHandler(this.copy_ip_btn_Click);
            this.copy_ip_btn.MouseEnter += new System.EventHandler(this.copy_ip_btn_MouseEnter);
            this.copy_ip_btn.MouseLeave += new System.EventHandler(this.copy_ip_btn_MouseLeave);
            // 
            // join_btn
            // 
            this.join_btn.BackgroundImage = global::Gather_Klient.Properties.Resources.join_btn_active;
            this.join_btn.FlatAppearance.BorderSize = 0;
            this.join_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_btn.Location = new System.Drawing.Point(646, 87);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(220, 87);
            this.join_btn.TabIndex = 1;
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            this.join_btn.MouseEnter += new System.EventHandler(this.join_btn_MouseEnter);
            this.join_btn.MouseLeave += new System.EventHandler(this.join_btn_MouseLeave);
            // 
            // current_server_name_label
            // 
            this.current_server_name_label.BackColor = System.Drawing.Color.Transparent;
            this.current_server_name_label.Font = new System.Drawing.Font("Open Sans Semibold", 20.75F, System.Drawing.FontStyle.Bold);
            this.current_server_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(147)))), ((int)(((byte)(217)))));
            this.current_server_name_label.Location = new System.Drawing.Point(0, 27);
            this.current_server_name_label.Name = "current_server_name_label";
            this.current_server_name_label.Size = new System.Drawing.Size(350, 39);
            this.current_server_name_label.TabIndex = 4;
            this.current_server_name_label.Text = "server_name";
            this.current_server_name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // players_in_current_server_label
            // 
            this.players_in_current_server_label.BackColor = System.Drawing.Color.Transparent;
            this.players_in_current_server_label.Font = new System.Drawing.Font("Open Sans Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.players_in_current_server_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.players_in_current_server_label.Location = new System.Drawing.Point(0, 66);
            this.players_in_current_server_label.Name = "players_in_current_server_label";
            this.players_in_current_server_label.Size = new System.Drawing.Size(350, 39);
            this.players_in_current_server_label.TabIndex = 5;
            this.players_in_current_server_label.Text = "players_in_server";
            this.players_in_current_server_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current_server_map_label
            // 
            this.current_server_map_label.BackColor = System.Drawing.Color.Transparent;
            this.current_server_map_label.Font = new System.Drawing.Font("Open Sans Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.current_server_map_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.current_server_map_label.Location = new System.Drawing.Point(2, 105);
            this.current_server_map_label.Name = "current_server_map_label";
            this.current_server_map_label.Size = new System.Drawing.Size(350, 39);
            this.current_server_map_label.TabIndex = 6;
            this.current_server_map_label.Text = "current_map";
            this.current_server_map_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current_server_location_label
            // 
            this.current_server_location_label.BackColor = System.Drawing.Color.Transparent;
            this.current_server_location_label.Font = new System.Drawing.Font("Open Sans Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.current_server_location_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.current_server_location_label.Location = new System.Drawing.Point(2, 144);
            this.current_server_location_label.Name = "current_server_location_label";
            this.current_server_location_label.Size = new System.Drawing.Size(350, 39);
            this.current_server_location_label.TabIndex = 7;
            this.current_server_location_label.Text = "Tallinn, Eesti";
            this.current_server_location_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // map_pool_label
            // 
            this.map_pool_label.BackColor = System.Drawing.Color.Transparent;
            this.map_pool_label.Font = new System.Drawing.Font("Open Sans Semibold", 20.75F, System.Drawing.FontStyle.Bold);
            this.map_pool_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(147)))), ((int)(((byte)(217)))));
            this.map_pool_label.Location = new System.Drawing.Point(356, 27);
            this.map_pool_label.Name = "map_pool_label";
            this.map_pool_label.Size = new System.Drawing.Size(193, 39);
            this.map_pool_label.TabIndex = 8;
            this.map_pool_label.Text = "MAP POOL";
            this.map_pool_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current_server_map_pool_label
            // 
            this.current_server_map_pool_label.BackColor = System.Drawing.Color.Transparent;
            this.current_server_map_pool_label.Font = new System.Drawing.Font("Open Sans Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.current_server_map_pool_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.current_server_map_pool_label.Location = new System.Drawing.Point(358, 66);
            this.current_server_map_pool_label.Name = "current_server_map_pool_label";
            this.current_server_map_pool_label.Size = new System.Drawing.Size(191, 151);
            this.current_server_map_pool_label.TabIndex = 9;
            this.current_server_map_pool_label.Text = "aim_map\r\naim_warmup\r\naim_redline\r\naim_usp";
            this.current_server_map_pool_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // warmup_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gather_Klient.Properties.Resources.warmup_scr_bg;
            this.ClientSize = new System.Drawing.Size(1261, 679);
            this.Controls.Add(this.current_server_map_pool_label);
            this.Controls.Add(this.map_pool_label);
            this.Controls.Add(this.current_server_location_label);
            this.Controls.Add(this.current_server_map_label);
            this.Controls.Add(this.players_in_current_server_label);
            this.Controls.Add(this.current_server_name_label);
            this.Controls.Add(this.warmup_servers_grid);
            this.Controls.Add(this.copy_ip_btn);
            this.Controls.Add(this.join_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "warmup_scr";
            this.Text = "warmup_scr";
            this.Load += new System.EventHandler(this.warmup_scr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warmup_servers_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private custom_button join_btn;
        private custom_button copy_ip_btn;
        private warmup_datagridview warmup_servers_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_map;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_players;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sever_id;
        private System.Windows.Forms.Label current_server_name_label;
        private System.Windows.Forms.Label players_in_current_server_label;
        private System.Windows.Forms.Label current_server_map_label;
        private System.Windows.Forms.Label current_server_location_label;
        private System.Windows.Forms.Label map_pool_label;
        private System.Windows.Forms.Label current_server_map_pool_label;
    }
}