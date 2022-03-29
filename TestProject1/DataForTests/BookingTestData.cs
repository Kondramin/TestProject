using System;

namespace TestProject1.DataForTests
{
    public static class BookingTestData
    {
        public static string Url = "https://www.booking.com";

        public static string SearchingCity = "Минск";

        public static DateTime ArrivalDate = DateTime.Now.AddDays(7);
        public static DateTime DepartureDate = ArrivalDate.AddDays(2);
    }
}
