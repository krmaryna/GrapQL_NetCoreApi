using System;
using CoreCalculator.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result { get; set; }

        public Operation() { }

        public Operation(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public void AdditionOperation()
        {
            Result = Operand1 + Operand2;
            OperationsLog log = new OperationsLog();
            log.FileLog(this);
            log.DBLog(this);
        }

        public void SubtractionOperation()
        {
            Result = Operand1 - Operand2;
            OperationsLog log = new OperationsLog();
            log.FileLog(this);
            log.DBLog(this);
        }

        public void MultiplicationOperation()
        {
            Result = Operand1 * Operand2;
            OperationsLog log = new OperationsLog();
            log.FileLog(this);
            log.DBLog(this);
        }

        public void DivisionOperation()
        {
            Result = Operand1 / Operand2;
            OperationsLog log = new OperationsLog();
            log.FileLog(this);
            log.DBLog(this);
        }

        public void ExponentiationOperation()
        {
            Result = (float)Math.Pow(Operand1, Operand2);
            OperationsLog log = new OperationsLog();
            log.FileLog(this);
            log.DBLog(this);
        }

    }
}
