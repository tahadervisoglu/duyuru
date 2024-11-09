using System.Collections.Generic;
using System.Linq;

namespace Homework1.Models
{
    public static class Repository
    {
        private static List<Announcement> announcements = new();

        static Repository()
        {
            announcements.Add(new Announcement()
            {
                Id = 1,
                Title = "Artificial Intelligence Academic Thesis Program Begins",
                Text = "The program aims to increase competencies in the field of artificial intelligence in the defense industry...",
                ResponsiblePerson = "Alican",
                CreatedTime = DateTime.UtcNow,
            });
            announcements.Add(new Announcement()
            {
                Id = 2,
                Title = "2209-A - University Students Research Projects Support Program Call",
                Text = "2209-A University Students Research Projects Support Program 2024 1st semester call is open for application...",
                ResponsiblePerson = "Nurcan",
                CreatedTime = DateTime.UtcNow,
            });
            announcements.Add(new Announcement()
            {
                Id = 3,
                Title = "4001 National and International Competition/Event Participation Support 2nd Call",
                Text = "The 2nd call for 4001 National and International Competition/Event Participation Support...",
                ResponsiblePerson = "Gülcan",
                CreatedTime = DateTime.UtcNow,
            });
            announcements.Add(new Announcement()
            {
                Id = 4,
                Title = "Adaptation to University Life Program",
                Text = "An orientation program has been organized for our new students...",
                ResponsiblePerson = "Mehmetcan",
                CreatedTime = DateTime.UtcNow,
            });
        }

        public static List<Announcement> Announcements
        {
            get { return announcements; }
        }

        public static void Add(Announcement anno)
        {
            anno.Id = announcements.Count + 1;
            announcements.Add(anno);
        }


        public static Announcement? GetById(int id)
        {
            return announcements.FirstOrDefault(anno => anno.Id == id);
        }
    }
}
