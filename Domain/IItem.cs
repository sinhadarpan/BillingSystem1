using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IItem : IBaseDomain
    {
        ItemType ItemType
        {
            get;
            set;
        }

        int Quantity
        {
            get;
            set;
        }

        Double Price
        {
            get;
            set;
        }

       
    }
}
