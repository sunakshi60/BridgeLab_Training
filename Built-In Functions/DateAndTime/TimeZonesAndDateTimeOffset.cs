using System;
using System.Data;

namespace DateAndTime
{
    internal class TimeZonesAndDateTimeOffset
    {
        public static void Run()
        {
            //Current UTC (GMT) Time
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            //Time Zones
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            
            //Convert UTC to IST and PST
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

            Console.WriteLine("Current Time in Different Time Zones");
            Console.WriteLine($"GMT : {utcTime:dd/MM/yyyy hh:mm:ss tt}");
            Console.WriteLine($"IST : {istTime:dd/MM/yyyy hh:mm:ss tt}");
            Console.WriteLine($"PST : {pstTime:dd/MM/yyyy hh:mm:ss tt}");
        }
    }
}