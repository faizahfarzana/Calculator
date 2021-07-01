using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.Services
{
    public interface ICalculatorService
    {
        double Calculate(double Number1, double Number2, string Operator);
    }
}
