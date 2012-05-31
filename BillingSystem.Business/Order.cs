using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillingSystem.Domain;

namespace BillingSystem.Business
{
    public class Order:BillingSystem.Domain.IOrder
    {
        public Domain.IUser User
        {
            get;
            set;
        }

        public double TotalDiscount
        {
            get;
            set;
        }

        public List<Domain.IItem> Items
        {
            get;
            set;
        }

        public double Amount
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public Domain.IUser CreatedBy
        {
            get;
            set;
        }

        public Domain.IUser UpdatedBy
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

        public void Create()
        {
            calculateDiscount();

        }
        protected SortedList<Domain.IItem, double> itemDiscount
        {
            get;
            set;
        }

        private void calculateDiscount()
        {
            Business.Discounts discounts = new Business.Discounts();
            foreach (Domain.IItem i in this.Items)
            {
                this.Amount += i.Price;
                
                double amount = discounts.PercentageDiscount(i, this.User);
                itemDiscount = new SortedList<IItem, double>();
                itemDiscount.Add(i,amount);
                this.TotalDiscount += amount;
            }

            this.Amount = this.Amount - this.TotalDiscount;
            double billDiscount = discounts.BillAmountDiscount(this);
            this.Amount = this.Amount - billDiscount ;
            this.TotalDiscount += billDiscount;


        }
    }
}
