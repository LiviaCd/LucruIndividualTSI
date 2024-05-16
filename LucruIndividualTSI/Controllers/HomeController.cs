using System;
using System.Reflection;
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
               if (model.Q1)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                                            "Protejează informațiile sensibile și confidențiale\n" +
                                                            "Reduce riscul de breșe de securitate și atacuri cibernetice\n" +
                                                            "Crește încrederea clienților și a partenerilor de afaceri\n" +
                                                            "Asigură conformitatea cu reglementările legale și standardele industriale\n";
               }

               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru îmbunătățirea securității sistemului:\n" +
                                                              "Elaborați și documentați o politică de securitate a informației\n" +
                                                              "Asigurați-vă că politica este aprobată de conducere și comunicată tuturor angajaților\n" +
                                                              "Implementați controale de acces și politici de autentificare puternice\n" +
                                                              "Organizați sesiuni de instruire pentru angajați pe tema securității informației\n" +
                                                              "Realizați audituri și evaluări periodice ale securității pentru a identifica și remedia vulnerabilitățile\n" +
                                                              "Utilizați software de securitate actualizat și soluții de protecție împotriva malware-ului\n";
               }
               model.Q1 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q2)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                                             "Angajații sunt conștienți de politicile de securitate\n" +
                                                             "Reduce riscul de erori umane care pot compromite securitatea\n" +
                                                             "Îmbunătățește cultura de securitate în cadrul companiei\n" +
                                                             "Asigură conformitatea cu cerințele de reglementare\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru îmbunătățirea instruirii:\n" +
                                                               "Organizați sesiuni de instruire regulate pentru toți angajații\n" +
                                                               "Includeți module de e-learning accesibile oricând\n" +
                                                               "Asigurați-vă că politica de securitate este bine documentată și disponibilă\n" +
                                                               "Evaluați periodic nivelul de înțelegere al angajaților prin teste și chestionare\n";
               }
               model.Q2 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q3)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Clasificarea corectă a informațiilor protejează datele sensibile\n" +
                                             "Facilitează gestionarea accesului la informații\n" +
                                             "Ajută la respectarea reglementărilor privind protecția datelor\n" +
                                             "Îmbunătățește eficiența operațiunilor printr-o gestionare clară a datelor\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru clasificarea informațiilor:\n" +
                                               "Elaborați proceduri clare pentru clasificarea informațiilor\n" +
                                               "Implementați nivele de clasificare, cum ar fi public, intern, confidențial\n" +
                                               "Instruieți angajații cu privire la importanța clasificării corecte\n" +
                                               "Utilizați etichete și marcaje pentru a indica nivelul de sensibilitate al datelor\n";
               }
               model.Q3 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q4)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Datele sensibile sunt protejate împotriva accesului neautorizat\n" +
                                             "Asigură confidențialitatea și integritatea datelor în tranzit și stocare\n" +
                                             "Îndeplinește cerințele de conformitate și reglementare\n" +
                                             "Reduce riscul de compromitere a datelor și de amenințări cibernetice\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru utilizarea criptării:\n" +
                                               "Implementați criptarea datelor sensibile atât în stocare, cât și în tranzit\n" +
                                               "Utilizați protocoale de criptare puternice, cum ar fi TLS și AES\n" +
                                               "Asigurați-vă că toate aplicațiile și serviciile folosite suportă criptarea\n" +
                                               "Realizați audituri și evaluări periodice ale soluțiilor de criptare\n";
               }
               model.Q4 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q5)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Protejează rețelele wireless împotriva accesului neautorizat\n" +
                                             "Previne interceptarea comunicațiilor și atacurile cibernetice\n" +
                                             "Asigură confidențialitatea și integritatea datelor transmise prin rețele wireless\n" +
                                             "Îmbunătățește securitatea generală a infrastructurii IT\n";
               
          }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru securitatea rețelelor wireless:\n" +
                                               "Implementați protocoale de securitate wireless, cum ar fi WPA3\n" +
                                               "Utilizați parole puternice și schimbați-le regulat\n" +
                                               "Segmentați rețelele pentru utilizări diferite și limitează accesul\n" +
                                               "Monitorizați și înregistrați activitatea rețelelor wireless\n";
               }
               model.Q5 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q6)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Asigură protecția sistemelor informatice critice împotriva accesului neautorizat\n" +
                                             "Previne daunele fizice și pierderea datelor\n" +
                                             "Îndeplinește cerințele de conformitate și reglementare\n" +
                                             "Reduce riscul de atacuri cibernetice și furt de informații\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru implementarea controalelor de acces:\n" +
                                               "Asigurați accesul fizic la sistemele critice prin măsuri de securitate, cum ar fi biometria și cardurile de acces\n" +
                                               "Implementați controale de autentificare puternice pentru accesul logic, cum ar fi autentificarea cu doi factori\n" +
                                               "Monitorizați și înregistrați activitatea de acces la sistemele informatice critice\n" +
                                               "Realizați evaluări periodice ale riscurilor și revizuiți politicile de acces\n";
               }
               model.Q6 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q7)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Auditurile de securitate identifică vulnerabilitățile și riscurile\n" +
                                             "Asigură conformitatea cu standardele de securitate și reglementările legale\n" +
                                             "Oferă o evaluare obiectivă a eficacității măsurilor de securitate\n" +
                                             "Ajută la îmbunătățirea continuă a proceselor și politicilor de securitate\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru audituri de securitate:\n" +
                                               "Planificați și efectuați audituri de securitate interne și externe regulate\n" +
                                               "Implicați experți în securitate pentru evaluarea sistemelor și proceselor\n" +
                                               "Analizați și remediați prompt orice probleme identificate în audituri\n" +
                                               "Asigurați-vă că rezultatele auditurilor sunt raportate și urmărite\n";
               }
               model.Q7 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q8)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Planul de răspuns la incidente minimizează impactul unui atac sau unei breșe\n" +
                                             "Asigură o reacție rapidă și coordonată la evenimentele de securitate\n" +
                                             "Ajută la limitarea daunelor și recuperarea datelor afectate\n" +
                                             "Respectă cerințele de raportare și notificare în caz de încălcare a securității\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru planul de răspuns la incidente:\n" +
                                               "Elaborați și documentați un plan de răspuns la incidente detaliat\n" +
                                               "Identificați și clasificați tipurile de incidente posibile și prioritare\n" +
                                               "Definiți rolurile și responsabilitățile în cadrul echipei de răspuns la incidente\n" +
                                               "Testați și revizuiți periodic planul pentru asigurarea eficacității acestuia\n";
               }
               model.Q8 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q9)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Parolele puternice dificultățesc accesul neautorizat la conturi\n" +
                                             "Asigură confidențialitatea datelor și protejează identitatea utilizatorilor\n" +
                                             "Previne atacurile brute-force și încercările de compromitere a conturilor\n" +
                                             "Respectă cerințele de securitate și reglementările privind parolele\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru utilizarea de parole puternice:\n" +
                                               "Implementați politici de parole care să specifice lungimea și complexitatea minimă a parolelor\n" +
                                               "Asigurați-vă că utilizatorii sunt instruiți să aleagă și să-și gestioneze parolele în mod sigur\n" +
                                               "Utilizați tehnologii de autentificare cu doi factori pentru o securitate suplimentară\n" +
                                               "Realizați audituri pentru a verifica respectarea politicilor de parole\n";
               }
               model.Q9 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q10)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Autentificarea multi-factor adaugă un nivel suplimentar de securitate\n" +
                                             "Previne accesul neautorizat chiar și în cazul compromiterii parolelor\n" +
                                             "Îmbunătățește autentificarea și protecția datelor sensibile\n" +
                                             "Asigură conformitatea cu cerințele de securitate și reglementările\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru autentificarea multi-factor:\n" +
                                               "Implementați autentificarea cu doi factori pentru accesul la sistemele critice\n" +
                                               "Folosiți o combinație de elemente, cum ar fi parole, token-uri și biometrie\n" +
                                               "Asigurați-vă că toate nivelurile de acces la date sensibile sunt protejate\n" +
                                               "Instruiți și informați utilizatorii despre importanța autentificării multi-factor\n";
               }
               model.Q10 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q11)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                              "Gestionarea securității furnizorilor și a terților minimizează riscul de vulnerabilități\n" +
                                              "Asigură conformitatea cu standardele de securitate și reglementările legale\n" +
                                              "Protejează datele și resursele companiei împotriva amenințărilor externe\n" +
                                              "Îmbunătățește încrederea clienților și partenerilor de afaceri\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru gestionarea securității furnizorilor și a terților:\n" +
                                                "Elaborați și implementați proceduri clare pentru evaluarea securității furnizorilor\n" +
                                                "Stabiliți cerințe și standarde de securitate în contractele cu terții\n" +
                                                "Monitorizați și revizuiți regulat practicile de securitate ale furnizorilor și terților\n" +
                                                "Asigurați-vă că furnizorii și terții respectă politicile și standardele de securitate ale companiei\n";
               }
               model.Q11 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q12)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                              "Backup-urile și strategiile de recuperare a datelor asigură disponibilitatea informațiilor\n" +
                                              "Protejează datele împotriva pierderii sau coruperii accidentale sau intenționate\n" +
                                              "Permite recuperarea rapidă a datelor în caz de incidente sau catastrofe\n" +
                                              "Respectă cerințele de conformitate și reglementările privind protecția datelor\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru strategii de backup și recuperare a datelor:\n" +
                                                "Elaborați și implementați planuri de backup și de recuperare a datelor detaliate\n" +
                                                "Asigurați-vă că datele sunt copiate și stocate în locații securizate și redundante\n" +
                                                "Testați și revizuiți regulat procedurile de backup și de recuperare a datelor\n" +
                                                "Asigurați-vă că toate echipamentele și sistemele critice sunt incluse în strategiile de backup\n";
               }
               model.Q12 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q13)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                              "Actualizările regulate reduc riscul de vulnerabilități și exploatare\n" +
                                              "Asigură funcționarea optimă și performanța sistemelor IT\n" +
                                              "Respectă cerințele de securitate și reglementările privind protecția datelor\n" +
                                              "Îmbunătățește compatibilitatea și interoperabilitatea cu alte sisteme și aplicații\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru actualizarea sistemelor software și hardware:\n" +
                                                "Elaborați și implementați politici și proceduri pentru gestionarea actualizărilor\n" +
                                                "Stabiliți un program de actualizare regulat și monitorizați implementarea acestuia\n" +
                                                "Asigurați-vă că toate actualizările sunt testate înainte de implementare\n" +
                                                "Monitorizați și revizuiți regulat starea de securitate și compatibilitatea sistemelor actualizate\n";
               }
               model.Q13 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q14)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                             "Gestionarea eficientă a patch-urilor reduce riscul de exploatare a vulnerabilităților\n" +
                                             "Asigură conformitatea cu cerințele de securitate și reglementările legale\n" +
                                             "Protejează sistemele împotriva amenințărilor cibernetice și a atacurilor\n" +
                                             "Îmbunătățește stabilitatea și securitatea generală a infrastructurii IT\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru gestionarea patch-urilor de securitate:\n" +
                                                "Elaborați politici și proceduri clare pentru identificarea, testarea și implementarea patch-urilor\n" +
                                                "Stabiliți un program de gestionare a patch-urilor care să includă evaluarea și prioritizarea vulnerabilităților\n" +
                                                "Asigurați-vă că toate sistemele și software-ul sunt actualizate regulat cu cele mai recente patch-uri de securitate\n" +
                                                "Monitorizați și revizuiți continuu procesele de gestionare a patch-urilor pentru a asigura eficacitatea lor\n";
               }
               model.Q14 = true;
               Session["Model"] = model;
               return View();
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
               if (model.Q15)
               {
                    ViewData["ConfirmationMessageSucces"] = "Ati raspuns deja la aceasta intrebare";
                    ViewData["ConfirmationMessageInsucces"] = "Ati raspuns deja la aceasta intrebare";
                    return View();
               }
               if (response == "Da")
               {
                    model.CounterYes++;
                    ViewData["ConfirmationMessageSucces"] = "Avantaje și importanță:\n" +
                                              "Firewall-urile și sistemele de prevenire a intruziunilor protejează rețelele împotriva accesului neautorizat și a atacurilor\n" +
                                              "Monitorizarea și filtrarea traficului rețelei previn atacurile cibernetice și pierderile de date\n" +
                                              "Detectează și blochează amenințările cibernetice în timp real\n" +
                                              "Asigură conformitatea cu politicile de securitate și reglementările privind protecția datelor\n";
               }
               else if (response == "Nu")
               {
                    model.CounterNo++;
                    ViewData["ConfirmationMessageInsucces"] = "Recomandări pentru utilizarea firewall-urilor și a sistemelor de prevenire a intruziunilor:\n" +
                                                "Implementați firewall-uri și sisteme de prevenire a intruziunilor în toate punctele de acces la rețea\n" +
                                                "Configurați-le pentru a monitoriza, detecta și bloca traficul nedorit sau potențial periculos\n" +
                                                "Asigurați-vă că politicile și reglementările de securitate sunt aplicate corect și actualizate în mod regulat\n" +
                                                "Monitorizați și revizuiți activitatea și eficacitatea firewall-urilor și a sistemelor de prevenire a intruziunilor\n";
               }
               model.Q15 = true;
               Session["Model"] = model;
               return View();
          }
        public ActionResult Final()
        {
            var model = (Session["Model"] as Model) ?? new Model();
            if (model == null)
            {
                model = new Model();
            }
            int yesResponse = model.CounterYes;
            double score = (double)(yesResponse * 100) / 15;
            model.Score = score;

            Session["Model"] = model;
            if (Session["Name"] != null)
            {
                model.Name = Session["Name"].ToString();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Final(Model model)
        {
            model = (Session["Model"] as Model) ?? new Model();

            if (Session["Name"] != null)
            {
                model.Name = Session["Name"].ToString();
            }

            return View(model);
        }

        public ActionResult Review()
        {
            return View(new Model());
        }

        

    }
}
