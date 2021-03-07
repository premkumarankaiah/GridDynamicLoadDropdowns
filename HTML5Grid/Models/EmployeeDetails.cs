using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML5Grid.Models
{
    public class EmployeeDetails
    {
        //Consolidated model with main data and dropdown value data
        public List<JobDetails> JobDetails { get; set; }
        public List<JobFamilies> JobFamilies { get; set; }
    }
}