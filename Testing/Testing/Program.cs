// See https://aka.ms/new-console-template for more information
using System;
namespace QuickDate
{
    internal class Calendar
    {
        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now}");
            Console.ReadLine();
        }
        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}