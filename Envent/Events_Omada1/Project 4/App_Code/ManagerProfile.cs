using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes
{
    public class ManagerProfile : Profile
    {
        string iban;
        public ManagerProfile(int userID,bool admin) : base(userID,admin)
        {
            enventDataSetTableAdapters.adminTableAdapter pro = new enventDataSetTableAdapters.adminTableAdapter();
            List<enventDataSet.adminRow> results = pro.getProfile(userID).ToList();
            this.iban = results.ElementAt(0).iban;
        }
       

        public override void UpdateAddress(int id, string address)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updateAddress(address, id);
        }

        public override void UpdateEmail(int id, string email)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updateEmail(email, id);
        }

        public override void UpdateFirstName(int id, string fname)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updateFirstName(fname, id);
        }

        public override void UpdateLastName(int id, string lname)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updateLastName(lname, id);
        }

        public override void UpdatePassword(int id, string password)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updatePassword(password, id);
        }

        public override void UpdateUserName(int id, string userName)
        {
            enventDataSetTableAdapters.adminTableAdapter up = new enventDataSetTableAdapters.adminTableAdapter();
            up.updateUserName(userName, id);
        }

        public string GetIban()
        {
            return iban;
        }

    }
}
