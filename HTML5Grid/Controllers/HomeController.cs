using HTML5Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML5Grid.Controllers
{
    public class HomeController : Controller
    {
        //Popuate the model data.
        static List<JobDetails> jobDetails = new List<JobDetails>()
        {
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 1", JobCode="Job 1 Code 1", EmployeeId="123455", EmployeeName="123455"},
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 1", JobCode="Job 1 Code 1", EmployeeId="123456", EmployeeName="123456"},
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 1", JobCode="Job 1 Code 2", EmployeeId="123457", EmployeeName="123457"},
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 2", JobCode="Job 2 Code 11", EmployeeId="123450", EmployeeName="123450"},
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 2", JobCode="Job 2 Code 22", EmployeeId="123451", EmployeeName="123451"},
            new JobDetails(){JobFamily="Family 1", JobData="Fam 1 Job 2", JobCode="Job 2 Code 22", EmployeeId="123452", EmployeeName="123452"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 11", JobCode="Job 11 Code 11", EmployeeId="1234555", EmployeeName="1234555"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 11", JobCode="Job 11 Code 11", EmployeeId="1234566", EmployeeName="1234566"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 11", JobCode="Job 11 Code 22", EmployeeId="1234577", EmployeeName="1234577"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 22", JobCode="Job 22 Code 111", EmployeeId="1234500", EmployeeName="1234500"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 22", JobCode="Job 22 Code 222", EmployeeId="1234511", EmployeeName="1234511"},
            new JobDetails(){JobFamily="Family 2", JobData="Fam 2 Job 22", JobCode="Job 22 Code 222", EmployeeId="1234522", EmployeeName="1234522"}
        };

        static List<JobFamilies> jobFamilies = new List<JobFamilies>()
        {
            new JobFamilies(){Id=1, JobFamily = "Family 1"},
            new JobFamilies(){Id=2, JobFamily = "Family 2"},
            new JobFamilies(){Id=2, JobFamily = "Family 3"}
        };

        EmployeeDetails employeeDetails = new EmployeeDetails() { JobDetails = jobDetails, JobFamilies = jobFamilies };
        
        public ActionResult Index()
        {
            //Pass the model to view
            return View(employeeDetails);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}