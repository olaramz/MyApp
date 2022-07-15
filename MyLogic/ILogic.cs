using MyModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLogic
{
   public interface ILogic
    {
        double Addition(AdditionViewModel model);

        double Subtraction(SubtractionViewModel model);

        double Multiply(MultiplyViewModel model);

        double Division(DivisionViewModel model);

    }
}
