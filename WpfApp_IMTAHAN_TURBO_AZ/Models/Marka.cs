using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_IMTAHAN_TURBO_AZ.Models
{
    public class Marka
    {
        public string? MarkaName { get; set; }
        public List<string>? Models { get; set; }

        public override string ToString()
        {
            return MarkaName!;
        }

    }
}
