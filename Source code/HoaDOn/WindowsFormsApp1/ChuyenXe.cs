using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using System.Windows.Forms;
using Cassandra;
using System;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1
{
    class ChuyenXe
    {
        [BsonId]
        public Object Id { get; set; }

        [BsonElement("VeID")]
        public int VeID { get; set; }
        [BsonElement("ChuyenXeID")]
        public int ChuyenXeID { get; set; }
        [BsonElement("GiaVe")]
        public int GiaVe { get; set; }
        [BsonElement("NgayDi")]
        public DateTime NgayDi { get; set; }

        [BsonElement("NgayVe")]
        public DateTime? NgayVe { get; set; }

        [BsonElement("MoTa")]
        public string MoTa { get; set; }

        public ChuyenXe(int veid, int chuyenxeid, int giave, DateTime ngaydi, DateTime ngayve, string mota)
        { 
            VeID = veid;
            ChuyenXeID = chuyenxeid;
            GiaVe = giave;
            NgayDi = ngaydi;
            NgayVe = ngayve;
            MoTa = mota;
        }
    }
}
