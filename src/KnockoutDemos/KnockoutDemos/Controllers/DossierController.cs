using System.Collections.Generic;
using System.Web.Mvc;
using KnockoutDemos.Domain;
using KnockoutDemos.ViewModels;

namespace KnockoutDemos.Controllers
{
    public class DossierController : Controller
    {
         public ActionResult Search(DossierSearchViewModel searchVm)
         {
             return Json(new
                             {
                                 Success = true,
                                 Message = "All's ok",
                                 Data = new List<Dossier>
                                            {
                                                new Dossier
                                                    {
                                                        DossierNumber = "123abc",
                                                        OwnerFirstName = "John",
                                                        OwnerLastName = "Doe"
                                                    },
                                                new Dossier
                                                    {
                                                        DossierNumber = "456def",
                                                        OwnerFirstName = "Jeff",
                                                        OwnerLastName = "Smith"
                                                    },
                                                new Dossier
                                                    {
                                                        DossierNumber = "789ghi",
                                                        OwnerFirstName = "Peter",
                                                        OwnerLastName = "Jackson"
                                                    },
                                                new Dossier
                                                    {
                                                        DossierNumber = "321jkl",
                                                        OwnerFirstName = "Carl",
                                                        OwnerLastName = "Turner"
                                                    },
                                            }
                             });
         }
    }
}