using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms_DiscInformation
{
    public static class ConverterExtension
    {
        private const long Kb = 1024;
        private const long Mb = Kb * 1024;
        private const long Gb = Mb * 1024;
        private const long Tb = Gb * 1024;

        public static string ToPrettySize(this long value, int decimalPlaces = 0)
        {
            var tb = Math.Round((double)value / Tb, decimalPlaces);
            var gb = Math.Round((double)value / Gb, decimalPlaces);
            var mb = Math.Round((double)value / Mb, decimalPlaces);
            var kb = Math.Round((double)value / Kb, decimalPlaces);
           
            string size = 
                  tb > 1 ? ($"{tb}Tb")
                : gb > 1 ? ($"{gb} Gb")
                : mb > 1 ? ($"{mb} Mb")
                : kb > 1 ? ($"{kb} Kb")
                : ($"{ Math.Round((double)value, decimalPlaces)} + byte");
            return size;
        }
    }
}
