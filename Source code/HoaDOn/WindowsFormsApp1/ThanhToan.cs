
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using System.Windows.Forms;
using Cassandra;
using System;
using StackExchange.Redis;
namespace WindowsFormsApp1

{
    public partial class CheckOut : Form
    {
        private IMongoCollection<BsonDocument> Datve;
        private IMongoCollection<BsonDocument> Chuyenxe;
        private ConnectionMultiplexer redis;
        private IDatabase db;

        private IMongoDatabase database;
        private ISession session;
        private Random random;
        public int Total { get; private set; }

        public CheckOut()
        {
            InitializeComponent();
            InitializeRedis();
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            database = client.GetDatabase("DoAn");
            DataUse();
            InitializeCassandra();
            random = new Random();

        }

        private void InitializeCassandra()
        {
            var cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();
            session = cluster.Connect("da");
        }

        private void InitializeRedis()
        {
            redis = ConnectionMultiplexer.Connect("localhost");
            db = redis.GetDatabase();
        }

        private void DataUse()
        {
            idvexe.ReadOnly = true;
            tuyenxe.ReadOnly = true;
            ngaykh.ReadOnly = true;
            ghe.ReadOnly = true;
            idchuyenxe.ReadOnly = true;
            loaive.ReadOnly = true;
            ngayve.ReadOnly = true;
            tongtien.ReadOnly = true;
            vat.ReadOnly = true;
            giave.ReadOnly = true;
        }
        public void FillData(string idVe, string idChuyenXe, string ngayDi, string ghe, string ngayVe, string loaiVe, string giaVe, string hoTen, string soDienThoai, string email,string motachuyenxe)
        {
            idvexe.Text = idVe;
            tuyenxe.Text = motachuyenxe; 
            ngaykh.Text = ngayDi;
            this.ghe.Text = ghe;
            idchuyenxe.Text = idChuyenXe;
            loaive.Text = loaiVe;
            ngayve.Text = ngayVe;
            giave.Text = giaVe;
            hoten.Text = hoTen;
            sdt.Text = soDienThoai;
            this.email.Text = email;
            int giaveInt = int.Parse(giave.Text);
            vat.Text = "0";
            int vatInt = int.Parse(vat.Text);
            int total = giaveInt + vatInt;
            tongtien.Text = total.ToString();
            Total = total;
            xuathd.Visible = false;
            xemhd.Visible = false;
            exit.Visible = false;
        }

            private void InsertCheckOutCass()
        {
            string mave = idvexe.Text;
            string hoTen = hoten.Text;
            string sdtValue = sdt.Text;
            string emailValue = email.Text;
            int soLuongVe = 1;
            int tongTien = Total;
            DateTime ngayThanhToan = DateTime.Now;
            string hinhThucThanhToan = "";
            if (momo.Checked)
            {
                hinhThucThanhToan = "Momo";
            }
            else if (atm.Checked)
            {
                hinhThucThanhToan = "Thẻ atm";
            }
            else if (visa.Checked)
            {
                hinhThucThanhToan = "Thẻ visa";
            }

            var query = $"INSERT INTO ThanhToan (IDThanhToan, soLuongVe, TongTien, Ngaythanhtoan, Hoten, sdt, email, HinhThucThanhToan,mave) " +
                        $"VALUES (uuid(), {soLuongVe}, {tongTien}, '{ngayThanhToan:yyyy-MM-dd}', '{hoTen}', '{sdtValue}', '{emailValue}', '{hinhThucThanhToan}','{mave}')";

            session.Execute(query);
            MessageBox.Show("Thanh toán thành công !!!");

        }

        
        private void InsertMongo()
        {
            string mave = idvexe.Text;
            string hoTen = hoten.Text;
            string sdtValue = sdt.Text;
            string emailValue = email.Text;
           
            Datve = database.GetCollection<BsonDocument>("DatVe");
            var document = new BsonDocument
            {
                { "_id", ObjectId.GenerateNewId() },
                { "VeID", mave },
                { "ChuyenXeID", idchuyenxe.Text },
                { "GheID", ghe.Text },
                { "ThongTinKhachHang", new BsonDocument
                    {
                        { "Hoten", hoTen },
                        { "SDT", sdtValue },
                        { "Email", emailValue }
                    }
                },
                { "LoaiVe", loaive.Text}, 
                { "GiaVe", Total },
                { "TinhTrangVe", "Đã đặt" }, 
                { "NgayKhoiHanh", ngaykh.Text }, 
                { "NgayVe", ngayve.Text }
            };

            Datve.InsertOne(document);

        }

        public void InsertRedis(string mave, string hoTen, string sdtValue, string emailValue, string ngayKhoiHanh, string ngayVe, string loaiVe, int giaVe)
        {
            var hashEntry = new HashEntry[]
            {
                new HashEntry("HoTen", hoTen),
                new HashEntry("SDT", sdtValue),
                new HashEntry("Email", emailValue),
                new HashEntry("NgayKhoiHanh", ngayKhoiHanh),
                new HashEntry("NgayVe", ngayVe),
                new HashEntry("LoaiVe", loaiVe),
                new HashEntry("GiaVe", giaVe)
            };

                db.HashSetAsync(mave, hashEntry);
            }

       


        private void button2_Click(object sender, System.EventArgs e)
        {
      

            if (string.IsNullOrEmpty(hoten.Text) || string.IsNullOrEmpty(sdt.Text) || string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin (Họ tên, SĐT, Email) trước khi thanh toán !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!momo.Checked && !atm.Checked && !visa.Checked)
            {
                MessageBox.Show("Chọn một loại thanh toán trước khi thanh toán !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertCheckOutCass();
            InsertMongo();
            InsertRedis(idvexe.Text, hoten.Text, sdt.Text, this.email.Text, ngaykh.Text, ngayve.Text, loaive.Text, int.Parse(giave.Text));
            thanhtoan.Visible = false;
            xuathd.Visible = true;
            hoten.ReadOnly = true;
            sdt.ReadOnly = true;
            this.email.ReadOnly = true;

        }
        private string GenerateUniqueInvoiceID()
        {
            string idhoadon;
            do
            {
                int randomNumber = random.Next(1000, 10000);
                idhoadon = "HD" + randomNumber.ToString();
            } while (IDHDExists(idhoadon));

            return idhoadon;
        }

        private bool IDHDExists(string idhoadon)
        {
            var query = $"SELECT * FROM HoaDon WHERE idhoadon = '{idhoadon}'";
            var result = session.Execute(query);

            return result.Any();
        }
        private void xuathoadon_Click(object sender, EventArgs e)
        {
           
        }

        private void xemhd_Click(object sender, EventArgs e)
        {
            HoaDon hoaDonForm = new HoaDon();
            hoaDonForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuathd_Click(object sender, EventArgs e)
        {
            string idhoadon = GenerateUniqueInvoiceID();

            string mave = idvexe.Text;
            string hoTen = hoten.Text;
            string sdtValue = sdt.Text;
            string emailValue = email.Text;
            int soLuongVe = 1;
            int tongTien = Total;
            DateTime ngayxhd = DateTime.Now;
            string timestamp = ngayxhd.ToString("yyyy-MM-dd HH:mm:ss");

            var query = $"INSERT INTO HoaDon (idhoadon, email, hoten, mave, ngayxuathd, sdt, soluongve, tongtien) " +
                         $"VALUES ('{idhoadon}', '{emailValue}', '{hoTen}', '{mave}', '{timestamp}', '{sdtValue}', {soLuongVe}, {tongTien})";


            session.Execute(query);

            MessageBox.Show("Xuất hóa đơn thành công !!!");
            xemhd.Visible = true;
            xuathd.Visible = false;
            exit.Visible = true;
        }
    }
}