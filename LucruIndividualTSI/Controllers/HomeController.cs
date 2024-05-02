using System;
using System.Web.Mvc;

namespace LucruIndividualTSI.Controllers
{
     public class HomeController : Controller
     {
          public ActionResult Start()
          {
               return View(new Model());  
          }

          [HttpPost]
          public ActionResult Start(Model model)
          {
               if (ModelState.IsValid)
               {
                    Session["Model"] = model;
                    Session["Name"] = model.Name;
                    return RedirectToAction("Intrebare1");
               }
               return View(model);
          }

          public ActionResult Intrebare1()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare1(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();  
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare2");
          }

          public ActionResult Intrebare2()
          {
               var model = (Session["Model"] as Model) ?? new Model();
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare2(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare3");
          }
          public ActionResult Intrebare3()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare3(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare4");
          }
          public ActionResult Intrebare4()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare4(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare5");
          }
          public ActionResult Intrebare5()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare5(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare6");
          }
          public ActionResult Intrebare6()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare6(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare7");
          }
          public ActionResult Intrebare7()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare7(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare8");
          }
          public ActionResult Intrebare8()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare8(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare9");
          }
          public ActionResult Intrebare9()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare9(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare10");
          }
          public ActionResult Intrebare10()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare10(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare11");
          }
          public ActionResult Intrebare11()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare11(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare12");
          }
          public ActionResult Intrebare12()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare12(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare13");
          }
          public ActionResult Intrebare13()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare13(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare14");
          }
          public ActionResult Intrebare14()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare14(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Intrebare15");
          }
          public ActionResult Intrebare15()
          {
               Model model = (Session["Model"] as Model) ?? new Model();
               if (Session["Name"] != null)
               {
                    model.Name = Session["Name"].ToString();
               }
               return View(model);
          }

          [HttpPost]
          public ActionResult Intrebare15(string response)
          {
               var model = Session["Model"] as Model;
               if (model == null)
               {
                    model = new Model();
               }

               if (response == "Da")
               {
                    model.CounterYes++;
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
               }

               Session["Model"] = model;
               return RedirectToAction("Final");
          }
          public ActionResult Final()
          {
               var model = (Session["Model"] as Model) ?? new Model();
               return View(model);
          }
     }
}
