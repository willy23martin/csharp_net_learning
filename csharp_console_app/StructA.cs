using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    public struct StructA
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public StructA(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }
}
