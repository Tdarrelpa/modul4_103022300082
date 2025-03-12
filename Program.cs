// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string produk = Console.ReadLine();
        Console.WriteLine("Kode Produk: " + getKodeProduk(produk));
    }

    public static string getKodeProduk(string namaProduk)
    {
        string[] produk_elektronik = { "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"};
        string[] kode_produk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};

        for (int i = 0; i < produk_elektronik.Length; i++)
        {
            if (produk_elektronik[i] == namaProduk)
            {
                return kode_produk[i];
            }
        }

        return "E000: Produk yang anda cari tidak ada, silahkan coba lagi!";
    }
}

public class FanLaptop 
{
    public enum state { QUIET, BALANCED, PERFORMANCE, TURBO};
    public state fanState;

    public FanLaptop()
    {
        fanState = state.QUIET;
    }
    public void modeUp()
    {
        //change fan state to the next mode (quiet -> balanced -> performance -> turbo)
        if (fanState == state.QUIET)
        {
            fanState = state.BALANCED;
        }
        else if (fanState == state.BALANCED)
        {
            fanState = state.PERFORMANCE;
        }
        else if (fanState == state.PERFORMANCE)
        {
            fanState = state.TURBO;
        }
        else if (fanState == state.TURBO)
        {
            Console.WriteLine("Mode kipas sudah paling cepat, silahkan coba lagi!");
        }
        else
        {
            Console.WriteLine("Invalid state");
        }
    }

    public void modeDown()
    {
        //change fan state to the previous mode (turbo -> performance -> balanced -> quiet)
        if (fanState == state.TURBO)
        {
            fanState = state.PERFORMANCE;
        }
        else if (fanState == state.PERFORMANCE)
        {
            fanState = state.BALANCED;
        }
        else if (fanState == state.BALANCED)
        {
            fanState = state.QUIET;
        }
        else if (fanState == state.QUIET)
        {
            Console.WriteLine("Mode kipas sudah paling lambat, silahkan coba lagi!");
        }
        else
        {
            Console.WriteLine("Invalid state");
        }
    }

    public void turboShortcut()
    {
        //change fan state to turbo mode if the current state is quiet (quiet -> turbo), otherwise change to quiet mode (turbo -> quiet)
        if (fanState == state.QUIET)
        {
            fanState = state.TURBO;
        }
        else if (fanState == state.TURBO)
        {
            fanState = state.QUIET;
        }
        else
        {
            Console.WriteLine("Invalid state");
        }
    }

    public void printState()
    {
        //print the current fan state
        Console.WriteLine(fanState);
    }

    public static void Main(string[] args)
    {
        FanLaptop laptop = new FanLaptop();
        string command;
        do
        {
            Console.Write("Enter command (goup/ godown/ shortcut/ print/ exit): ");
            command = Console.ReadLine();
            switch(command)
            {
                case "goup":
                    laptop.modeUp();
                    break;
                case "godown":
                    laptop.modeDown();
                    break;
                case "shortcut":
                    laptop.turboShortcut();
                    break;
                case "print":
                    laptop.printState();
                    break;
                case "exit":
                    Console.WriteLine("Exit program...");
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
            /*
            if (command == "goup")
            {
                laptop.modeUp();
            }
            else if (command == "godown")
            {
                laptop.modeDown();
            }
            else if (command == "shortcut")
            {
                laptop.turboShortcut();
            }
            else if (command == "print")
            {
                laptop.printState();
            }
            else if (command == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
            */
        }
        while (command != "exit");
    }
}