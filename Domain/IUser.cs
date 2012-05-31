using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IUser : IPerson, IBaseDomain
    {
        DateTime Doj
        {
            get;
            set;
        }

        bool IsEmployee
        {
            get;
            set;
        }

        bool IsAffiliate 
        {
            get;
            set;
        }
               
    }
}
