using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ReservationTests
    {
        [TestMethod()]
        public void CanBeCancelledTestByAdmin()
        {
            User user = new User();
            user.isadmin = true;
            Reservation rev = new Reservation();
            var result  = rev.CanBeCancelled(user);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CanBeCancelledByBookedUser()
        {
           Reservation rev = new Reservation();
            User user = new User();
            rev.MadeBy=user;
            var result = rev.MadeBy;
            var final = rev.CanBeCancelled(result);
            Assert.IsTrue(final);
        }
        [TestMethod()]
        public void CanBecancelledByOtherUser()
        {
            Reservation rev = new Reservation();
            rev.CanBeCancelled(new User());
        }
    }
}