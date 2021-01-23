using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationStatusTracker.Models
{
    public class Application
    {
        public int ID { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; }
        public string Priority { get; set;
        }
    }
}