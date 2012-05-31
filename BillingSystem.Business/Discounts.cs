using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Business
{
    public class Discounts
    {
        private readonly int BillDiscount = 5;
        private readonly int EmployeeDiscount = 30;
        private readonly int AffiliateDiscount = 10;
        private readonly int DojDiscount = 5;

        public enum DiscountType
        {
            Employee,
            Affiliate,
            Years
        }

        private int GetDiscountPercentage(Domain.IUser user)
        {
            if (user.IsEmployee == true)
            {
                return EmployeeDiscount;
            }
            else if (user.IsAffiliate == true)
            {
                return AffiliateDiscount;
            }
            else if (!(user.Doj.Date.AddYears(2) > DateTime.Now))
            {
                return DojDiscount;
            }
            else
            {
                return 0;
            }
        }

        public double BillAmountDiscount(Domain.IOrder order)
        {
            if (order.Amount >= 100)
            {
                int amountForDiscount = (int)(order.Amount) / 100; // check for Divison exception
                return amountForDiscount * BillDiscount;
            }
            else
            {
                return 0;
            }

        }

        private bool isAplicablePercentageBase(Domain.IItem item)
        {
            
            if (item.ItemType != Domain.ItemType.Groceries)
                return true;
            else
                return false;
                
        }

        public double PercentageDiscount(Domain.IItem item,Domain.IUser user)
        {

            if (isAplicablePercentageBase(item))
            {
                int amt = GetDiscountPercentage(user);

                return item.Price * amt / 100;
            }
            else
                return 0;
        }

        

        

    }
    
}
