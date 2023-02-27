namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        string[] hayvanlar = {"Kedi","Kopek","Geyik"};
        Console.WriteLine(hayvanlar[2]);

        int[] sayilar = {2,4,8,0,5,2};
        int toplam = 0;
        foreach(var item in sayilar){
            toplam += item;
        }
        Console.WriteLine("Sayilar Dizisi Ortalamasi :"+Convert.ToDouble(toplam)/sayilar.Length);
    }
}
