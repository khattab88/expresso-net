using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CMS.Helpers
{
    public static class ImageHelper
    {
        public static string GenerateBase64String(string folder, HttpPostedFileBase file) 
        {
            var ext = file.FileName.Split('.')[1];

            /// if svg image (.svg+xml), remove {+xml} part
            ext = ext.Replace("+xml", "");

            // upload file to server
            var filePath = Path.Combine(folder + Path.GetFileName(file.FileName));
            file.SaveAs(filePath);

            byte[] imageArray = System.IO.File.ReadAllBytes(filePath);
            string imageBase64String = Convert.ToBase64String(imageArray);
            imageBase64String = $"data:image/{ext};base64,{ imageBase64String}";

            // delete the file
            File.Delete(filePath);

            return imageBase64String;
        }
    }
}