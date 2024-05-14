using ServerClientValidations.Data;
using ServerClientValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerClientValidations.Controllers
{
    public class HomeController : Controller
    {
        ContextServices db = new ContextServices();

       


        public ActionResult Index()
        {
            List<Department> emplist = db.department.ToList();
            ViewBag.DeptarmentList = new SelectList(emplist, "DepartmentId", "DName");

            List<EmployeeDeptViewModel> listEmp = db.employee.Where(x => x.IsDeleted == false).Select(x => new EmployeeDeptViewModel { EmployeeId = x.EmployeeId, Name = x.Name, DName = x.Department.DName, Address = x.Address  }).ToList();
            ViewBag.EmployeeList = listEmp;
            return View();
        }



        [HttpPost]
        public ActionResult Index(EmployeeDeptViewModel model)
        {

            try
            {
                List<Department> emplist = db.department.ToList();
                ViewBag.EmployeeList = new SelectList(emplist, "DepartmentId", "DName");

                Employee emp = new Employee();
                emp.Address = model.Address;
                emp.Name = model.Name;
                emp.DepartmentId = model.DepartmentId;

                db.employee.Add(emp);
                db.SaveChanges();

                int latestEmpId = emp.EmployeeId;

                Site site = new Site();
                site.SiteName = model.SiteName;
                site.EmployeeId = latestEmpId;

                db.site.Add(site);
                db.SaveChanges();
                List<EmployeeDeptViewModel> listEmp = db.employee.Where(x => x.IsDeleted == false).Select(x => new EmployeeDeptViewModel { EmployeeId = x.EmployeeId, Name = x.Name, DName = x.Department.DName, Address = x.Address }).ToList();
                ViewBag.EmployeeList = listEmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(); /*RedirectToAction("Index","Home");*/
        }




        public JsonResult DeleteEmployee(int EmployeeId) 
        {
            bool result = false;
            Employee emp = db.employee.FirstOrDefault(x => x.IsDeleted == false && x.EmployeeId == EmployeeId);

            if (emp != null) 
            { 
                emp.IsDeleted = true;
                db.SaveChanges();
                result= true;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowEmployee(int EmployeeId)
        {

            List<EmployeeDeptViewModel> listEmp = db.employee.Where(x => x.IsDeleted == false && x.EmployeeId==EmployeeId).Select(x => new EmployeeDeptViewModel { EmployeeId = x.EmployeeId, Name = x.Name, DName = x.Department.DName, Address = x.Address }).ToList();
            ViewBag.EmployeeList = listEmp;

            return PartialView("PartialViewDemo");
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