using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using System.Windows.Forms;
using Cassandra;
using System;
using System.Collections.Generic;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");
        static IMongoDatabase db = client.GetDatabase("DoAn");
        static IMongoCollection<ChuyenXe> collection1 = db.GetCollection<ChuyenXe>("ChuyenXe");


        public string  Mota{ get; private set; }
        List<ChuyenXe> listCX = collection1.AsQueryable().ToList<ChuyenXe>();
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;
            comboBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void ReadAllDocuments()
        {
            dataGridView1.DataSource = listCX;
            dataGridView1.ReadOnly = true;
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value != null)
            {
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
                textBox8.Text = "";
            }
            mota.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string motacx = mota.Text;
            Mota = motacx;
            label6.Visible = true;
            comboBox2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ReadAllDocuments();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var gheID = comboBox2.Text;
            var chuyenxeID = textBox2.Text;
            var datVeCollection = db.GetCollection<BsonDocument>("DatVe");
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("GheID", gheID),
                Builders<BsonDocument>.Filter.Eq("ChuyenXeID", chuyenxeID)
            );
            var result = datVeCollection.Find(filter).Any();

           
            if (string.IsNullOrEmpty(hoten.Text) || string.IsNullOrEmpty(sdt.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(comboBox1.Text)|| string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin (Họ tên, SĐT, Email,Ghế,Loại Vé) trước khi đặt vé !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result)
            {

                MessageBox.Show("Ghế đã có người đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox2.Text = ""; 

            }
            else
            {
                CheckOut checkoutForm = new CheckOut();
                checkoutForm.FillData(textBox1.Text, textBox2.Text, textBox7.Text, comboBox2.Text, textBox8.Text, comboBox1.Text, textBox4.Text, hoten.Text, sdt.Text, email.Text, Mota);
                checkoutForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraCuuVe tracuuve = new TraCuuVe();
            tracuuve.Show();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ChuyenXe> motchieu = new List<ChuyenXe>();
            List<ChuyenXe> khuhoi = new List<ChuyenXe>();

            if (comboBox1.Text == "Một chiều")
            {
                foreach (var cx in listCX)
                {
                    if (cx.NgayVe == null)
                    {
                        motchieu.Add(cx);
                    }
                }


                dataGridView1.DataSource = motchieu;
            }
            else if (comboBox1.Text == "Khứ hồi")
            {
                foreach (var cx in listCX)
                {
                    if (cx.NgayVe != null)
                    {
                        khuhoi.Add(cx);
                    }
                }

                dataGridView1.DataSource = khuhoi;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


    }
}