using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IAddress : IBaseDomain
    {


        string AddressLine1
        {
            get;
            set;
        }

        string AddressLine2
        {
            get;
            set;
        }

        string City
        {
            get;
            set;
        }

        string State
        {
            get;
            set;
        }

        string Country
        {
            get;
            set;
        }

        string PinCode
        {
            get;
            set;
        }

        AddressType AddressType
        {
            get;
            set;
        }
               
       
    }
}
