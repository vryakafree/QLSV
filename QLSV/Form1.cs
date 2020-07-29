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
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txtname.Text != "" && txtid.Text != "" && txtclass.Text != "" && txtidk.Text != "" && txtidn.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    // Tạo DTo
                    DTO_ThanhVien tv = new DTO_ThanhVien(Convert.ToInt32(txtid.Text), txtname.Text, txtclass.Text, Convert.ToInt32(txtidk.Text), Convert.ToInt32(txtidn.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busTV.SuaThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busTV.GetThanhVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
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

        private void txtidn_TextChanged(object sender, EventArgs e)
        {
            
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
    }
}
