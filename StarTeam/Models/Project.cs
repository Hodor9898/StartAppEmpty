using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using StarTeam.Models;
using StarTeam.Models.Enums;

namespace StarTeam.Models
{
    public class Project
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public List<User> Admins { get; set; }
        public List<User> Members { get; set; }
        public DateTime DateCreated { get; set; }
        public ProjectStatusType Status { get; set; }
    }
}