using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemtraLeQuocHuy
{
    class CSDL
    {
        public DataTable DTHoaDon { get; set; }
        public DataTable DTHopDong { get; set; }
        private static CSDL _Instance;

        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }

        private CSDL()
        {
            DTHoaDon = new DataTable();
            DTHoaDon.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaHoaDon", typeof(string)),
                new DataColumn("NgayXuat", typeof(DateTime)),
                new DataColumn("SoTien", typeof(double)),
                new DataColumn("ID_HopDong", typeof(string)),
            });

            DataRow r = DTHoaDon.NewRow();
            r["MaHoaDon"] = "102";
            r["NgayXuat"] = new DateTime(2010, 10, 12);
            r["SoTien"] = 1000;
            r["ID_HopDong"] = "123";
            DTHoaDon.Rows.Add(r);

            DataRow r1 = DTHoaDon.NewRow();
            r1["MaHoaDon"] = "103";
            r1["NgayXuat"] = new DateTime(2010, 10, 12);
            r1["SoTien"] = 3000;
            r1["ID_HopDong"] = "123";
            DTHoaDon.Rows.Add(r1);

            DataRow r2 = DTHoaDon.NewRow();
            r2["MaHoaDon"] = "101";
            r2["NgayXuat"] = new DateTime(2010, 10, 12);
            r2["SoTien"] = 8000;
            r2["ID_HopDong"] = "124";
            DTHoaDon.Rows.Add(r2);

            DataRow r3 = DTHoaDon.NewRow();
            r3["MaHoaDon"] = "104";
            r3["NgayXuat"] = new DateTime(2010, 10, 12);
            r3["SoTien"] = 10000;
            r3["ID_HopDong"] = "124";
            DTHoaDon.Rows.Add(r3);

            DTHopDong = new DataTable();
            DTHopDong.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDHopDong", typeof(string)),
                new DataColumn("TenHopDong" , typeof(string)),
                new DataColumn("NgayHetHan",typeof(DateTime))
            });

            DataRow r4 = DTHopDong.NewRow();
            r4["IDHopDong"] = "123";
            r4["TenHopDong"] = "HopDong A";
            r4["NgayHetHan"] = DateTime.Now;
            DTHopDong.Rows.Add(r4);

            DataRow r5 = DTHopDong.NewRow();
            r5["IDHopDong"] = "124";
            r5["TenHopDong"] = "HopDong B";
            r5["NgayHetHan"] = DateTime.Now;
            DTHopDong.Rows.Add(r5);
        }

        public void DeleteDataRow(string index)
        {
            foreach (DataRow i in DTHoaDon.Select())
            {
                if (i["MaHoaDon"].ToString() == index)
                {
                    DTHoaDon.Rows.Remove(i);
                }
            }
            DTHoaDon.AcceptChanges();
        }
        public void AddDataRow(HoaDon s)
        {

            DataRow r8 = DTHoaDon.NewRow();
            r8["MaHoaDon"] = s.MaHoaDon;
            r8["NgayXuat"] = s.NgayXuat;
            r8["SoTien"] = s.SoTien;
            r8["ID_HopDong"] = s.ID_HopDong;
            DTHoaDon.Rows.Add(r8);
        }
        public void EditDataRow(HoaDon hd)
        {
            foreach (DataRow i in DTHoaDon.Rows)
                if (hd.MaHoaDon == i["MaHoaDon"].ToString())
                {
                    i["MaHoaDon"] = hd.MaHoaDon;
                    i["NgayXuat"] = hd.NgayXuat;
                    i["SoTien"] = hd.SoTien;
                    i["ID_HopDong"] = hd.ID_HopDong;
                }
        }
    }
}
