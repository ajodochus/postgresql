namespace UserControl_postgreSql
{
    partial class Uc_postgreSql
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_postgreSql = new System.Windows.Forms.Label();
            this.btn_start_service = new System.Windows.Forms.Button();
            this.mydatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_user_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cbx_sql_string = new System.Windows.Forms.ComboBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_postgreSql
            // 
            this.lbl_postgreSql.AutoSize = true;
            this.lbl_postgreSql.Location = new System.Drawing.Point(3, 0);
            this.lbl_postgreSql.Name = "lbl_postgreSql";
            this.lbl_postgreSql.Size = new System.Drawing.Size(57, 13);
            this.lbl_postgreSql.TabIndex = 0;
            this.lbl_postgreSql.Text = "postgreSql";
            // 
            // btn_start_service
            // 
            this.btn_start_service.BackColor = System.Drawing.Color.Red;
            this.btn_start_service.Location = new System.Drawing.Point(34, 75);
            this.btn_start_service.Name = "btn_start_service";
            this.btn_start_service.Size = new System.Drawing.Size(134, 23);
            this.btn_start_service.TabIndex = 2;
            this.btn_start_service.Text = "start sql service";
            this.btn_start_service.UseVisualStyleBackColor = false;
            this.btn_start_service.Click += new System.EventHandler(this.start_sqlServer_Click);
            // 
            // mydatagrid
            // 
            this.mydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydatagrid.Location = new System.Drawing.Point(34, 131);
            this.mydatagrid.Name = "mydatagrid";
            this.mydatagrid.Size = new System.Drawing.Size(427, 181);
            this.mydatagrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(531, 163);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(100, 20);
            this.tb_database.TabIndex = 9;
            this.tb_database.Text = "postgres";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(531, 199);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 10;
            this.tb_port.Text = "5439";
            // 
            // tb_user_id
            // 
            this.tb_user_id.Location = new System.Drawing.Point(531, 235);
            this.tb_user_id.Name = "tb_user_id";
            this.tb_user_id.Size = new System.Drawing.Size(100, 20);
            this.tb_user_id.TabIndex = 11;
            this.tb_user_id.Text = "postgres";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(531, 271);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 12;
            // 
            // cbx_sql_string
            // 
            this.cbx_sql_string.FormattingEnabled = true;
            this.cbx_sql_string.Items.AddRange(new object[] {
            "SELECT \"ID\" FROM \"mytable\" WHERE \"NAME\" = \'Meier\';",
            "SELECT * FROM \"mytable\""});
            this.cbx_sql_string.Location = new System.Drawing.Point(34, 104);
            this.cbx_sql_string.Name = "cbx_sql_string";
            this.cbx_sql_string.Size = new System.Drawing.Size(427, 21);
            this.cbx_sql_string.TabIndex = 14;
            this.cbx_sql_string.Text = "-- select --";
            this.cbx_sql_string.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(531, 127);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(100, 20);
            this.tb_server.TabIndex = 15;
            this.tb_server.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Server";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(467, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 208);
            this.panel1.TabIndex = 17;
            // 
            // Uc_postgreSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.cbx_sql_string);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user_id);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mydatagrid);
            this.Controls.Add(this.btn_start_service);
            this.Controls.Add(this.lbl_postgreSql);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_postgreSql";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_postgreSql;
        private System.Windows.Forms.Button btn_start_service;
        private System.Windows.Forms.DataGridView mydatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_user_id;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ComboBox cbx_sql_string;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}
