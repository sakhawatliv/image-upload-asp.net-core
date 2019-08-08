using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MultipartImageUp.Models
{
    public class FileUpload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<IFormFile> File { get; set; }
    }
}
