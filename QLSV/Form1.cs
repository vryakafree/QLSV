using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;
using System.IO;

namespace QLSV
{
    public partial class Form1 : Form
    {
        BUS_ThanhVien busTV = new BUS_ThanhVien();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnloaddb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTV.GetThanhVien(); //lấy thông tin bỏ vô bảng
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtclass.Text != "" && txtid.Text != "" && txtidk.Text != "" && txtidn.Text != "")
            {
                DTO_ThanhVien tv = new DTO_ThanhVien(Convert.ToInt32(txtid.Text), txtname.Text, txtclass.Text, Convert.ToInt32(txtidk.Text), Convert.ToInt32(txtidn.Text));

                if (busTV.ThemThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = busTV.GetThanhVien(); // refresh datagridview
                }
                else
                {
                    lberror.Text = "Trùng id";
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Tạo DTo
                DTO_ThanhVien tv = new DTO_ThanhVien(Convert.ToInt32(txtid.Text), txtname.Text, txtclass.Text, Convert.ToInt32(txtidk.Text), Convert.ToInt32(txtidn.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Xóa
                if (busTV.SuaThanhVien(tv))
                {
                    MessageBox.Show("Sửa thành công");
                    dataGridView1.DataSource = busTV.GetThanhVien();
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Tạo DTo
                DTO_ThanhVien tv = new DTO_ThanhVien(Convert.ToInt32(txtid.Text), txtname.Text, txtclass.Text, Convert.ToInt32(txtidk.Text), Convert.ToInt32(txtidn.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Xóa
                if (busTV.XoaThanhVien(tv))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = busTV.GetThanhVien(); 
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = busTV.TimSinhVien(value);
                dataGridView1.DataSource = dt;
            }
            else
                dataGridView1.DataSource = busTV.GetThanhVien();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbkhoa.DisplayMember = "TEN_KHOA";
            cbkhoa.ValueMember = "ID_KHOA";
            cbkhoa.DataSource = busTV.LoadKhoa(); //lấy thông tin bỏ vô combobox

            cbnganh.DisplayMember = "TEN_NGANH";
            cbnganh.ValueMember = "ID_NGANH";
            cbnganh.DataSource = busTV.LoadNganh(); //lấy thông tin bỏ vô combobox
        }

        private void cbnganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidn.Text = cbnganh.SelectedValue.ToString();
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidk.Text = cbkhoa.SelectedValue.ToString();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Chuyển giá trị lên form
            txtid.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtclass.Text = row.Cells[2].Value.ToString();
            txtidn.Text = row.Cells[3].Value.ToString();
            txtidk.Text = row.Cells[4].Value.ToString();
        }


        private void timerauto_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int id = rdn.Next(1000000000, 2000000000);
            int idk = rdn.Next(1, 13);
            int idn = rdn.Next(1, 49);
            txtid.Text = id.ToString();
            txtidn.Text = idn.ToString();
            txtidk.Text = idk.ToString();
            txtname.Text = "Anonymous";
            txtclass.Text = "17DXXXXX";

            if (txtname.Text != "" && txtclass.Text != "" && txtid.Text != "" && txtidk.Text != "" && txtidn.Text != "")
            {
                DTO_ThanhVien tv = new DTO_ThanhVien(Convert.ToInt32(txtid.Text), txtname.Text, txtclass.Text, Convert.ToInt32(txtidk.Text), Convert.ToInt32(txtidn.Text));

                if (busTV.ThemThanhVien(tv))
                {
                    dataGridView1.DataSource = busTV.GetThanhVien(); // refresh datagridview
                }
                else
                {
                    lberror.Text = "Trùng id";
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ kiện");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                    dataGridView1.AllowUserToAddRows = false;
                    string text = "";
                    for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                    {

                        string[] array = text.Split(new char[] { '|' });
                        dataGridView1.Rows.Add(array);

                    }
                    streamReader.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message);
                }
            }
        }
    }
}
