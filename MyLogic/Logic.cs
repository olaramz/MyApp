using MyModel;
using System;

namespace MyLogic
{
    public class Logic : ILogic
    {
        public double Addition(AdditionViewModel model)
        {
            var reply = model.Salary + model.Allowance;
            return reply;
        }


        public double Subtraction(SubtractionViewModel model)
        {
            var respond = model.income - model.Tax;
            return respond;
        }

        public double Multiply(MultiplyViewModel model)
        {
            var give = model.Price * model.Quantity;
            return give;
        }

        public double Division(DivisionViewModel model)
        {
            var send = model.Cost / model.Quantity;
            return send;
        }

    }
}
