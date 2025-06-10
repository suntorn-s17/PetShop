using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Model
{
    internal class Login
    {
        private static MongoDbHelper dbHelper = new MongoDbHelper();
        public string Username { get; set; }
        public string Password { get; set; }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool Authenticate()
        {
            if (!IsValid())
            {
                return false;
            }
            var collection = dbHelper.GetCollection<UserMaster>("user_master");
            var user = collection.Find(u => u.Username == Username).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("User not found.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return BCrypt.Net.BCrypt.Verify(Password, user.Password);
        }
    }
}
