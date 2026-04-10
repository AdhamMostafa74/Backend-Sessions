using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_1
{
    public class Book
    {
        public int Id { get; set; }

        public string? Title { get; set; } 
        public int? Price{ get; set; } 
        public int? ISBNNumber{ get; set; } 
        public int? NumberOfPages{ get; set; } 
        public int? PublishYear{ get; set; } 
        public bool InStock{ get; set; } 
    }
}
