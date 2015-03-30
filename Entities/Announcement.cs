using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Entities
{
    public class Announcement
    {
        private String title;
        private String description;
        private String type;
        private String pictureFileName;

        
        public Announcement(String title, String description, String type)
        {
            this.title = title;
            this.description = description;
            this.type = type;
        }


        public String Title
        {
            get { return title; }
            set { title = value; }
        }


        public String Description
        {
            get { return description; }
            set { description = value; }
        }


        public String Type
        {
            get { return type; }
            set { type = value; }
        }


        public String PictureFileName
        {
            get { return pictureFileName; }
            set { pictureFileName = value; }
        }

    }
}
