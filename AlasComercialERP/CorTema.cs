using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlasComercialERP
{
    public static class CorTema
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        

        public static List<string> cores = new List<string>()
        {
            "#355C7D", // muted navy
            "#6C5B7B", // dusty purple
            "#8E7DBE", // soft violet
            "#557A95", // steel blue
            "#2A9D8F", // muted teal
            "#99B898", // sage green
            "#A2C1B7", // desaturated seafoam
            "#C7AFAF", // warm neutral
            "#E5B7B7", // soft rose
            "#D6CFC7"  // light stone
        };
    }
}
