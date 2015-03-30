using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Entities
{
    public class User
    {
        private String username;
        private String password;
        private String role;
        private String name;
        private int numberAnnouncements;


        public User(String user, String pass, String role, String name, int nb)
        {
            this.username = user;
            this.password = pass;
            this.role = role;
            this.name = name;
            this.numberAnnouncements = nb;
        }

        public void setPassword(String pass)
        {
            this.password = pass;
        }

        public String getPassword()
        {
            return this.password;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getUsername()
        {
            return this.username;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setRol(String role)
        {
            this.role = role;
        }

        public String getRole()
        {
            return this.role;
        }

        public int getNumberOfAnnouncements()
        {
            return this.numberAnnouncements;
        }

    }
}
