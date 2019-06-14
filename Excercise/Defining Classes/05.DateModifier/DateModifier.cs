using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        private int dateDiffrence;

        public int DateDiffrence { get { return dateDiffrence; } set { dateDiffrence = value; } }

        public DateModifier(string date1,string date2)
        {
            dateDiffrence = GetDateDiffrence(date1, date2);
        }

        public int GetDateDiffrence(string date1, string date2)
        {
            var firstDate = DateTime.ParseExact(date1,"yyyy MM dd",CultureInfo.CurrentCulture);
            var secondDate= DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.CurrentCulture);

            int diffrence = (firstDate - secondDate).Days;

            return Math.Abs(diffrence);
        }
    }
}
