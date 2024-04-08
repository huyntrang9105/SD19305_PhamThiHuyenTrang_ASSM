using BUS.Service;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD19305_PhamThiHuyenTrang_ASSM
{
	public partial class Form2 : Form
	{
		private QLTVService qltv;
		private string idWhenClick;
		public Form2()
		{
			InitializeComponent();
			qltv = new QLTVService();
			LoadGrid();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
		public void LoadGrid()
		{
			dtgView_CTPM.ColumnCount = 3;
			dtgView_CTPM.Columns[0].Name = "Mã phiếu";
			dtgView_CTPM.Columns[1].Name = "Mã sách";
			dtgView_CTPM.Columns[2].Name = "Số lượng";
			dtgView_CTPM.Rows.Clear();
			foreach (var ctpm in qltv.GetCtpms())
			{
				dtgView_CTPM.Rows.Add(ctpm.MaPhieu, ctpm.MaSach, ctpm.SoLuong);
			}
			dtgView_Sach.ColumnCount = 5;
			dtgView_Sach.Columns[0].Name = "Mã sách";
			dtgView_Sach.Columns[1].Name = "Tên sách";
			dtgView_Sach.Columns[2].Name = "Thể loại";
			dtgView_Sach.Columns[3].Name = "Năm XB";
			dtgView_Sach.Columns[4].Name = "NXB";
			dtgView_Sach.Rows.Clear();
			foreach (var s in qltv.GetSaches())
			{
				dtgView_Sach.Rows.Add(s.MaSach, s.TenSach, s.MaTheLoai, s.NamXb, s.Nxb);
			}
			dtgView_TK.ColumnCount = 7;
			dtgView_TK.Columns[0].Name = "Mã NV";
			dtgView_TK.Columns[1].Name = "Họ tên";
			dtgView_TK.Columns[2].Name = "Ngày sinh";
			dtgView_TK.Columns[3].Name = "SDT";
			dtgView_TK.Columns[4].Name = "Vai trò";
			dtgView_TK.Columns[5].Name = "Tài khoản";
			dtgView_TK.Columns[6].Name = "Mật khẩu";
			dtgView_TK.Rows.Clear();
			foreach (var tk in qltv.GetTaikhoans())
			{
				dtgView_TK.Rows.Add(tk.MaNv, tk.HoTen, tk.NgaySinh, tk.Sdt, tk.VaiTro, tk.TaiKhoan1, tk.MatKhau);
			}
			dtgView_DocGia.ColumnCount = 3;
			dtgView_DocGia.Columns[0].Name = "Mã độc giả";
			dtgView_DocGia.Columns[1].Name = "Mã độc giả";
			dtgView_DocGia.Columns[2].Name = "SDT";
			dtgView_DocGia.Rows.Clear();
			foreach (var dg in qltv.GetDocgia())
			{
				dtgView_DocGia.Rows.Add(dg.MaDocGia, dg.TenDocGia, dg.Sdt);
			}
			dtgView_PhieuMuon.ColumnCount = 8;
			dtgView_PhieuMuon.Columns[0].Name = "Mã phiếu";
			dtgView_PhieuMuon.Columns[1].Name = "Mã NV";
			dtgView_PhieuMuon.Columns[2].Name = "Mã độc giả";
			dtgView_PhieuMuon.Columns[3].Name = "Ngày mượn";
			dtgView_PhieuMuon.Columns[4].Name = "Ngày hết hạn";
			dtgView_PhieuMuon.Columns[5].Name = "Ngày trả";
			dtgView_PhieuMuon.Columns[6].Name = "Trạng thái trả";
			dtgView_PhieuMuon.Columns[7].Name = "Ghi chú";
			dtgView_PhieuMuon.Rows.Clear();
			foreach (var pm in qltv.GetPhieumuons())
			{
				dtgView_PhieuMuon.Rows.Add(pm.MaPhieu, pm.MaNv, pm.MaDocGia,
					pm.NgayMuon, pm.NgayHetHan, pm.NgayTra, pm.TrangThaiTra, pm.GhiChu);
			}

		}
		public void BinData()
		{
			var s = qltv.GetSaches().First(x => x.MaSach == idWhenClick);
			txt_MaSach1.Text = s.MaSach;
			txt_TenSach1.Text = s.TenSach;
			txt_TheLoai1.Text = s.MaTheLoai;
			txt_NamXB1.Text = s.NamXb.ToString();
			txt_NXB1.Text = s.Nxb;
		}
		private void dtgView_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0)
			{
				return;
			}
			idWhenClick = dtgView_Sach.Rows[rowIndex].Cells[0].Value.ToString();
			BinData();
		}

		private void btn_Add1_Click(object sender, EventArgs e)
		{
			Sach s = new Sach();
			s.MaSach = txt_MaSach1.Text;
			s.TenSach = txt_TenSach1.Text;
			s.MaTheLoai = txt_TheLoai1.Text;
			s.NamXb = DateTime.Parse(txt_NamXB1.Text);
			s.Nxb = txt_NXB1.Text;
			MessageBox.Show(qltv.AddSach(s));
			LoadGrid();
		}

		private void btn_Update1_Click(object sender, EventArgs e)
		{
			//var clone = qltv.GetSaches()
		}

		
	}
}
