using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Project_4.App_Code.StaticMethods;
using Project_4.App_Code;
//Author Τζέιμς Μπαλάση

namespace Project_4.User_Classes
{
    public abstract class User
    {

        //Abstact μέθοδος διότη θα διαφέρει από Visitor σε NormalUser. Σε εγγεγραμένο χρήστη θα εμφανίζονται events σύμφωνα με τις προτιμήσεις του.
        public abstract List<Event> ShowEvents();

        //Abstact μέθοδος διότη θα διαφέρει από Visitor σε NormalUser. Σε εγγεγραμένο χρήστη θα εμφανίζονται και η λειτουργία της κράτησης.
        public abstract void ShowEventDeails(int id);

        //Αρχική μέθοδος του search. Πιθανόν να υπάρξει τροποποίηση για πιο ευφυη αναζήτηση.
        public List<Event> SearchForEvent(string keyWord)//παράμετρος οι χαρακτήρες που πληκτρολογή ο χρήστης
        {
            var valid = new Regex(@"^.*" + keyWord + ".*$"); //Δημιουργια regular expression
            List<Event> results = new List<Event>(); //Εδώ αποθηκεύονται τα αποτελέσματα
            foreach (Event i in Events.events) //Σάρωση της στατικής κλάσης όπου αποθηκεύονται τα events
            {
                if (valid.IsMatch(i.GetTitle())) //Έλεγχος αν ταιρίαζει η αναζήτηση του χρήστη στο regular expression
                {
                    results.Add(i); //Εισαγώγη στα αποτελέσματα
                }
            }
            return results;
        }

        public List<Event> FilterSearch(string keyword, int catid,DateTime pick1 , DateTime pick2,string city)
        {
            List<int> playsVenue = new List<int>();
            List<int> eventsPlays = new List<int>();
            List<Event> results = this.SearchForEvent(keyword);
            results = results.FindAll(x => x.GetCategory() == catid);
            playsVenue = Venue.venues.FindAll(x => x.GetCity() == city).Select(l => l.GetId()).ToList();
            eventsPlays = App_Code.Play.plays.FindAll(x => (DateTime.Compare(x.getDates(),pick2)<= 0) && !eventsPlays.Contains(x.GetEventID())).Select(l => l.GetEventID()).ToList();
            
            if (!eventsPlays.Any())
            {
                foreach (int i in App_Code.Play.plays.FindAll(x => (DateTime.Compare(x.getDates(), pick1) >= 0) && !eventsPlays.Contains(x.GetEventID())).Select(l => l.GetEventID()).ToList())
                {
                    eventsPlays.Remove(i);
                }
            }

            foreach (int i in App_Code.Play.plays.FindAll(x => !playsVenue.Contains(x.GetVenueID())).Select(l => l.GetEventID()).ToList())
            {
                eventsPlays.Remove(i);
            }

            results = results.FindAll(x => eventsPlays.Contains(x.GetID()));
            return results;
        }
    }
}
 
 