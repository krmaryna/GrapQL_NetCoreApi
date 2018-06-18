using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Models
{
    public class OperationType : ObjectGraphType<Operation>
    {
        public OperationType()
        {
            Field(x => x.Id, nullable: true).Description("Operation id");
            Field(x => x.Operand1).Description("First operand");
            Field(x => x.Operand2).Description("Second operand");
            Field(x => x.Result, nullable: true).Description("Result of operation");
        }
    }
}
