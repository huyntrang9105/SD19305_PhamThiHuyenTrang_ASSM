using BUS.Reponsirory;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
	public class QLTVService
	{
		QLTVReponsitory repon;
        public QLTVService()
        {
            repon = new QLTVReponsitory();  
        }
        public List<Ctpm> GetCtpms()
        {
            return repon.GetCtpms();
        }
		public List<Docgium> GetDocgia()
		{
			return repon.GetDocgia();
		}
		public List<Phieumuon> GetPhieumuons()
		{
			return repon.GetPhieumuons();
		}
		public List<Sach> GetSaches()
		{
			return repon.GetSaches();
		}
		public List<Taikhoan> GetTaikhoans()
		{
			return repon.GetTaikhoans();
		}
		public List<Theloai> GetTheloais()
		{
			return repon.GetTheloais();
		}
		public string AddSach(Sach s)
		{
			if (repon.AddSach(s))
			{
				return "Thêm thành công";
			}
			else
			{
				return "Thêm thất bại";
			}
		}
		public string UpdateSach(Sach s)
		{
			if (repon.UpdateSach(s))
			{
				return "Update thành công";
			}
			else
			{
				return "Update thất bại";
			}
		}
		public string Remove(Sach s)
		{
			if (repon.RemoveSach(s))
			{
				return "Xóa thành công";
			}
			else
			{
				return "Xóa thất bại";
			}
		}
	}
}
