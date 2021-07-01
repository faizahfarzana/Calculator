using System.ComponentModel.DataAnnotations;
using Autofac;
using System;
using Operations.Services;

namespace WebAppPractice.Models
{
    public class CalculatorModel
    {
        [Required]
        public double Number1;
        [Required]
        public double Number2;
        public string Operator;
        public double? Result;

        private readonly ICalculatorService _calculatorService;

        public CalculatorModel()
        {
            _calculatorService = Startup.AutofacContainer.Resolve<ICalculatorService>();
        }

        public CalculatorModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public void Calculate()
        {
            Result = _calculatorService.Calculate(Number1, Number2, Operator);
        }
    }
}