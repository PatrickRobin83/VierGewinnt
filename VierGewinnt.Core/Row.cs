using System.Collections.Generic;
using VierGewinnt.Core.Interfaces;

namespace VierGewinnt.Core
{
    public class Row : Line
    {
        private readonly IReadOnlyList<IField> _fields;

        public Row(IReadOnlyList<IField> fields) : base(fields)
        {
            _fields = fields;
        }
    }
}