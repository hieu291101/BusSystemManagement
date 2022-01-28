namespace BusSystemManagement
{
    partial class frmTableManager
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
            this.tcDriver = new System.Windows.Forms.TabControl();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.tabPageAsDriver = new System.Windows.Forms.TabPage();
            this.tabPageBus = new System.Windows.Forms.TabPage();
            this.tabPageBusLine = new System.Windows.Forms.TabPage();
            this.tabPageBusRide = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcDriver.SuspendLayout();
            this.tabPageDriver.SuspendLayout();
            this.tabPageAsDriver.SuspendLayout();
            this.tabPageBus.SuspendLayout();
            this.tabPageBusLine.SuspendLayout();
            this.tabPageBusRide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDriver
            // 
            this.tcDriver.Controls.Add(this.tabPageDriver);
            this.tcDriver.Controls.Add(this.tabPageAsDriver);
            this.tcDriver.Controls.Add(this.tabPageBus);
            this.tcDriver.Controls.Add(this.tabPageBusLine);
            this.tcDriver.Controls.Add(this.tabPageBusRide);
            this.tcDriver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDriver.Location = new System.Drawing.Point(12, 27);
            this.tcDriver.Name = "tcDriver";
            this.tcDriver.SelectedIndex = 0;
            this.tcDriver.Size = new System.Drawing.Size(839, 456);
            this.tcDriver.TabIndex = 0;
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Controls.Add(this.panel6);
            this.tabPageDriver.Location = new System.Drawing.Point(4, 25);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriver.Size = new System.Drawing.Size(831, 427);
            this.tabPageDriver.TabIndex = 0;
            this.tabPageDriver.Text = "Tài xế";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // tabPageAsDriver
            // 
            this.tabPageAsDriver.Controls.Add(this.panel5);
            this.tabPageAsDriver.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsDriver.Name = "tabPageAsDriver";
            this.tabPageAsDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsDriver.Size = new System.Drawing.Size(831, 427);
            this.tabPageAsDriver.TabIndex = 1;
            this.tabPageAsDriver.Text = "Phụ xe";
            this.tabPageAsDriver.UseVisualStyleBackColor = true;
            // 
            // tabPageBus
            // 
            this.tabPageBus.BackColor = System.Drawing.Color.Transparent;
            this.tabPageBus.Controls.Add(this.panel4);
            this.tabPageBus.Location = new System.Drawing.Point(4, 25);
            this.tabPageBus.Name = "tabPageBus";
            this.tabPageBus.Size = new System.Drawing.Size(831, 427);
            this.tabPageBus.TabIndex = 2;
            this.tabPageBus.Text = "Xe buýt";
            // 
            // tabPageBusLine
            // 
            this.tabPageBusLine.Controls.Add(this.panel3);
            this.tabPageBusLine.Location = new System.Drawing.Point(4, 25);
            this.tabPageBusLine.Name = "tabPageBusLine";
            this.tabPageBusLine.Size = new System.Drawing.Size(831, 427);
            this.tabPageBusLine.TabIndex = 3;
            this.tabPageBusLine.Text = "Tuyến xe";
            this.tabPageBusLine.UseVisualStyleBackColor = true;
            // 
            // tabPageBusRide
            // 
            this.tabPageBusRide.Controls.Add(this.panel2);
            this.tabPageBusRide.Controls.Add(this.panel1);
            this.tabPageBusRide.Location = new System.Drawing.Point(4, 25);
            this.tabPageBusRide.Name = "tabPageBusRide";
            this.tabPageBusRide.Size = new System.Drawing.Size(831, 427);
            this.tabPageBusRide.TabIndex = 4;
            this.tabPageBusRide.Text = "Chuyến xe";
            this.tabPageBusRide.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-39, -98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(421, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 48);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(421, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 48);
            this.panel3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(275, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(421, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 48);
            this.panel4.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(275, 10);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox4);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(418, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 48);
            this.panel5.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(275, 10);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 22);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm kiếm";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBox5);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(418, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 48);
            this.panel6.TabIndex = 2;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(275, 10);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(70, 10);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 495);
            this.Controls.Add(this.tcDriver);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Chương trình quản lý các chuyến xe buýt";
            this.tcDriver.ResumeLayout(false);
            this.tabPageDriver.ResumeLayout(false);
            this.tabPageAsDriver.ResumeLayout(false);
            this.tabPageBus.ResumeLayout(false);
            this.tabPageBusLine.ResumeLayout(false);
            this.tabPageBusRide.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriver;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageAsDriver;
        private System.Windows.Forms.TabPage tabPageBus;
        private System.Windows.Forms.TabPage tabPageBusLine;
        private System.Windows.Forms.TabPage tabPageBusRide;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}