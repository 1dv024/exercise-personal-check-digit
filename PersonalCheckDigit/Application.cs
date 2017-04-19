using System;

namespace PersonalCheckDigit
{
    /// <summary>
    ///     Represents a console application.
    /// </summary>
    internal class Application
    {
        /// <summary>
        ///     Runs an application.
        /// </summary>
        public void Run()
        {
            var pid = new PersonalIdentityNumber("19990612-6074");

            Render(pid, " 19990612-6074");

            pid.Number = "990612-6074";
            Render(pid, " 19990612-6074");

            pid.Number = "9906126074";
            Render(pid, " 19990612-6074");

            pid.Number = "990612+6074";
            Render(pid, " 18990612-6074");

            pid.Number = "19991612-6074";
            Render(pid, " 19991612-6074, Incorrect date!16 months...exception!");

            pid.Number = "990612-7074";
            Render(pid, " 990612-7074, Incorrect birth number! 707 instead of 607...exception!");

            pid.Number = "199906126075";
            Render(pid, " 199906126075, Incorrect check digit! 5 instead of 4...exception!");

            pid.Number = "010927-1049";
            Render(pid, " 20010927-1049");

            pid.Number = "010927+1049";
            Render(pid, " 19010927-1049");

            //Console.WriteLine("\n---------------------");
            //Console.Write("Enter a personal identity number (empty string to exit): ");
            //while (!string.IsNullOrEmpty(pid.Number = Console.ReadLine()))
            //{
            //    Render(pid);
            //    Console.Write("\nEnter a personal identity number (empty string to exit)");
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="message"></param>
        private static void Render(PersonalIdentityNumber pid, string message = "")
        {
            try
            {
                Console.WriteLine(message.PadLeft(70, '-'));
                Console.WriteLine($"Number:           {pid.Number}");
                Console.WriteLine($"Valid:            {pid.IsValid}");
                Console.WriteLine($"Birthdate:        {pid.Birthdate:d}");
                Console.WriteLine($"Birth number:     {pid.BirthNumber}");
                Console.WriteLine($"Check digit:      {pid.CheckDigit}");
                Console.WriteLine($"Gender:           {pid.Gender}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine($"ToString (short): {pid.ToString("d")}");
                Console.WriteLine($"ToString:         {pid}");
                Console.WriteLine();
            }
        }
    }
}