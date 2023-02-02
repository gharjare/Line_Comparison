namespace LineComparisn
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");
            int x1 = 4, x2 = 5, y1 = 6, y2 = 7;
            int x3 = 8, x4 = 5, y3 = 5, y4 = 7;
            Console.WriteLine(1.CompareTo(1));
            Console.WriteLine(1.CompareTo(2));
            Console.WriteLine(2.CompareTo(1));
            Console.WriteLine("The points x1 = " + x1);
            Console.WriteLine("The points x2 = " + x2);
            Console.WriteLine("The points y1 = " + y1);
            Console.WriteLine("The points y2 = " + y2);
            Console.WriteLine("The points x3 = " + x3);
            Console.WriteLine("The points x4 = " + x4);
            Console.WriteLine("The points y3 = " + y3);
            Console.WriteLine("The points y4 = " + y4);
            double lengthOfLine1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            Console.Write("Lenght of a Line is : {0}", lengthOfLine1);
            double lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Lenght of Second Line is : {0}", lengthOfLine2);
            int length = lengthOfLine1.CompareTo(lengthOfLine2);
            if (length > 0)
            {
                Console.WriteLine("Line 1 is greater than line 2");
            }
            else if (length < 0)
            {
                Console.WriteLine("line 1 is smalller than line 2");
            }
            else
            {
                Console.WriteLine("line 1 and line 2 are equal");
            }
            if (lengthOfLine1.Equals(lengthOfLine2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }

        }
    }
}
