using Microsoft.AspNetCore.Mvc;
using WebTask.Services.Interfaces;

namespace WebTask.Controllers
{
    public class QRController : Controller
    {
        private IQRCodeGenerator _Generator;
        private ILogger<QRController> _Logger;

        public QRController(IQRCodeGenerator Generator, ILogger<QRController> logger)
        {
            _Generator = Generator;
            _Logger = logger;
        }

        public IActionResult Code(string msg)
        {
            var bytes = _Generator.Generate(msg);
            return File(bytes, "image/png");
        }
    }
}
