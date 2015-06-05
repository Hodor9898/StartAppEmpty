using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using StarTeam.Models.Enums;
using StarTeam.Models;
using StarTeam.Models.Enums;

namespace StarTeam.Models
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
        public List<Project> Projects { get; set; }
        public DateTime DateJoined { get; set; }
    }
}