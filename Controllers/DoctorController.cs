using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HospitalSystem.Data;

namespace HospitalSystem.Controllers
{
    public class DoctorController : Controller
    {

        ApplicationDBContext context = new ApplicationDBContext(); 

        public IActionResult BookAppoitment()
        {
            var result = context.Doctor.ToList();

            return View(result);
        }

       public IActionResult CompleteAppoitment(int Id)
        {
            var result = context.Doctor.Find(Id);
            return View(result);
        }

       
    }
}
