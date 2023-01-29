namespace LineComparisn
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");
            int x1 = 4, x2 = 5, y1 = 6, y2 = 7;
            Console.WriteLine("The points x1 = " + x1);
            Console.WriteLine("The points x2 = " + x2);
            Console.WriteLine("The points y1 = " + y1);
            Console.WriteLine("The points y2 = " + y2);
            double lengthOfLine1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            Console.Write("Lenght of a Line is : {0}", lengthOfLine1);
        }
    }
}
