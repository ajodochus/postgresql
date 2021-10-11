namespace playground
{
    partial class Playground
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_Misc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_set_system_time = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_rgb_handler = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(88, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 400);
            this.panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Misc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToolStripMenu_Misc
            // 
            this.ToolStripMenu_Misc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_set_system_time,
            this.ToolStripMenu_rgb_handler,
            this.sqlToolStripMenuItem,
            this.ssssToolStripMenuItem});
            this.ToolStripMenu_Misc.Name = "ToolStripMenu_Misc";
            this.ToolStripMenu_Misc.Size = new System.Drawing.Size(50, 20);
            this.ToolStripMenu_Misc.Text = "Menu";
            // 
            // ToolStripMenu_set_system_time
            // 
            this.ToolStripMenu_set_system_time.Name = "ToolStripMenu_set_system_time";
            this.ToolStripMenu_set_system_time.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_set_system_time.Text = "set system time";
            this.ToolStripMenu_set_system_time.Click += new System.EventHandler(this.btn_system_datetime_Click);
            // 
            // ToolStripMenu_rgb_handler
            // 
            this.ToolStripMenu_rgb_handler.Name = "ToolStripMenu_rgb_handler";
            this.ToolStripMenu_rgb_handler.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenu_rgb_handler.Text = "rgb handler";
            this.ToolStripMenu_rgb_handler.Click += new System.EventHandler(this.rgb_slider_Click);
            // 
            // sqlToolStripMenuItem
            // 
            this.sqlToolStripMenuItem.Name = "sqlToolStripMenuItem";
            this.sqlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sqlToolStripMenuItem.Text = "sql";
            this.sqlToolStripMenuItem.Click += new System.EventHandler(this.sqlToolStripMenuItem_Click);
            // 
            // ssssToolStripMenuItem
            // 
            this.ssssToolStripMenuItem.Name = "ssssToolStripMenuItem";
            this.ssssToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ssssToolStripMenuItem.Text = "ssss";
            this.ssssToolStripMenuItem.Click += new System.EventHandler(this.ssssToolStripMenuItem_Click);
            // 
            // Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Playground";
            this.Text = "Playground";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Misc;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_set_system_time;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_rgb_handler;
        private System.Windows.Forms.ToolStripMenuItem sqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssssToolStripMenuItem;
    }
}

