using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BikeRent
{
    public static class BusinessRules // this should remain static!
    {
        // ToDo: implement CalculatePrice
        //       1 day rent    => full price
        //       2 day rent    => 20% discount
        //       > 2 day rent  => 30% discount

        // ToDo: implement CheckStartDate(string text)
        //       should be of format dd/mm/jjjj
        //       should not be in the past
        //       throws a ValidationException if these rules are violated

        public static double CalculatePrice(int days, double pricePerDay)
        {
            double priceWithDiscount = 0;

            if (days == 1)
            {
                priceWithDiscount = pricePerDay * days;
            }
            else if (days == 2)
            {
                priceWithDiscount = pricePerDay * 0.8 * days;
            }
            else if (days > 2) 
            {
                priceWithDiscount = pricePerDay * 0.7 * days;
            }
            

            return priceWithDiscount;
        }

        public static DateTime CheckStartDate(string text)
        {
            // Define the expected date format pattern
            string dateFormatPattern = @"^\d{2}/\d{2}/\d{4}$";

            // Check if the input matches the pattern
            if (!Regex.IsMatch(text, dateFormatPattern))
            {
                throw new ValidationException("Date format is incorrect. Expected format is dd/MM/yyyy.");
            }

            try
            {
                // Try to parse the date
                DateTime parsedDate = DateTime.ParseExact(
                    text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture
                );

                // Check if the date is not in the past
                if (parsedDate < DateTime.Now.Date)
                {
                    throw new ValidationException("The date should not be in the past.");
                }

                // Return the parsed date if it's valid
                return parsedDate;
            }
            catch (FormatException)
            {
                // If parsing fails, throw an exception
                throw new ValidationException("Date format is incorrect. Expected format is dd/MM/yyyy.");
            }
        }
    }
}