namespace CreatingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 3 Circle objects called positive, negative, and zero and set their radius.
            Circle positive = new Circle();
            Circle negative = new Circle();
            Circle zero = new Circle();

            // Try calling the SetRadius() method of positive.
            try
            {
                Console.WriteLine(positive);
                positive.SetRadius(1);
            }
            // If an InvalidRadiusException is caught, print the exceptions message.
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Try calling the SetRadius() method of negative.
            try
            {
                Console.WriteLine(negative);
                negative.SetRadius(-1);
            }
            // If an InvalidRadiusException is caught, print the exceptions message.
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Try calling the SetRadius() method of zero.
            try
            {
                Console.WriteLine(zero);
                zero.SetRadius(0);
            }
            // If an InvalidRadiusException is caught, print the exceptions message.
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
