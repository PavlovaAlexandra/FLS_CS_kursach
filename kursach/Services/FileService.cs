using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Word = Microsoft.Office.Interop.Word;

namespace kursach.Services
{
    public static class FileService
    {
        public static byte[] DownloadTxt(string returnText)
        {
            return Encoding.UTF8.GetBytes(returnText);
        }
        public static string OpenFile(IFormFile fileTxt)
        {
            string text = "";
            if (fileTxt.ContentType == "application/octet-stream")
            {
                
            }
            DirectoryInfo dirInfo = new DirectoryInfo(fileTxt.FileName);
            foreach (FileInfo file in dirInfo.GetFiles("*.docx"))
            {

            }
            FileStream fileStream = new FileStream(fileTxt.FileName, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = reader.ReadToEnd();
            }
            using (var fileStreamRead = fileTxt.OpenReadStream())
            {
                Encoding Windows1251 = CodePagesEncodingProvider.Instance.GetEncoding(1251);
                text = new StreamReader(fileStreamRead, Windows1251).ReadToEnd();
            }
            return text;
        }
    }
}
