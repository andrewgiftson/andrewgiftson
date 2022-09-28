using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class forming_a_magic_square
    {
        public static void Main(string[] args)
        {
            const string dataFmt = "{0,-30}{1}";
            const string timeFmt = "{0,-30}{1:MM-dd-yyyy HH:mm}";
            TimeZone curTimeZone = TimeZone.CurrentTimeZone;
            // What is TimeZone name?  
            Console.WriteLine(dataFmt, "TimeZone Name:", curTimeZone.StandardName );
            // Is TimeZone DayLight Saving?|  
            Console.WriteLine(dataFmt, "Daylight saving time?", curTimeZone.IsDaylightSavingTime(DateTime.Now));
            // What is GMT (also called Coordinated Universal Time (UTC)  
            DateTime curUTC = curTimeZone.ToUniversalTime(DateTime.Now);
            Console.WriteLine(timeFmt, "Coordinated Universal Time:", curUTC);
            // What is GMT/UTC offset ?  
            TimeSpan currentOffset = curTimeZone.GetUtcOffset(DateTime.Now);
            Console.WriteLine(dataFmt, "UTC offset:", currentOffset);
            // Get DaylightTime object  
            System.Globalization.DaylightTime dl = curTimeZone.GetDaylightChanges(DateTime.Now.Year);
            // DateTime when the daylight-saving period begins.  
            Console.WriteLine("Start: {0:MM-dd-yyyy HH:mm} ", dl.Start);
            // DateTime when the daylight-saving period ends.  
            Console.WriteLine("End: {0:MM-dd-yyyy HH:mm} ", dl.End);
            // Difference between standard time and the daylight-saving time.  
            Console.WriteLine("delta: {0}", dl.Delta);
            Console.Read();

        }
    }
}
