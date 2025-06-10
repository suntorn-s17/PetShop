using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    [BsonIgnoreExtraElements]
    internal class UserMaster
    {
        public ObjectId Id { get; set; }
        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("first_name")]
        public string FirstName { get; set; }
        [BsonElement("last_name")]
        public string LastName { get; set; }
    }
}
