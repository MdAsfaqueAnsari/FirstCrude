using FirstCrude.Db_Contex;
using FirstCrude.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstCrude.Controllers
{
    public class HomeController : Controller
    {
        //public stable deleteItem;

        public ActionResult Index()
        {
            table2Entities1 obj=new table2Entities1();

           List<Class1> db = new List<Class1>();

            var res1=obj.stables.ToList();

            foreach (var item in res1)
            {
                db.Add(new Class1
                {
                sid= item.sid,
                sname= item.sname,
                smail= item.smail,
                smob= item.smob,
                city= item.city,
                
                });
            }


            return View(db);
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



        public ActionResult Delete(int Id)
        {
            table2Entities1 obj=new table2Entities1();
            var res=obj.stables.Where(m => m.sid==Id).First();
            obj.stables.Remove(res);
            obj.SaveChanges();
            return RedirectToAction("Index");   
            //return View();
        }



        [HttpGet]
        public ActionResult AddEmployee()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Class1 db)
        {
            table2Entities1 obj = new table2Entities1();
            stable objnew=new stable();
            objnew.sid=db.sid;
            objnew.sname = db.sname;
            objnew.smail = db.smail;
            objnew.smob = db.smob;
            objnew.city = db.city;

            obj.stables.Add(objnew);
            obj.SaveChanges();

            return RedirectToAction("Index");

            //return View();
        }
    }
}