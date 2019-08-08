using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultipartImageUp.Models;

namespace MultipartImageUp.Controllers
{
    public class FileUploadController : Controller
    {
        //public IActionResult Index()
        //{

        //}

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FileUpload model)
        {
            //var ab = model.File.Length;
            var filePath = "D:\\";
            
            foreach (var fil in model.File)
            {
                var fullFilePath = Path.Combine(filePath, fil.FileName);
                var stream = new FileStream(fullFilePath, FileMode.Create);
            }
            return View();
        }
    }
}