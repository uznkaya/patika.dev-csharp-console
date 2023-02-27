namespace whileforeach;
class Program
{
    static void Main(string[] args)
    {
        char character = 'a';
        while(character<'z'){
            Console.Write(character);
            character++;
        }
        Console.WriteLine();
        string[] arabalar = {"Mercedes","Toyota","Ferrari"};
        foreach(var isim in arabalar){
            Console.WriteLine(isim);
        }
    }
}
