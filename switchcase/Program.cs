namespace switchcase;
class Program
{
    static void Main(string[] args)
    {
        int  ay = DateTime.Now.Month;
        switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer.");
                    break;

                default:
                    Console.WriteLine("Autumn");
                    break;
            }

    }
}
