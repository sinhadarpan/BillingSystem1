using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IOrder : IBaseDomain 
    {
        IUser User
        {
            get;
            set;
        }

        Double TotalDiscount
        {
            get;
            set;
        }

        List<IItem> Items
        {
            get;
            set;
        }

        Double Amount
        {
            get;
            set;
        }

    
    }
}
