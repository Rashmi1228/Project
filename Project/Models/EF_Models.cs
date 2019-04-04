using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class EF_Models
    {
        //API 1
        public class C1
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        //API 2
        public class C2
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        //API 3
        public class C3
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        //API 4
        public class C4
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        //API 5
        public class C5
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }
    }
}

