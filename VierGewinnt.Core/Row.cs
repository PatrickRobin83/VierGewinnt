using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Row : Line
    {
        private readonly IReadOnlyList<IField> _fields;

        public Row(IReadOnlyList<IField> fields) : base(fields)
        {

        }
    }
}