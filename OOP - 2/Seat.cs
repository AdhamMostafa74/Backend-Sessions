using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___2
{
    public class Seat
    {
        public Seat(char row, int col)
        {
            Row = row;
            this.col = col;
        }

        public char Row { get; set; }
        public int col { get; set; }

        public override string? ToString()
        {
            return $"{Row}{col}";
        }
    }
}
