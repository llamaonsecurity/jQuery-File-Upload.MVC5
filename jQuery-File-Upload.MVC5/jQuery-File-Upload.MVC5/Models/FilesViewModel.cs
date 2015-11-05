
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using jQuery_File_Upload.MVC5.Helpers;
namespace jQuery_File_Upload.MVC5.Models
{
    public class FilesViewModel
    {
        public ViewDataUploadFilesResult[] Files { get; set; }
    }
}