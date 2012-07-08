using System.Collections.Generic;
using System.Globalization;

namespace Jerky.Tests.TestObjects
{
    public class Collections
    {
        public static IEnumerable<string> Strings()
        {
            var l = new List<string>();

            for (var i = 0; i < 15; i++)
            {
                l.Add(i.ToString(CultureInfo.InvariantCulture));
            }

            return l;
        }

    }
}
