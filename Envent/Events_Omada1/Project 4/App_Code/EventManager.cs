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

        public override Profile GetProfile(int userID)
        {
            return profile;
        }

        public void CreateEvent(string title, int category, string description, int duration)
        {
            try{
                enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
                ev.createEvent(title, category, description, this.GetUserID(), duration, true);
            }catch(EventException msg)
            {
                MessageBox.Show(msg.ToString());
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
    }
}
