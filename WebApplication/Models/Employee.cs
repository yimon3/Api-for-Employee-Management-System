using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        public string employeeName { get; set; }

        public string department { get; set; }

        public DateTime joining_date { get; set; }

        public string upload_image { get; set; }
    }
}
