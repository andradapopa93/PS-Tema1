using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Entities;

namespace Tema1.DAL
{
    public class AnnouncementDAL
    {
        //private static AnnouncementDAL _announcementDAL = null;
        private String connectionString;       
        MySqlConnection conn = null;


        public AnnouncementDAL()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "announcement");
            conn = new MySqlConnection(connectionString);            
        }


        public Announcement selectAnnouncementByTitle(String title)
        {
            Announcement a = null;
            String sql = "SELECT * FROM announcements WHERE title='" + title + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    a = new Announcement(reader["title"].ToString(), reader["description"].ToString(), reader["type"].ToString());
                else
                    a = null;
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return a;
        }



        public Announcement addAnnouncement(String title, String description, String nameOfPictureFile, String type)
        {
            String sql = "INSERT INTO `announcements`(`title`, `description`, `picture`, `type`) VALUES ('" + title + "', '" + description + "', '" + nameOfPictureFile + "', '" + type + "')";
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

            Announcement a = null;
            a = selectAnnouncementByTitle(title);

            if (a == null)
                return null;
            else
                return a;

        }



        public String deleteAnnouncement(String title, String type)
        {
            Announcement a = null;
            a = selectAnnouncementByTitle(title);

            if (a == null)
                return null;
            else
            {
                if (String.Compare(a.Type, type) != 0)
                    return null;
                else
                {
                    String sql = "DELETE FROM `announcements`WHERE `title`='" + title + "' AND `type`='"+ type + "'";
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



        public Announcement updateAnnouncement(String title, String description, String pictureFile, String type)
        {
            Announcement a = null;
            a = selectAnnouncementByTitle(title);

            if (a == null)
                return null;
            else
            {
                // daca nu se introduce o valoare noua pentru unul din campuri, pastrez vechea valoare

                if (String.Compare(description, "") == 0)
                    description = a.Description;

                if (String.Compare(pictureFile, "") == 0)
                    pictureFile = a.PictureFileName;

                if (String.Compare(type, "") == 0)
                    type = a.Type;

                String sql = "UPDATE `announcements` SET `description`='" + description + "', `picture`= '" + pictureFile + "', `type`= '" + type + "' WHERE `title`= '" + title + "'";
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

                return a;
            }
        }

    }
}
