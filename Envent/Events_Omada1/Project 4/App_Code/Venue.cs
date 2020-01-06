using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.App_Code.Exceptions;

namespace Project_4.App_Code
{
    class Venue
    {
        private int id;
        private String name;
        private String location;
        private int capacity;
        private static List<String> venues = new List<String>();

        public Venue()
        {
        }

        public Venue(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.venuesTableAdapter ev = new enventDataSetTableAdapters.venuesTableAdapter();
            if (Convert.ToInt32(ev.tryVenue(this.id)) > 0)
            {
                List<enventDataSet.venuesRow> venueDetails = ev.getVenue(this.id).ToList();
                this.name = venueDetails.ElementAt(0).name;
                this.location = venueDetails.ElementAt(0).location;
                this.capacity = venueDetails.ElementAt(0).capacity;
                
            }
            else
            {
                throw new VenueException("Το Venue δεν υπάρχει");
            }
        }
        public int GetId()
        {
            return id;
        }
        public String GetName()
        {
            return name;
        }
        public String GetLocation()
        {
            return location;
        }
        public int GetCapacity()
        {
            return capacity;
        }
        public List<String> getAllVenues()
        {
            enventDataSetTableAdapters.venuesTableAdapter ven = new enventDataSetTableAdapters.venuesTableAdapter();
            List<enventDataSet.venuesRow> res = ven.getAllVenueNames().ToList();
            for(int i=0;i<res.Count; i++)
            {
                String venue = res.ElementAt(i).name;
                venues.Add(venue);
            }
            return venues;

        }
    }
}
