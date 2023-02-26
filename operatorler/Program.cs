namespace operatorler;
class Program
{
    static void Main(string[] args)
    {
        //Atama ve İşlemli Atama
        int x = 3;
        int y = 3;
        y += 2;
        x *= 4;

        //Mantıksal Operatorler &&, ||, !
        bool isTrue = true;
        bool isFalse = false;

        if(isTrue&&isFalse){
            Console.Write("is not working");
        }

        if(isTrue||isFalse){
            Console.Write("is working");
        }

        if(isTrue && !isFalse){
            Console.Write("is working");
        }
        
        //Iliskisel Operatorler <, >, <=, >=, ==, !=
        int nmb1 = 10;
        int nmb2 = 20;
        bool result = nmb1 != nmb2;
        Console.WriteLine(result);

        //Aritmetik Operatorler *, /, -, +
        int a = 42;
        int b = 7;
        int result2 = a/b;
        Console.WriteLine(result2);

        //Mod Alma %
        int c = a % 4;
        Console.WriteLine(c);

    }
}
