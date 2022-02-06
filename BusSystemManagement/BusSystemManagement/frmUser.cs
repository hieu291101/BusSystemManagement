using BUS_BusSystemManagement;
using DTO_BusSystemManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSystemManagement
{
	 public partial class frmUser : Form
	 {
		  private static DTO_User account;
		  private BUS_User _User=new BUS_User();

		  public frmUser()
		  {
				InitializeComponent();
		  }

		  public frmUser(DTO_User user) : this() => account = user;

		  private void frmUser_Load(object sender, EventArgs e)
		  {
				txtUsername.Text = account.USER_USERNAME;
				txtEmail.Text = account.USER_EMAIL;
				txtEmail.Focus();
		  }

		  private void btnUpdate_Click(object sender, EventArgs e)
		  {
				string old_password=txtOldPassword.Text;
				string new_password=txtNewPassword.Text;
				string conf_password=txtConfirmPassword.Text;
				string email=txtEmail.Text;

				//Email có thay đổi hoặc mật khẩu mới có nhập
				if (!email.Equals(account.USER_EMAIL) || new_password != "")
				{
					 //Mật khẩu cũ chưa nhập => báo lỗi, nhập mật khẩu
					 if (old_password == "")
					 {
						  MessageBox.Show("Chưa nhập mật khẩu. Nhập mật khẩu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						  txtConfirmPassword.Focus();
						  return;
					 }
					 else
					 {
						  //Mật khẩu cũ đúng
						  if (old_password.Equals(account.USER_PASSWORD) == true)
						  {
								//Mật khẩu mới trùng mật khẩu cũ => báo lỗi, nhập lại
								if (new_password.Equals(account.USER_PASSWORD))
								{
									 MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ. Nhập lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
									 txtNewPassword.Focus();
									 return;
								}

								//Xác thực mật khẩu mới khớp => cập nhật
								if (new_password.Equals(conf_password) == true)
								{
									 if (new_password != "")
										  account.USER_PASSWORD = new_password;
									 if (email != account.USER_EMAIL)
										  account.USER_EMAIL = email;

									 //Cập nhật thông tin tài khoản
									 if (_User.UpdateUser(account))
									 {
										  MessageBox.Show("Tài khoản đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

										  frmTableManager frmTableManager=new frmTableManager(account);
										  this.Hide();
										  frmTableManager.ShowDialog();
									 }
									 else
									 {
										  MessageBox.Show("Có lỗi trong quá trình cập nhật. Thử lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
										  btnUpdate.Focus();
										  return;
									 }
								}
								else //Xác thực mật khẩu không khớp => báo lỗi, nhập lại
								{
									 MessageBox.Show("Mật khẩu không khớp. Thử lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
									 txtConfirmPassword.Focus();
									 return;
								}
						  }
						  else //Mật khẩu cũ nhập sai => báo lỗi, nhập lại
						  {
								MessageBox.Show("Mật khẩu sai. Thử lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
								txtOldPassword.Focus();
								return;
						  }
					 }
				}
				else //Không có thay đổi thông tin
				{
					 MessageBox.Show("Không có thay đổi gì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					 return;
				} 
		  }

		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				frmTableManager frmTableManager=new frmTableManager(account);
				this.Hide();
				frmTableManager.ShowDialog();
		  }

	 }
}
