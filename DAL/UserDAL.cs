using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Entities;

namespace Tema1.DAL
{
    public class UserDAL
    {
         //private static UserDAL _usersDAL = null;
         private String connectionString;       
         MySqlConnection conn = null;

        public UserDAL()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "announcement");
            conn = new MySqlConnection(connectionString);            
        }


        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["role"].ToString(), reader["name"].ToString(), reader.GetInt32(5));
                else
                    u = null;
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }


        public User selectUserByName(String name)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE name='" + name + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["role"].ToString(), reader["name"].ToString(), reader.GetInt32(5));
                else
                    u = null;
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }


        public User selectUserByUsername(String username)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["role"].ToString(), reader["name"].ToString(), reader.GetInt32(5));
                else
                    u = null;
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }




        public User addUser(String name, String username, String password, String role)
        {
            String sql = "INSERT INTO `users`(`name`, `username`, `password`, `role`) VALUES ('" + name + "', '" + username + "', '" + password + "', '" + role + "')";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }

            User u = null;
            u = selectUserByName(name);

            if (u == null)
                return null;
            else
                return u;

        }


        public String deleteUser(String name, String username)
        {
            User u = null;
            u = selectUserByName(name);

            if (u == null)
                return null;
            else
            {
                if (String.Compare(u.getUsername(), username) != 0)
                    return null;
                else
                {
                    String sql = "DELETE FROM `users`WHERE `name`='" + name + "' AND `username`= '" + username + "'";
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (MySqlException e)
                    {
                        Console.WriteLine(e.Message);
                        conn.Close();
                    }
                    return "OK";
                }
            }
        }


        public User updateUser(String username, String name, String password, String role)
        {
            User u = null;
            u = selectUserByUsername(username);

            if (u == null)
                return null;
            else
            {
                // daca nu se introduce o valoare noua pentru unul din campuri, pastrez vechea valoare

                if (String.Compare(name, "") == 0)
                    name = u.getName();

                if (String.Compare(password, "") == 0)
                    password = u.getPassword();

                if (String.Compare(role, "") == 0)
                    role = u.getRole();

                String sql = "UPDATE `users` SET `name`='" + name + "', `password`= '" + password + "', `role`= '" + role + "' WHERE `username`= '" + username + "'";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    conn.Close();
                    return null;
                }

                return u;
            }
        }


        public String updateNumberOfUserAnnouncements(String username)
        {
            User u = null;
            u = selectUserByUsername(username);

            if (u == null)
                return null;
            else
            {
                int newValue = u.getNumberOfAnnouncements() + 1;
                String sql = "UPDATE `users` SET `numberAnnouncements`='" + newValue + "' WHERE `username`= '" + username + "'";
                
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                    conn.Close();
                    return null;
                }

                return "OK";
            }
        }


    }
}
