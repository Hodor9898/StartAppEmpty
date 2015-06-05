using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarTeam.Models;
using StarTeam.Models.Enums;

namespace StarTeam.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(Project project)
        {
            Name = project.Name;
            Photo = project.Photo;
            Description = project.Description;
            Admins = project.Admins;
            Members = project.Members;
            DateCreated = project.DateCreated;
            Status = project.Status;
        }

        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public List<User> Admins { get; set; }
        public List<User> Members { get; set; }
        public DateTime DateCreated { get; set; }
        public ProjectStatusType Status { get; set; }

    }
}