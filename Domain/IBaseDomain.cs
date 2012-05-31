using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.Domain
{
    public interface IBaseDomain
    {
        int Id{get;set;}

        IUser CreatedBy{get;set;}
        IUser UpdatedBy{get;set;}

        DateTime CreatedDate{get;set;}
        DateTime UpdatedDate{get;set;}


       
    }
}
