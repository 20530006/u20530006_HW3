using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using HW_3.Models;

namespace HW_3.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Images()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Media/Images"));
            List<FileModel> files = new List<FileModel>();

            foreach (string filepath in filePaths)
            {
                files.Add(new FileModel { Filename = Path.GetFileName(filepath) });
            }
            return View();
        }

        public FileResult DownloadFile(string fileName)
        {
            string path = Server.MapPath("~/Media/Images/") + fileName; //path from documents
            byte[] bytes = System.IO.File.ReadAllBytes(path); //save file into an array
            return File(bytes, "application/octet-stream", fileName); //return file
        }

        public ActionResult DeleteFile(string fileName)
        {
            string path = Server.MapPath("~/Media/Images/") + fileName; //path from documents
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path); //delete file
            }

            return RedirectToAction("Files");
        }
    }
}
