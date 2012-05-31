using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Business
{
    public class ITems:BillingSystem.Domain.IItem
    {
        public Domain.ItemType ItemType
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public double Price
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
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Domain.IUser UpdatedBy
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

        public DateTime CreatedDate
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

        public DateTime UpdatedDate
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
    }
}
