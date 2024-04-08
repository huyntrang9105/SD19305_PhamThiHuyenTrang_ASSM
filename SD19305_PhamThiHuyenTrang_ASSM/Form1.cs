namespace SD19305_PhamThiHuyenTrang_ASSM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void btn_DN_Click(object sender, EventArgs e)
		{
			string user = txt_TK.Text;
			string pass = txt_MK.Text;
			if (user == "trangpth" && pass == "12345")
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Hide();
			Form2 fm2 = new Form2();
			fm2.ShowDialog();
			fm2 = null;
			this.Close();
		}
		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Close();
		}
		private void txt_TK_Click(object sender, EventArgs e)
		{
		}
		private void txt_MK_Click(object sender, EventArgs e)
		{
		}

		private void txt_TK_TextChanged(object sender, EventArgs e)
		{
		}

		private void txt_MK_TextChanged(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
