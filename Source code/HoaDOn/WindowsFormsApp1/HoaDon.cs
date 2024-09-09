using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;

namespace WindowsFormsApp1
{
    public partial class HoaDon : Form
    {
        private ISession _session;
        string query = "SELECT * FROM HoaDon";

        public HoaDon()
        {
            InitializeComponent();
            InitializeCassandra();
            LoadDataGrid();
        }

        private void InitializeCassandra()
        {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1").WithPort(9042)
                .Build();

            _session = cluster.Connect("da");
        }

        private void load_data(Row row)
        {
            string idhoadon = row.GetValue<string>("idhoadon");
            string hoten = row.GetValue<string>("hoten");

            //HashSet<string> mave = row.GetValue<HashSet<string>>("mave");
            //string maveString = string.Join(", ", mave);
            string maveString = row.GetValue<string>("mave");
            int soluongve = row.GetValue<int>("soluongve");
            int tongtien = row.GetValue<int>("tongtien");
            string email = row.GetValue<string>("email");
            DateTimeOffset ngayxuathdOffset = row.GetValue<DateTimeOffset>("ngayxuathd");
            string ngayxuathd = ngayxuathdOffset.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string sdt = row.GetValue<string>("sdt");
          
            dataGrid.Rows.Add(idhoadon, maveString, soluongve, tongtien, ngayxuathd, hoten, sdt, email);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGrid.CurrentRow.Index;
            TextBox[] textBoxes = { txtHD, txtve, slve, tongtien, ngayxuat, hoten, sdt, email };

            for (int j = 0; j < textBoxes.Length; j++)
            {
                textBoxes[j].Text = dataGrid.Rows[i].Cells[j].Value.ToString();
                textBoxes[j].ReadOnly = true;
            }
        }

        private void LoadDataGrid()
        {
            var result = _session.Execute(query);

            var columns = new Dictionary<string, string>
            {
                { "idhoadon", "Mã Hóa Đơn" },
                { "mave", "Mã vé" },
                { "soluongve", "Số lượng vé" },
                { "tongtien", "Tổng tiền" },
                { "ngayxuathd", "Ngày Xuất HĐ" },
                { "hoten", "Họ Tên KH" },
                { "sdt", "SĐT" },
                { "email", "Email" },
            };

            foreach (var column in columns)
            {
                dataGrid.Columns.Add(column.Key, column.Value);
                dataGrid.Columns[column.Key].ReadOnly = true;
            }

            foreach (var row in result)
            {
                load_data(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maHoaDon = tkHĐ.Text;
            var query = $"SELECT * FROM HoaDon WHERE idhoadon = '{maHoaDon}' ALLOW FILTERING";
            var result = _session.Execute(query);
            dataGrid.Rows.Clear();

            foreach (var row in result)
            {
                load_data(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            tkHĐ.Text = "";
            var result = _session.Execute(query);
            foreach (var row in result)
            {
                load_data(row);
            }
            TextBox[] textBoxes = { txtHD, txtve, slve, tongtien, ngayxuat, hoten, sdt, email };

            for (int j = 0; j < textBoxes.Length; j++)
            {
                textBoxes[j].Text ="";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tkHĐ_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
