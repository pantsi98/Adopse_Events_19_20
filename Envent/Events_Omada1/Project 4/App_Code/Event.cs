using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.User_Classes.Exceptions;

namespace Project_4.User_Classes
{
    public class Event
    {
        private int id;
        private string title;
        private int category;
        private DateTime createdAt;
        private string description;
        private int duration;
        private bool status;
        private string imgurl;
        private int father_cat;
        
        public Event(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
            enventDataSetTableAdapters.categoryTableAdapter catv = new enventDataSetTableAdapters.categoryTableAdapter();
            if(Convert.ToInt32(ev.tryEvent(this.id)) > 0)
            {
                List<enventDataSet.eventsRow> eventDetails = ev.getEvent(this.id).ToList();
                this.title = eventDetails.ElementAt(0).title;
                this.category = eventDetails.ElementAt(0).category_id;
                this.createdAt = eventDetails.ElementAt(0).created_at;
                this.description = eventDetails.ElementAt(0).description;
                this.duration = eventDetails.ElementAt(0).duration;
                this.status = eventDetails.ElementAt(0).active;
                this.imgurl = eventDetails.ElementAt(0).img;
                this.father_cat = (int)ev.getFather(id);
            }
            else
            {
                throw new EventException("To event δεν υπάρχει.");
            }
        }

        public Event(int id, string title, int category, DateTime createdAt, string description, int duration, bool status, string imgurl)
        {
            this.id = id;
            this.title = title;
            this.category = category;
            this.createdAt = createdAt;
            this.description = description;
            this.duration = duration;
            this.status = status;
            this.imgurl = imgurl;
            
           
        }

        public int GetID()
        {
            return id;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetCategory()
        {
            return category;
        }

       

        public DateTime GetCreatedAt()
        {
            return createdAt;
        }

        public string GetDescription()
        {
            return description;
        }

        public int GetDuration()
        {
            return duration;
        }

        public bool GetStatus()
        {
            return status;
        }

        public string GetImage()
        {
            return imgurl;
        }

        public int GetFather()
        {
            return father_cat;
        }
    }
}
