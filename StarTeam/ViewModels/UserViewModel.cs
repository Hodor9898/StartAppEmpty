using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarTeam.Models;
using StarTeam.Models.Enums;

namespace StarTeam.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            Gender = user.Gender;
            County = user.County;
            Email = user.Email;
            Photo = user.Photo;
            Expertise = user.Expertise;
            Projects = user.Projects;
            DateJoined = user.DateJoined;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public GenderType Gender { get; set; }
        public CountryType County { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public UserExpertiseType Expertise { get; set; }
        public List<Project> Projects { get; set; }
        public DateTime DateJoined { get; set; }
    }
}