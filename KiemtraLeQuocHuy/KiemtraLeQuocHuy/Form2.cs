using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemtraLeQuocHuy
{
    public partial class Form2 : Form
    {
        string MaHoaDon;
        public delegate void Mydel(string s, string sv);
        public Mydel d { get; set; }
        public Form2(string m)
        {
            InitializeComponent();
            MaHoaDon = m;
            SetCBB();
        }
        public void SetCBB()
        {
            
            foreach (HopDong i in CSDL_OOP.Instance.GETALLHopDong())
            {
                cbbHD.Items.Add(new CBBItems
                {
                    t = i.NgayHetHang,
                    Value = Convert.ToInt32(i.ID_HopDong),
                    Text = i.TenHopDong
                });
            }
        }

        public void AddHoadon()
        {
            if(txtMahdon.Text != "" && txtSotien.Text != "" && cbbHD.SelectedItem != null)
            {
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = txtMahdon.Text;
                hd.SoTien = Convert.ToDouble(txtSotien.Text);
                hd.NgayXuat = dateTimePicker1.Value;
                hd.ID_HopDong = ((CBBItems)cbbHD.SelectedItem).Value.ToString();
                if (CSDL_OOP.Instance.Excute(hd.MaHoaDon) == true)
                {
                    CSDL_OOP.Instance.AddHoaDonCSDLOOP(hd);
                   
                }
                else MessageBox.Show("Ma sinh vien da ton tai");
            }
        }
        public void EditHoadon()
        {
            if (txtSotien.Text != "" && cbbHD.SelectedItem != null)
            {
                //HoaDon hd1 = CSDL_OOP.Instance.GetHoaDonByMa(MaHoaDon);
                if (dateTimePicker1.Value < ((CBBItems)cbbHD.SelectedItem).t)
                {
                    HoaDon hd = new HoaDon();
                    hd.SoTien = Convert.ToDouble(txtSotien.Text);
                    hd.NgayXuat = dateTimePicker1.Value;
                    hd.ID_HopDong = ((CBBItems)cbbHD.SelectedItem).Value.ToString();
                    CSDL_OOP.Instance.EditSVCSDLOOP(MaHoaDon, hd);
                }
                else { MessageBox.Show("Ngay xuat lon hon ngay han"); }
            }
            else MessageBox.Show("Nhap thieu thong tin");

        }
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (CSDL_OOP.Instance.Excute(MaHoaDon))
            {
                AddHoadon();
            }
            else
            {
                EditHoadon();
            }
            d("0", "");
        }

        public void GUI()
        {
            HoaDon hd = new HoaDon();
            hd = CSDL_OOP.Instance.GetHoaDonByMa(MaHoaDon);
            txtMahdon.Text = hd.MaHoaDon;
            txtSotien.Text = hd.SoTien.ToString();
            dateTimePicker1.Value = hd.NgayXuat;
            foreach (object i in cbbHD.Items)
            {
                if (((CBBItems)i).Value.ToString() == hd.ID_HopDong)
                {
                    cbbHD.SelectedItem = i;
                }
            }
            txtMahdon.Enabled = false;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
