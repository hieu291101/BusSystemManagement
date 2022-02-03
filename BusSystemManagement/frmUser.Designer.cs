
namespace BusSystemManagement
{
	 partial class frmUser
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
				this.panel1 = new System.Windows.Forms.Panel();
				this.panel6 = new System.Windows.Forms.Panel();
				this.label5 = new System.Windows.Forms.Label();
				this.txtEmail = new System.Windows.Forms.TextBox();
				this.panel5 = new System.Windows.Forms.Panel();
				this.txtConfirmPassword = new System.Windows.Forms.TextBox();
				this.label4 = new System.Windows.Forms.Label();
				this.panel4 = new System.Windows.Forms.Panel();
				this.txtNewPassword = new System.Windows.Forms.TextBox();
				this.label3 = new System.Windows.Forms.Label();
				this.panel3 = new System.Windows.Forms.Panel();
				this.txtOldPassword = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.panel2 = new System.Windows.Forms.Panel();
				this.txtUsername = new System.Windows.Forms.TextBox();
				this.label1 = new System.Windows.Forms.Label();
				this.btnUpdate = new System.Windows.Forms.Button();
				this.btnCancel = new System.Windows.Forms.Button();
				this.panel1.SuspendLayout();
				this.panel6.SuspendLayout();
				this.panel5.SuspendLayout();
				this.panel4.SuspendLayout();
				this.panel3.SuspendLayout();
				this.panel2.SuspendLayout();
				this.SuspendLayout();
				// 
				// panel1
				// 
				this.panel1.Controls.Add(this.panel6);
				this.panel1.Controls.Add(this.panel5);
				this.panel1.Controls.Add(this.panel4);
				this.panel1.Controls.Add(this.panel3);
				this.panel1.Controls.Add(this.panel2);
				this.panel1.Location = new System.Drawing.Point(12, 12);
				this.panel1.Name = "panel1";
				this.panel1.Size = new System.Drawing.Size(458, 216);
				this.panel1.TabIndex = 0;
				// 
				// panel6
				// 
				this.panel6.Controls.Add(this.label5);
				this.panel6.Controls.Add(this.txtEmail);
				this.panel6.Location = new System.Drawing.Point(3, 46);
				this.panel6.Name = "panel6";
				this.panel6.Size = new System.Drawing.Size(452, 37);
				this.panel6.TabIndex = 2;
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label5.Location = new System.Drawing.Point(3, 6);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(57, 19);
				this.label5.TabIndex = 0;
				this.label5.Text = "Email:";
				// 
				// txtEmail
				// 
				this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtEmail.Location = new System.Drawing.Point(134, 3);
				this.txtEmail.Name = "txtEmail";
				this.txtEmail.Size = new System.Drawing.Size(318, 26);
				this.txtEmail.TabIndex = 1;
				// 
				// panel5
				// 
				this.panel5.Controls.Add(this.txtConfirmPassword);
				this.panel5.Controls.Add(this.label4);
				this.panel5.Location = new System.Drawing.Point(3, 174);
				this.panel5.Name = "panel5";
				this.panel5.Size = new System.Drawing.Size(452, 37);
				this.panel5.TabIndex = 4;
				// 
				// txtConfirmPassword
				// 
				this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtConfirmPassword.Location = new System.Drawing.Point(134, 3);
				this.txtConfirmPassword.Name = "txtConfirmPassword";
				this.txtConfirmPassword.Size = new System.Drawing.Size(318, 26);
				this.txtConfirmPassword.TabIndex = 1;
				this.txtConfirmPassword.UseSystemPasswordChar = true;
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label4.Location = new System.Drawing.Point(3, 6);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(81, 19);
				this.label4.TabIndex = 0;
				this.label4.Text = "Nhập lại: ";
				// 
				// panel4
				// 
				this.panel4.Controls.Add(this.txtNewPassword);
				this.panel4.Controls.Add(this.label3);
				this.panel4.Location = new System.Drawing.Point(3, 131);
				this.panel4.Name = "panel4";
				this.panel4.Size = new System.Drawing.Size(452, 37);
				this.panel4.TabIndex = 3;
				// 
				// txtNewPassword
				// 
				this.txtNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtNewPassword.Location = new System.Drawing.Point(134, 3);
				this.txtNewPassword.Name = "txtNewPassword";
				this.txtNewPassword.Size = new System.Drawing.Size(318, 26);
				this.txtNewPassword.TabIndex = 1;
				this.txtNewPassword.UseSystemPasswordChar = true;
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label3.Location = new System.Drawing.Point(3, 6);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(117, 19);
				this.label3.TabIndex = 0;
				this.label3.Text = "Mật khẩu mới:";
				// 
				// panel3
				// 
				this.panel3.Controls.Add(this.txtOldPassword);
				this.panel3.Controls.Add(this.label2);
				this.panel3.Location = new System.Drawing.Point(3, 88);
				this.panel3.Name = "panel3";
				this.panel3.Size = new System.Drawing.Size(452, 37);
				this.panel3.TabIndex = 2;
				// 
				// txtOldPassword
				// 
				this.txtOldPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtOldPassword.Location = new System.Drawing.Point(134, 3);
				this.txtOldPassword.Name = "txtOldPassword";
				this.txtOldPassword.Size = new System.Drawing.Size(318, 26);
				this.txtOldPassword.TabIndex = 1;
				this.txtOldPassword.UseSystemPasswordChar = true;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.Location = new System.Drawing.Point(3, 6);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(107, 19);
				this.label2.TabIndex = 0;
				this.label2.Text = "Mật khẩu cũ:";
				// 
				// panel2
				// 
				this.panel2.Controls.Add(this.txtUsername);
				this.panel2.Controls.Add(this.label1);
				this.panel2.Location = new System.Drawing.Point(3, 3);
				this.panel2.Name = "panel2";
				this.panel2.Size = new System.Drawing.Size(452, 37);
				this.panel2.TabIndex = 1;
				// 
				// txtUsername
				// 
				this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtUsername.Location = new System.Drawing.Point(134, 3);
				this.txtUsername.Name = "txtUsername";
				this.txtUsername.ReadOnly = true;
				this.txtUsername.Size = new System.Drawing.Size(318, 26);
				this.txtUsername.TabIndex = 1;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.Location = new System.Drawing.Point(3, 6);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(130, 19);
				this.label1.TabIndex = 0;
				this.label1.Text = "Tên đăng nhập:";
				// 
				// btnUpdate
				// 
				this.btnUpdate.AutoSize = true;
				this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnUpdate.Location = new System.Drawing.Point(149, 234);
				this.btnUpdate.Name = "btnUpdate";
				this.btnUpdate.Size = new System.Drawing.Size(138, 31);
				this.btnUpdate.TabIndex = 1;
				this.btnUpdate.Text = "Cập nhật";
				this.btnUpdate.UseVisualStyleBackColor = true;
				this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
				// 
				// btnCancel
				// 
				this.btnCancel.AutoSize = true;
				this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnCancel.Location = new System.Drawing.Point(331, 234);
				this.btnCancel.Name = "btnCancel";
				this.btnCancel.Size = new System.Drawing.Size(136, 31);
				this.btnCancel.TabIndex = 2;
				this.btnCancel.Text = "Thoát";
				this.btnCancel.UseVisualStyleBackColor = true;
				this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
				// 
				// frmUser
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(482, 282);
				this.Controls.Add(this.btnCancel);
				this.Controls.Add(this.btnUpdate);
				this.Controls.Add(this.panel1);
				this.Name = "frmUser";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Thông tin cá nhân";
				this.Load += new System.EventHandler(this.frmUser_Load);
				this.panel1.ResumeLayout(false);
				this.panel6.ResumeLayout(false);
				this.panel6.PerformLayout();
				this.panel5.ResumeLayout(false);
				this.panel5.PerformLayout();
				this.panel4.ResumeLayout(false);
				this.panel4.PerformLayout();
				this.panel3.ResumeLayout(false);
				this.panel3.PerformLayout();
				this.panel2.ResumeLayout(false);
				this.panel2.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Panel panel1;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Panel panel2;
		  private System.Windows.Forms.TextBox txtUsername;
		  private System.Windows.Forms.Panel panel5;
		  private System.Windows.Forms.TextBox txtConfirmPassword;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Panel panel4;
		  private System.Windows.Forms.TextBox txtNewPassword;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Panel panel3;
		  private System.Windows.Forms.TextBox txtOldPassword;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Panel panel6;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.TextBox txtEmail;
		  private System.Windows.Forms.Button btnUpdate;
		  private System.Windows.Forms.Button btnCancel;
	 }
}