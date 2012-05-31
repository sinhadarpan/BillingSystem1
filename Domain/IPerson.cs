using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IPerson : IBaseDomain
    {
        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }

        IAddress Address
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }
               

        string Phone
        {
            get;
            set;
        }

       
    }
}
