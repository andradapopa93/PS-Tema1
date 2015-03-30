using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tema1.DAL;
using Tema1.Entities;

namespace Tema1.BL
{
    public class AnnouncementService
    {
        AnnouncementDAL aDal = new AnnouncementDAL();


        public Announcement addAnnouncement(String title, String description, String pictureFile, String type)
        {
            return aDal.addAnnouncement(title, description, pictureFile, type);
        }



        public String deleteAnnouncement(String title, String type)
        {
            return aDal.deleteAnnouncement(title, type);
        }



        public Announcement updateAnnouncement(String title, String description, String pictureFile, String type)
        {
            Announcement a = null;

            a = aDal.updateAnnouncement(title, description, pictureFile, type);

            return a;
        }



        public Announcement searchAnnouncement(String title)
        {
            Announcement a = null;

            a = aDal.selectAnnouncementByTitle(title);

            return a;
        }

    }
}
