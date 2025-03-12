// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {
        string produk = Console.ReadLine();
        Console.WriteLine("Kode Produk: " + getKodeProduk(produk));
    }

    public static string getKodeProduk(string namaProduk)
    {
        string[] prduk_elektronik = { "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"};
        string[] kode_produk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};

        for (int i = 0; i < prduk_elektronik.Length; i++)
        {
            if (prduk_elektronik[i] == namaProduk)
            {
                return kode_produk[i];
            }
        }

        return "Produk tidak ditemukan";
    }
}
