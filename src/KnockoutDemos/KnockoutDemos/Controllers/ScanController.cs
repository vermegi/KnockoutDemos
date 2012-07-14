using System.Web.Mvc;
using KnockoutDemos.Domain;
using KnockoutDemos.ViewModels;

namespace KnockoutDemos.Controllers
{
    public class ScanController : Controller
    {
         public ActionResult Detail(int id)
         {
             var scan = new Scan
                            {
                                Id = id,
                                File = "This is the file",
                                DossierId = 0,
                                DossierNumber = string.Empty
                            };
             return View(new ScanViewModel(scan, new Dossier()));
         }
    }
}