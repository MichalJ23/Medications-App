using Microsoft.AspNetCore.Mvc;
using MedicationsApp.Models;


namespace MedicationsApp.Controllers
{
    public class MedicationController : Controller
    {
        private static List<MedicationViewModel> meds = new List<MedicationViewModel>();

        public IActionResult Index()
        {
            return View(meds);
        }

        public IActionResult Create()
        {
            var med = new MedicationViewModel();
            return View(med);
        }

        public IActionResult CreateMed(MedicationViewModel medicationViewModel)
        {
            meds.Add(medicationViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
