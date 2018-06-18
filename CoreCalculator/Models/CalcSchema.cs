using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCalculator.Models
{
    public class CalcSchema : Schema
    {
        public CalcSchema(Func<Type, GraphType> resolveType)
            : base(resolveType)
        {
            Query = (CalcQuery)resolveType(typeof(CalcQuery));
        }
    }
}
