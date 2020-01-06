using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.App_Code.StaticMethods;
using Project_4.User_Classes.Exceptions;
using System.Windows.Forms;

namespace Project_4.User_Classes
{
    public class EventManager : RegisteredUser
    {
        ManagerProfile profile;

        public EventManager(string userName, string passWord) : base(userName, passWord)
        {
            profile = new ManagerProfile(userID, true);
        }

        public override Profile GetProfile()
        {
            return profile;
        }

        public void CreateEvent(string title, int category, string description, int duration,string img)
        {
            try{
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                ev.createEvent(title, category, description, this.GetUserID(), duration, true,img);
                
            }catch(EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
        public int CreatePlay(int event_id, int venue_id, DateTime date)
        {
            try
            {
                enventDataSetTableAdapters.playTableAdapter pl = new enventDataSetTableAdapters.playTableAdapter();
                pl.createPlay(event_id, venue_id, date);
                int play_id = pl.getPlayId(event_id, date).Value;
                return play_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }




        public void ChangeEventStatus(int eventID , bool status)
        {
            try
            {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                if (Convert.ToInt32(ev.tryEvent(eventID)) > 0)
                {
                    ev.changeEventsStatus(status, eventID);
                }
                else
                {
                    throw new EventException("Το event δεν υπάρχει.");
                }
            }
            catch (EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        public void UpdateEventTitle(int eventID,string title)
        {
            try
            {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                if (Convert.ToInt32(ev.tryEvent(eventID)) > 0)
                {
                    ev.updateTitle(title, eventID);
                }
                else
                {
                    throw new EventException("Το event δεν υπάρχει.");
                }

            }
            catch (EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        public void UpdateEventCategory(int eventID, int category)
        {
            try
            {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                if (Convert.ToInt32(ev.tryEvent(eventID)) > 0)
                {
                    ev.updateCategory(category, eventID);
                }
                else
                {
                    throw new EventException("Το event δεν υπάρχει.");
                }

            }
            catch (EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        public void UpdateEventDuration(int eventID, int duration)
        {
            try
            {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                if (Convert.ToInt32(ev.tryEvent(eventID)) > 0)
                {
                    ev.updateDuration(duration, eventID);
                }
                else
                {
                    throw new EventException("Το event δεν υπάρχει.");
                }

            }
            catch (EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        public void UpdateEventDescription(int eventID, string description)
        {
            try
            {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                if (Convert.ToInt32(ev.tryEvent(eventID)) > 0)
                {
                    ev.updateDescription(description, eventID);
                }
                else
                {
                    throw new EventException("Το event δεν υπάρχει.");
                }

            }
            catch (EventException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        public int GetEventIdByTtitle(string title)
        {
            try {
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                int id = ev.getIdFromTitle(title).Value;
                return id;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
