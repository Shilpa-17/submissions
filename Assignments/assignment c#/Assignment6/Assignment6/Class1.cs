using System;
namespace Assignment6

{
    public class ConcessionCalculator

    {
        private const int TotalFare = 500;
        public static string CalculateConcession(int age, string name)

        {

            if (age <= 5)

            {
                return $"{name} - Little Champs - Free Ticket (Age: {age})";
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.3; // 30% off
                double discountedFare = TotalFare - concessionAmount;
                return $"{name} - Senior Citizen (Age: {age}) - Calculated Fare: {discountedFare:C}";
            }

            else

            {
                return $"{name} - Ticket Booked - Fare: {TotalFare:C} (Age: {age})";
            }

        }

    }

}