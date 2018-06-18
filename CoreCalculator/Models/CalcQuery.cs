using CoreCalculator.Data;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Models
{
    public class CalcQuery : ObjectGraphType
    {
        public CalcQuery(IBasicCalculator calculator)
        {
            Field<OperationType>(
                "addition",
                arguments: new QueryArguments( 
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand1", Description = "First Operand" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand2", Description = "Second Operand" } 
                ),
                resolve: context => calculator.GetAdditionResult((double)context.GetArgument<float>("operand1"), (double)context.GetArgument<float>("operand2")).Result
            );

            Field<OperationType>(
                "subtraction",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand1", Description = "First Operand" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand2", Description = "Second Operand" }
                ),
                resolve: context => calculator.GetSubtractionResult((double)context.GetArgument<float>("operand1"), (double)context.GetArgument<float>("operand2")).Result
            );

            Field<OperationType>(
                "multiplication",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand1", Description = "First Operand" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand2", Description = "Second Operand" }
                ),
                resolve: context => calculator.GetMultiplicationResult((double)context.GetArgument<float>("operand1"), (double)context.GetArgument<float>("operand2")).Result
            );

            Field<OperationType>(
                "division",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand1", Description = "First Operand" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand2", Description = "Second Operand" }
                ),
                resolve: context => calculator.GetDivisionResult((double)context.GetArgument<float>("operand1"), (double)context.GetArgument<float>("operand2")).Result
            );

            Field<OperationType>(
                "exponentiation",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand1", Description = "First Operand" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "operand2", Description = "Second Operand" }
                ),
                resolve: context => calculator.GetExponentiationResult((double)context.GetArgument<float>("operand1"), (double)context.GetArgument<float>("operand2")).Result
            );
        }
    }
}
