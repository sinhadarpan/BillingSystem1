using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BillingSystem.Business;
using BillingSystem.Domain;


namespace BillingSystem.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrders()
        {
           //shd give 5% dis of doj = 50
            //5$ dis = 950 = 45
            BillingSystem.Business.User user = new User()
            {
                Doj = new DateTime(2008, 1, 1),
                FirstName = "Darpan",
                LastName = "Sinha",
                IsAffiliate = false,
                IsEmployee = false
            };

            BillingSystem.Business.Order order = new Business.Order();

            order.User = user;

            order.Items = new List<IItem>();

            order.Items.Add(new BillingSystem.Business.ITems() { ItemType = BillingSystem.Domain.ItemType.Others, Price = 1000, Quantity = 1 });

            order.Create();
            
        }

        [TestMethod]
        public void TestOrders_Employee()
        {
            //Doj Dis = 0
            //Emp dis = 30%
            //5$ dis = 700 = 45
            BillingSystem.Business.User user = new User()
            {
                Doj = new DateTime(2012, 1, 1),
                FirstName = "Darpan",
                LastName = "Sinha",
                IsAffiliate = false,
                IsEmployee = true
            };

            BillingSystem.Business.Order order = new Business.Order();

            order.User = user;

            order.Items = new List<IItem>();

            order.Items.Add(new BillingSystem.Business.ITems() { ItemType = BillingSystem.Domain.ItemType.Others, Price = 1000, Quantity = 1 });

            order.Create();

        }

        [TestMethod]
        public void TestOrders_Groceries()
        {
            
            BillingSystem.Business.User user = new User()
            {
                Doj = new DateTime(2012, 1, 1),
                FirstName = "Darpan",
                LastName = "Sinha",
                IsAffiliate = false,
                IsEmployee = true
            };

            BillingSystem.Business.Order order = new Business.Order();

            order.User = user;

            order.Items = new List<IItem>();

            order.Items.Add(new BillingSystem.Business.ITems() { ItemType = BillingSystem.Domain.ItemType.Groceries, Price = 1000, Quantity = 1 });

            order.Create();

        }

        
    }
}
