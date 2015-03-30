using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tema1.DAL;
using Tema1.Entities;

namespace Tema1.BL
{
    public class UserService
    {
        UserDAL userDal = new UserDAL();



        public User login(String user, String pass)
        {
            return userDal.getUser(user, getMd5Hash(pass));
        }



        private string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }



        public User addAccount(String name, String username, String password, String role)
        {
            return userDal.addUser(name, username, getMd5Hash(password), role);
        }



        public String deleteAccount(String name, String username)
        {
            return userDal.deleteUser(name, username);
        }



        public User updateAccount(String username, String name, String password, String role)
        {
            User u = null;

            if (String.Compare(password, "") != 0)
                u = userDal.updateUser(username, name, getMd5Hash(password), role);
            else
                u = userDal.updateUser(username, name, password, role);

            return u;
        }



        public User searchUser(String name)
        {
            User u = null;

            u = userDal.selectUserByName(name);

            return u;
        }

        public String updateNumberOfUserAnnouncements(String username)
        {
            return userDal.updateNumberOfUserAnnouncements(username);
        }
    }
}
