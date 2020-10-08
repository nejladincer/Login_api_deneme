using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekabet_login.Domain.Models
{
    public class User
    {
        [BsonId]
        public ObjectId _id  { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        [BsonElement("Kisi_adi")]
        public string Kisi_adi { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Okuma_yetki")]
        public string[] Okuma_yetki  { get; set; }

        [BsonElement("Yazma_yetki")]
        public string[] Yazma_yetki { get; set; }
        
        [BsonElement("Yetki")]
        public string Yetki { get; set; }

        [BsonElement("RefreshToken")]
        public string RefreshToken { get; set; }

        [BsonElement("RefreshTokenEndDate")]
        public DateTime? RefreshTokenEndDate { get; set; }
        
    }
}
