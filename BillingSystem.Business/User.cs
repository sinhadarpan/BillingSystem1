using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Domain;

namespace BillingSystem.Business
{
    public class User:Domain.IUser
    {

        public DateTime Doj
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public IAddress Address
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Email
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public IUser CreatedBy
        {
            get;
            set;
        }

        public IUser UpdatedBy
        {
            get;
            set;
        }

        public DateTime CreatedDate
        {
            get;
            set;
        }

        public DateTime UpdatedDate
        {
            get;
            set;
        }

        public bool IsEmployee
        {
            get;
            set;
        }

        public bool IsAffiliate
        {
            get;
            set;
        }
        
        public bool RegisterUser()
        {
            //Todo
            return true;
        }

        
    }
}
