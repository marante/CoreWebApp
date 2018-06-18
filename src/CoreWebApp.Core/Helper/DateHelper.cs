using System;

namespace CoreWebApp.Core
{
    /// <summary>
    /// Helper class for operations regarding time.
    /// </summary>
    public class DateHelper
    {
        public static string ConvertToIsoStandard ()
        {
            DateTime time = DateTime.UtcNow.AddHours (2);
            return time.ToString ("s", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}