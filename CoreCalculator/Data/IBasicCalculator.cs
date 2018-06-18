using CoreCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Data
{
    public interface IBasicCalculator
    {
        Task<Operation> GetAdditionResult(double operand1, double operand2);
        Task<Operation> GetSubtractionResult(double operand1, double operand2);
        Task<Operation> GetMultiplicationResult(double operand1, double operand2);
        Task<Operation> GetDivisionResult(double operand1, double operand2);
        Task<Operation> GetExponentiationResult(double operand1, double operand2);

    }
}
