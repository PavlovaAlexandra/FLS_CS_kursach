using Microsoft.AspNetCore.Mvc;
using kursach.Services;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace kursach.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.text = TempData["text"]?.ToString();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult OnPost(string text, string key, string language, string encryption, IFormFile fileTxt)
        {
            if (fileTxt != null)
            {
                text = FileService.OpenFile(fileTxt);
            }

            if (string.IsNullOrEmpty(text) | string.IsNullOrWhiteSpace(key))
            {
                TempData["text"] = "Введите text и key";
                return RedirectToAction("Index");
            }

            text = EncodingService.VigenereCipher(text, key, language, encryption);
            TempData["text"] = text;
            return RedirectToAction("Index");
        }
        public IActionResult Download(string resultText)
        {
            return File(FileService.DownloadTxt(resultText), "text/plain", "Result.txt");
        }
    }
}
