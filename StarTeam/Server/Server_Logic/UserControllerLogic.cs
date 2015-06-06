using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using StarTeam.Models;
using StarTeam.ViewModels;

namespace StarTeam.Server.Server_Logic
{
    public static class UserControllerLogic
    {
        public static UserViewModel IsUserExists(User user)
        {
            var usersCollection = InitMongo.Database.GetCollection<User>("Users");
            var u = usersCollection.AsQueryable<User>().SingleOrDefault(x => x.Id.Equals(user.Id));
            return new UserViewModel(u);
        }
    }
}