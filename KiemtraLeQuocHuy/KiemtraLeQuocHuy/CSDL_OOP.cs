using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemtraLeQuocHuy
{
    class CSDL_OOP
    {
        public List<HoaDon> l { get; set; }
        private static CSDL_OOP _Instance;
        
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set
            {

            }
        }

        private CSDL_OOP()
        {
            l = GetALLHoaDon();
        }

        public List<HoaDon> GetALLHoaDon()
        {
            List<HoaDon> l = new List<HoaDon>();

            foreach (DataRow i in CSDL.Instance.DTHoaDon.Rows)
            {
                l.Add(new HoaDon
                {
                    MaHoaDon = i["MaHoaDon"].ToString(),
                    NgayXuat = (DateTime)i["NgayXuat"],
                    SoTien = Convert.ToDouble(i["SoTien"]),
                    ID_HopDong = i["ID_HopDong"].ToString()
                });
            }
            return l;
        }

        public List<HopDong> GETALLHopDong()
        {
            List<HopDong> dt = new List<HopDong>();
            foreach (DataRow i in CSDL.Instance.DTHopDong.Rows)
            {
                dt.Add(new HopDong
                {
                    ID_HopDong = i["IDHopDong"].ToString(),
                    TenHopDong = i["TenHopDong"].ToString(),
                    NgayHetHang = (DateTime)i["NgayHetHan"]
                });
            }
                return dt;
        }


        public List<HoaDon> GetListHoaDon(string IDHopDong, string IDHoaDon)
        {
            List<HoaDon> dt = new List<HoaDon>();
            foreach(HoaDon i in l)
            {
                if(IDHopDong == "0")
                {
                    if(IDHoaDon == null)
                    {
                        return l;
                    }
                    else if(i.MaHoaDon.Contains(IDHoaDon) == true)
                    {
                        dt.Add(i);
                    }

                }

                else if(i.ID_HopDong == IDHopDong)
                {
                    if(IDHoaDon == null)
                    {
                        dt.Add(i);
                    }
                    else if(i.MaHoaDon.Contains(IDHoaDon) == true)
                    {
                        dt.Add(i);
                    }
                }
            }
            return dt;
        }

        public void DeleteHoaDon(List<string> MaHoaDon)
        {
            HoaDon hd = new HoaDon();
            string index = "";

            foreach(string j in MaHoaDon)
            {
                foreach(HoaDon i in l)
                {
                    if(j == i.MaHoaDon)
                    {
                        index = i.MaHoaDon;
                        hd = i;
                    }
                }
                l.Remove(hd);
                CSDL.Instance.DeleteDataRow(index);
            }
        }

        public bool Excute(string MaHoaDon)
        {
            bool check = true;
            foreach (HoaDon i in l)
            {
                if (i.MaHoaDon == MaHoaDon)
                {
                    check = false; break;
                }
            }
            return check;
        }

        public void AddHoaDonCSDLOOP(HoaDon hd)
        {
            l.Add(hd);
            CSDL.Instance.AddDataRow(hd);
        }

        public void EditSVCSDLOOP(string MaHoaDon, HoaDon hd)
        {
            foreach (HoaDon i in l)
            {
                if (i.MaHoaDon == MaHoaDon)
                {
                    i.NgayXuat = hd.NgayXuat;
                    i.SoTien = hd.SoTien;
                    i.ID_HopDong = hd.ID_HopDong;
                }
            }
            CSDL.Instance.EditDataRow(hd);
        }

        public HoaDon GetHoaDonByMa(string MaHoaDon)
        {
            HoaDon hd = new HoaDon();
            foreach (HoaDon i in l)
            {
                if (i.MaHoaDon == MaHoaDon)
                {
                    hd = i;
                }
            }
            return hd;
        }

        public void Sort(int s)
        {
            HoaDon o = new HoaDon();
            switch(s)
            {
                case 1:
                    {
                        for (int i = 0; i < l.Count - 1; i++)
                        {
                            for (int j = i + 1; j < l.Count; j++)
                            {
                                if (String.Compare(l[i].MaHoaDon, l[j].MaHoaDon) > 0)
                                {
                                    o = l[i];
                                    l[i] = l[j];
                                    l[j] = o;
                                }
                            }
                        }
                        break;
                    }
            }
        }
    }
}
