using CoreCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Data
{
    public class BasicCalculator : IBasicCalculator
    {
        public Task<Operation> GetAdditionResult(double operand1, double operand2)
        {
            Operation add = new Operation(operand1, operand2);
            add.AdditionOperation();
            return Task.FromResult(add);
        }

        public Task<Operation> GetExponentiationResult(double operand1, double operand2)
        {
            Operation add = new Operation(operand1, operand2);
            add.ExponentiationOperation();
            return Task.FromResult(add);
        }

        public Task<Operation> GetSubtractionResult(double operand1, double operand2)
        {
            Operation add = new Operation(operand1, operand2);
            add.SubtractionOperation();
            return Task.FromResult(add);
        }

        public Task<Operation> GetMultiplicationResult(double operand1, double operand2)
        {
            Operation add = new Operation(operand1, operand2);
            add.MultiplicationOperation();
            return Task.FromResult(add);
        }

        public Task<Operation> GetDivisionResult(double operand1, double operand2)
        {
            Operation add = new Operation(operand1, operand2);
            add.DivisionOperation();
            return Task.FromResult(add);
        }
    }
}
