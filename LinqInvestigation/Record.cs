using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInvestigation
{
    internal partial class Record
    {
        public override string? ToString()
        {
            return $"{ Id } - { Name } - { Colour } - { Quantity }";
        }
    }
}
