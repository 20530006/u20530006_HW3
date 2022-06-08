using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW_3.Models;


namespace HW_3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(string Fileradbtn, HttpPostedFileBase file)
        {
            
            
            try
            {
                if (file != null && file.ContentLength>0 )
                {
                    if (Fileradbtn =="Image")
                    {
                        string filename = Path.GetFileName(file.FileName); //get file name
                        string path = Path.Combine(Server.MapPath("~/Media/Images"), filename); //store file in correct path 
                        file.SaveAs(path); //save path
                        ViewBag.Message = "File uploaded successfully!";

                    }

                    else if (Fileradbtn =="Document")
                    {
                        var filename = Path.GetFileName(file.FileName); //get file name
                        var path = Path.Combine(Server.MapPath("~/Media/Documents"), filename); //store file in correct path 
                        file.SaveAs(path);
                        ViewBag.Message = "File uploaded successfully!";

                    }

                    else if (Fileradbtn =="Video")
                    {
                        var filename = Path.GetFileName(file.FileName); //get file name
                        var path = Path.Combine(Server.MapPath("~/Media/Videos"), filename); //store file in correct path 
                        file.SaveAs(path);
                        ViewBag.Message = "File uploaded successfully!";


                    }
                }
                ViewBag.Message = "File uploaded successfully!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!";
                return View();
            }
             
            

               
        }
        public ActionResult AboutMe()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
    }
}