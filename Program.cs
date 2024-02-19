namespace CreatingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 3 Circle objects called positive, negative, and zero and set their radius.
            Circle positive = new Circle() { Radius = 1 };
            Circle negative = new Circle() { Radius = -1};
            Circle zero = new Circle() { Radius = 0};

            // Try calling the SetRadius() method of positive.
            try
            {
                Console.WriteLine(positive);
                positive.SetRadius();
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
                negative.SetRadius();
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
                zero.SetRadius();
            }
            // If an InvalidRadiusException is caught, print the exceptions message.
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
