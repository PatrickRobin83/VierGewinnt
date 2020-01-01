using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Row : Line
    {
        private readonly IReadOnlyList<Field> _fields;

        public Row(IReadOnlyList<Field> fields) : base(fields)
        {

        }
    }
}