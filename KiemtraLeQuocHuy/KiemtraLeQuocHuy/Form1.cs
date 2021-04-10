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
    public partial class Form1 : Form
    {
        public delegate void Mydel1(int s);
        public Mydel1 d1 { get; set; }
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            cbbHopdong.SelectedIndex = 0;
            dataGridView1.DataSource = CSDL_OOP.Instance.GetALLHoaDon();
        }

        public void SetCBB()
        {
            cbbHopdong.Items.Add(new CBBItems { Value = 0, Text = "All" });
            foreach (HopDong i in CSDL_OOP.Instance.GETALLHopDong())
            {
                cbbHopdong.Items.Add(new CBBItems
                {
                    t = i.NgayHetHang,
                    Value = Convert.ToInt32(i.ID_HopDong),
                    Text = i.TenHopDong
                });
            }
        }

        public void Show(string IDHopDong, string IDHoaDon)
        {
            dataGridView1.DataSource = CSDL_OOP.Instance.GetListHoaDon(IDHopDong, IDHoaDon);
        }

        private void Showbt_Click(object sender, EventArgs e)
        {
            Show(((CBBItems)cbbHopdong.SelectedItem).Value.ToString(), null);
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 0)
            {
                List<string> dt = new List<string>();
                foreach (DataGridViewRow i in r)
                {
                    dt.Add(i.Cells["MaHoaDon"].Value.ToString());
                    CSDL_OOP.Instance.DeleteHoaDon(dt);
                }
                Show(((CBBItems)cbbHopdong.SelectedItem).Value.ToString(), null);
            }        
        }

        private void Searchbt_Click(object sender, EventArgs e)
        {
            Show(((CBBItems)cbbHopdong.SelectedItem).Value.ToString(), txtSearch.Text);
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(null);
            f2.d += new Form2.Mydel(Show);
            f2.Show();
        }

        private void Editbt_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;


            foreach (DataGridViewRow i in r)
            {
                if (r.Count > 0)
                {
                    Form2 f2 = new Form2(i.Cells["MaHoaDon"].Value.ToString());
                    f2.GUI();
                    f2.d += new Form2.Mydel(Show);
                    f2.Show();
                }
            }
        }

        private void Sortbt_Click(object sender, EventArgs e)
        {
            CSDL_OOP.Instance.Sort(1);
            Show(((CBBItems)cbbHopdong.SelectedItem).Value.ToString(), null);
        }
    }
}
