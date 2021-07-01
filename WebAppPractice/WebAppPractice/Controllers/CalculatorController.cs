using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WebAppPractice.Models;

namespace WebAppPractice.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Calculate()
        {
            var model = new CalculatorModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Calculate(CalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Calculate();
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Calculation failed!");
                }
            }
            return View(model);
        }
    }
}
