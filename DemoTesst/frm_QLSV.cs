using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTesst
{
    public partial class frm_QLSV : Form
    {
        string sql;
        Lopdungchung g = new Lopdungchung();
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string[] sv = { txt_msv.Text, txt_tensv.Text, txt_tenk.Text };
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_them":
                  sql = string.Format("Insert into SINHVIEN " +
                                      "values ('{0}',N'{1}','{2}')",sv);
                    break;
                case "btn_sua":
                    sql = string.Format("update SINHVIEN " +
                                        "Set HOTEN = N'{1}' , TENK = N'{2}' " +
                                        "Where MSSV =  '{0}'", sv);
                    break;
                case "btn_xoa":
                    sql = string.Format("Delete from SINHVIEN Where MSSV =  '{0}'", sv[0]);
                    break;
                case "btn_thoat":
                    DialogResult rs = MessageBox.Show("Bạn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                        Application.Exit();
                    break;

            }
            if (btn.Name != "btn_thoat")
            {
                if (g.ExecuteUpdate(sql))
                {
                    MessageBox.Show("Thành công");
                    sql = "Select * From SINHVIEN";
                    gv_sv.DataSource = g.ExecuteQuery(sql);
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            sql = "Select * From KHOA";
            lb_Khoa.DataSource = g.ExecuteQuery(sql);
            lb_Khoa.DisplayMember = "TENK";
            lb_Khoa.ValueMember = "TENK";
            sql = "Select * From SINHVIEN";
            gv_sv.DataSource = g.ExecuteQuery(sql) ;
        }

        private void lb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = lb_Khoa.SelectedValue.ToString();
            sql = string.Format("Select * From SINHVIEN Where TENK = N'{0}'",value);
            gv_sv.DataSource = g.ExecuteQuery(sql);
        }

        private void gv_sv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_msv.Text = gv_sv.CurrentRow.Cells["MSSV"].Value.ToString();
            txt_tensv.Text = gv_sv.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_tenk.Text = gv_sv.CurrentRow.Cells["TENK"].Value.ToString();
        }
    }
}
