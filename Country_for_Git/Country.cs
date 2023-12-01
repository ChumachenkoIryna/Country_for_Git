using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_for_Git
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public int? Population { get; set; }
        public double? Area { get; set; }

        public virtual WorldPart WorldPart { get; set; }
    }
}
