using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Project_4.App_Code.StaticMethods;
//Author Τζέιμς Μπαλάση

namespace Project_4.User_Classes
{
    public abstract class User
    {

        //Abstact μέθοδος διότη θα διαφέρει από Visitor σε NormalUser. Σε εγγεγραμένο χρήστη θα εμφανίζονται events σύμφωνα με τις προτιμήσεις του.
        public abstract void ShowEvents();

        //Abstact μέθοδος διότη θα διαφέρει από Visitor σε NormalUser. Σε εγγεγραμένο χρήστη θα εμφανίζονται και η λειτουργία της κράτησης.
        public abstract void ShowEventDeails(int id);

        //Αρχική μέθοδος του search. Πιθανόν να υπάρξει τροποποίηση για πιο ευφυη αναζήτηση.
        public List<String> SearchForEvent(string keyWord)//παράμετρος οι χαρακτήρες που πληκτρολογή ο χρήστης
        {
            var valid = new Regex(@"^.*" + keyWord + ".*$"); //Δημιουργια regular expression
            List<string> results = new List<string>(); //Εδώ αποθηκεύονται τα αποτελέσματα
            foreach (string i in Events.eventsTitle) //Σάρωση της στατικής κλάσης όπου αποθηκεύονται τα events
            {
                if (valid.IsMatch(i)) //Έλεγχος αν ταιρίαζει η αναζήτηση του χρήστη στο regular expression
                {
                    results.Add(i); //Εισαγώγη στα αποτελέσματα
                }
            }
            return results;
        }
    }
}