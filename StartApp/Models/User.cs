using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using StarTeamApp.Models.Enums;

namespace StarTeamApp.Models
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public GenderType Gender { get; set; }
        public CountryType County { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public UserExpertiseType Expertise { get; set; }
        public IEnumerable<List<Project>> Projects { get; set; }
        public DateTime DateJoined { get; set; }
    }
}