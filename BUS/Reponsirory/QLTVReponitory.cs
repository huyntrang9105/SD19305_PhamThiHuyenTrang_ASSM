using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Reponsirory
{
	internal class QLTVReponsitory
	{
		DBContext context = new DBContext();
        public QLTVReponsitory()
        {
            context = new DBContext();
        }
        public List<Ctpm> GetCtpms()
        {
            return context.Ctpms.ToList();
        }
		public List<Docgium> GetDocgia()
		{
			return context.Docgia.ToList();
		}
		public List<Phieumuon> GetPhieumuons()
		{
			return context.Phieumuons.ToList();
		}
		public List<Sach> GetSaches()
		{
			return context.Saches.ToList();
		}
		public List<Taikhoan> GetTaikhoans()
		{
			return context.Taikhoans.ToList();
		}
		public List<Theloai> GetTheloais()
		{
			return context.Theloais.ToList();
		}
		public bool AddSach(Sach s)
		{
			if(s  == null)
			{
				return false;
			}
			context.Saches.Add(s);
			context.SaveChanges();
			return true;
		}
		public bool UpdateSach(Sach s)
		{
			if(s == null)
			{
				return false;
			}
			context.Saches.Update(s);
			context.SaveChanges();
			return true;
		}
		public bool RemoveSach(Sach s)
		{
			if( s == null)
			{
				return false;
			}
			context.Saches.Remove(s);
			context.SaveChanges();
			return true;
		}
		
	}
}
