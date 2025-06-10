using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using BCrypt.Net;

namespace PetShop
{
    internal class MongoDbHelper
    {
        private readonly IMongoDatabase database;
        private const string connectionString = "mongodb://localhost:27017"; 
        private const string databaseName = "pet_shop"; 
        public MongoDbHelper()
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }
    }
}
