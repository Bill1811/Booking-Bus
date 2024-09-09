using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class TraCuuVe : Form
    {
        private ConnectionMultiplexer redis;
        private IDatabase db;
        private IMongoCollection<BsonDocument> DatVe;
        CheckOut thanhToan = new CheckOut();
        public TraCuuVe()
        {
            InitializeComponent();
            InitializeRedis();

            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("DoAn");
            DatVe = database.GetCollection<BsonDocument>("DatVe");
        }

        private void InitializeRedis()
        {
            redis = ConnectionMultiplexer.Connect("localhost");
            db = redis.GetDatabase();
        }
        private string getHash(HashEntry[] hashEntries, string key)
        {
            foreach (var temp in hashEntries)
            {
                if (temp.Name == key)
                {
                    return temp.Value.ToString();
                }
            }

            return null; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mave = txtMaVe.Text; 

            var hashEntries = db.HashGetAll(mave);
            if (hashEntries.Length > 0)
            {
                txtHoTen.Text = getHash(hashEntries, "HoTen");
                txtSDT.Text = getHash(hashEntries, "SDT");
                txtEmail.Text = getHash(hashEntries, "Email");
                txtNgayKhoiHanh.Text = getHash(hashEntries, "NgayKhoiHanh");
                txtNgayVe.Text = getHash(hashEntries, "NgayVe");
                txtLoaiVe.Text = getHash(hashEntries, "LoaiVe");
                txtGiaVe.Text = getHash(hashEntries, "GiaVe");
            }

            //else
            //{
            //    var filter = Builders<BsonDocument>.Filter.Eq("VeID", mave);
            //    var result = datVeCollection.Find(filter).FirstOrDefault();
            //    if (result != null)
            //    {
            //        txtHoTen.Text = result.GetValue("ThongTinKhachHang").AsBsonDocument.GetValue("Hoten").AsString;
            //        txtSDT.Text = result.GetValue("ThongTinKhachHang").AsBsonDocument.GetValue("SDT").AsString;
            //        txtEmail.Text = result.GetValue("ThongTinKhachHang").AsBsonDocument.GetValue("Email").AsString;
            //        txtNgayKhoiHanh.Text = result.GetValue("NgayKhoiHanh").AsString;
            //        txtNgayVe.Text = result.GetValue("NgayVe").AsString;
            //        txtLoaiVe.Text = result.GetValue("LoaiVe").AsString;
            //        txtGiaVe.Text = result.GetValue("GiaVe").AsInt32.ToString();

            //        thanhToan.InsertRedis(mave,
            //                    txtHoTen.Text,
            //                    txtSDT.Text,
            //                    txtEmail.Text,
            //                    txtNgayKhoiHanh.Text,
            //                    txtNgayVe.Text,
            //                    txtLoaiVe.Text,
            //                    int.Parse(txtGiaVe.Text));
            //    }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin vé.");
                }
            }
    }
}
