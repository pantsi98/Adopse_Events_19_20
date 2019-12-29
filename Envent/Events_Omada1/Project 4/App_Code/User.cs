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
}
}
 
 