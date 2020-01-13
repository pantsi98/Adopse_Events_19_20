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
        private string telephone;
        private string city;

        static enventDataSetTableAdapters.venuesTableAdapter venueAdapter= new enventDataSetTableAdapters.venuesTableAdapter();
        static List<enventDataSet.venuesRow> venueList = new List<enventDataSet.venuesRow>();
        public static List<Venue> venues = new List<Venue>();

        public Venue()
        {
        }

        public Venue(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.venuesTableAdapter ev = new enventDataSetTableAdapters.venuesTableAdapter();
                List<enventDataSet.venuesRow> venueDetails = ev.getVenue(this.id).ToList();
                this.name = venueDetails.ElementAt(0).name;
                this.location = venueDetails.ElementAt(0).location;
                this.capacity = venueDetails.ElementAt(0).capacity;
        }

        public Venue(int id, string name, string location, int capacity,string telephone, string city)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.capacity = capacity;
            this.telephone = telephone;
            this.city = city;
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

        public static void FillVenuesData()
        {
            venueList = venueAdapter.GetVenues().ToList();
            for (int i = 0; i < venueList.Count; i++)
            {
                Venue venueItem = new Venue(venueList.ElementAt(i).id, venueList.ElementAt(i).name, venueList.ElementAt(i).location, venueList.ElementAt(i).capacity, venueList.ElementAt(i).tel, venueList.ElementAt(i).city);
                venues.Add(venueItem);
            }
        }

        public string GetCity()
        {
            return this.city;
        }
    }
}
