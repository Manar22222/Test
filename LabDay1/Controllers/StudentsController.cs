using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabDay1.Models;
namespace LabDay1.Controllers
{
    public class StudentsController:Controller
    {
        //https://localhost:44309/Students/All
        public JsonResult All()
        {
            return Json(StudentsData.students, JsonRequestBehavior.AllowGet);
        }

        //https://localhost:44309/Students/GetOne?id=1
        public JsonResult GetOne(int id)
        {
            return Json(StudentsData.students.Find(s => s.ID == id), JsonRequestBehavior.AllowGet);
        }
        //https://localhost:44309/Students/Add?id=1&name=aaa&gpa=2.5
        public string Add(int id , string name , float gpa)
        {
            var s = new Students() { ID=id , Name=name , GPA=gpa };
            StudentsData.students.Add(s);
            return " Added successfully";
        }

        //https://localhost:44309/Students/Delete?id=1
        public string Delete(int id)
        {
            var s = new Students();
            s= StudentsData.students.Find(ss => ss.ID == id);
            StudentsData.students.Remove(s);
            return " deleted successfully";
        }

        //https://localhost:44309/Students/Update?id=1&newid=8&name=aaa&gpa=2.5
        public string Update(int id , int newid, string name , float gpa)
        {
            var s = new Students();
            s = StudentsData.students.Find(ss => ss.ID == id);
            s.ID = newid;
            s.Name = name;
            s.GPA = gpa;
            return " Updated successfully";
        }
    }
}