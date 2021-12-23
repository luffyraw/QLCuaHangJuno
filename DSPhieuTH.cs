using Microsoft.Data.SqlClient;
using QLCuaHangJuno.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangJuno
{
    
    public partial class DSPhieuTH : Form
    {
        string connectString = @"Data Source=DESKTOP-94IFOHB\SQLEXPRESS;Initial Catalog=QuanLyCuaHangJuno;Integrated Security=True";
        SqlConnection connect;
        SqlCommand cm;
        string query = "";
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public DSPhieuTH()
        {
            InitializeComponent();
        }

        private void DSPhieuTH_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();   

        }

        private void HienThiDuLieu()
        {
            
            Focus();
            var query = from p in db.PhieuTraHangs
                        select new
                        {
                            p.MaPhieuTra,
                            NgayLap = p.NgayLap.ToString("dd/MM/yyyy"),
                            p.MaNv,
                            p.MaSpCt,
                            p.MaHd,
                            p.LyDoTra
                        };
            dataGridView1.DataSource = query.ToList();
           /* query = "SELECT * FROM PhieuTraHang";
            //var qr = from tl in db.TheLoais
            //         select new
            //         {
            //             tl.MaTheLoai,
            //             tl.TenTheLoai,
            //         };
            connect = new SqlConnection(connectString);

            connect.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adt.Fill(table);
            //dgv_theloai.DataSource = qr.ToList();
            dataGridView1.DataSource = table;
            connect.Close();*/

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkMaPT() && checkMaNV() && checkMaHD())
            {
                
                var query = from p in db.PhieuTraHangs
                            select new
                            {
                                p.MaPhieuTra,
                                p.NgayLap,
                                p.MaNv,
                                p.MaSpCt,
                                p.MaHd,
                                p.LyDoTra
                            };
                
                if(txtMaPT.Text!=null && txtMaPT.Text != "")
                {
                    query=query.Where(p => p.MaPhieuTra == txtMaPT.Text);
                }
                if(txtMaHD.Text!=null && txtMaHD.Text != "")
                {
                    query = query.Where(p => p.MaHd == txtMaHD.Text);
                }
                if (txtMaNV.Text != null && txtMaNV.Text != "")
                {
                    query = query.Where(p => p.MaNv == txtMaNV.Text);
                }
                if (dateTimePicker1.Enabled == true)
                {
         
                    query = query.Where(p =>(p.NgayLap).Date  == dateTimePicker1.Value.Date);
                    //MessageBox.Show(dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                }
                
                dataGridView1.DataSource = query.ToList();

                if (query.ToList().Count <= 0)
                {
                    MessageBox.Show("Không có phiếu trả nào phù hợp với điều kiện bạn tìm kiếm");
                }
            }
            else
            {
                
                if (!checkMaPT())
                {
                    txtMaPT.Focus();
                }
                else if (!checkMaHD())
                {
                    txtMaHD.Focus();
                }
                else if (!checkMaNV())
                {
                    txtMaNV.Focus();
                }

            }
        }


        public bool checkMaPT()
        {
            if (txtMaPT.Text.Length>10)
            {
                errorProvider1.SetError(txtMaPT, "Mã phiếu trả hàng <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaPT, "");
                return true;
            }
        }

        public bool checkMaNV()
        {
            if (txtMaNV.Text.Length > 10)
            {
                errorProvider1.SetError(txtMaNV, "Mã nhân viên <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaNV, "");
                return true;
            }
        }

        public bool checkMaHD()
        {
            if (txtMaHD.Text.Length > 10)
            {
                errorProvider1.SetError(txtMaHD, "Mã hóa đơn <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPT.Text = null;
            txtMaHD.Text = null;
            txtMaNV.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            txtMaPT.Focus();
            HienThiDuLieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.Rows.Count > 0 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[0];
                if (cell != null && !String.IsNullOrEmpty(cell.Value as string))
                {
                    // do something
                    txtMaPT.Text = cell.Value.ToString();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaPT.Text!="" && txtMaPT.Text != null)
            {
                ChiTietPhieuTH ct = new ChiTietPhieuTH(txtMaPT.Text);
                ct.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu trả hàng !");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPhieuTH phieu = new AddPhieuTH();
            phieu.Show();
        }
    }
}
