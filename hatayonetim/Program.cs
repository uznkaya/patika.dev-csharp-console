namespace hatayonetim;
class Program
{
    static void Main(string[] args)
    {   
        // try
        // {
        //     Console.Write("Bir sayi giriniz :");
        //     int sayi = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Girdiginiz Sayi :"+sayi);
        // }
        // catch(Exception ex)
        // {
        //     Console.WriteLine("Hata :"+ex.Message.ToString());
        // }
        // finally
        // {
        //     Console.WriteLine("İslem tamamlandi.");
        // }

        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-22222222222222");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine("Bos deger girdiniz.");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun degil.");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Sinir asimi yaptiniz.");
            Console.WriteLine(ex);
        }
    }
}
