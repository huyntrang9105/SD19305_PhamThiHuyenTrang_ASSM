namespace SD19305_PhamThiHuyenTrang_ASSM
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			pictureBox1 = new PictureBox();
			groupBox1 = new GroupBox();
			btn_Thoat = new Button();
			btn_DN = new Button();
			txt_MK = new TextBox();
			txt_TK = new TextBox();
			label3 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.LimeGreen;
			label1.Location = new Point(109, 78);
			label1.Name = "label1";
			label1.Size = new Size(515, 38);
			label1.TabIndex = 0;
			label1.Text = "Đăng nhập hệ thống Quản lý thư viện";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 202);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(260, 198);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn_Thoat);
			groupBox1.Controls.Add(btn_DN);
			groupBox1.Controls.Add(txt_MK);
			groupBox1.Controls.Add(txt_TK);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(278, 202);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(510, 198);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin đăng nhập";
			// 
			// btn_Thoat
			// 
			btn_Thoat.Location = new Point(363, 148);
			btn_Thoat.Name = "btn_Thoat";
			btn_Thoat.Size = new Size(94, 29);
			btn_Thoat.TabIndex = 5;
			btn_Thoat.Text = "Thoát";
			btn_Thoat.UseVisualStyleBackColor = true;
			btn_Thoat.Click += btn_Thoat_Click;
			// 
			// btn_DN
			// 
			btn_DN.Location = new Point(133, 148);
			btn_DN.Name = "btn_DN";
			btn_DN.Size = new Size(94, 29);
			btn_DN.TabIndex = 4;
			btn_DN.Text = "Đăng nhập";
			btn_DN.UseVisualStyleBackColor = true;
			btn_DN.Click += btn_DN_Click;
			// 
			// txt_MK
			// 
			txt_MK.Location = new Point(133, 105);
			txt_MK.Name = "txt_MK";
			txt_MK.Size = new Size(342, 27);
			txt_MK.TabIndex = 3;
			txt_MK.Click += txt_MK_Click;
			txt_MK.TextChanged += txt_MK_TextChanged;
			// 
			// txt_TK
			// 
			txt_TK.Location = new Point(133, 43);
			txt_TK.Name = "txt_TK";
			txt_TK.Size = new Size(342, 27);
			txt_TK.TabIndex = 2;
			txt_TK.Click += txt_TK_Click;
			txt_TK.TextChanged += txt_TK_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(27, 112);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 1;
			label3.Text = "Mật khẩu";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 50);
			label2.Name = "label2";
			label2.Size = new Size(71, 20);
			label2.TabIndex = 0;
			label2.Text = "Tài khoản";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox1);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private GroupBox groupBox1;
		private Label label3;
		private Label label2;
		private Button btn_DN;
		private TextBox txt_MK;
		private TextBox txt_TK;
		private Button btn_Thoat;
	}
}
