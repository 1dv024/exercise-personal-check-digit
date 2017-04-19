namespace PersonalCheckDigit
{
    /// <summary>
    ///     Represents the main place where the program starts the execution.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The starting point of the application.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var app = new Application();
            app.Run();
        }
    }
}