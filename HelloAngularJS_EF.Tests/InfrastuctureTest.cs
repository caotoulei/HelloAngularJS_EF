using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloAngularJS_EF.Core.Infrastructure.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloAngularJS_EF.Tests
{
    [TestClass]
    public class InfrastuctureTest
    {
        [TestMethod]
        public void UserContext_Get_All_Users()
        {
            MeetUpContext db = new MeetUpContext();
            var users = db.Users.ToList();
            Assert.AreEqual(users[0].Name.LastName, "Zhang");
        }

        [TestMethod]
        public void Save_User()
        {
            MeetUpContext db = new MeetUpContext();
            db.Users.Add(new Core.Domain.Models.User() {
                    ID = Guid.NewGuid(),
                    Username="username1",
                    DisplayName="Speed Racer",
                    Name = new Core.Domain.Models.Name { FirstName = "Speed", LastName="Racer"},
                    Email = "sracer@gmail.com",
                    Contact = "2810001234"
            });
            db.SaveChanges();
        }
    }
    
}

