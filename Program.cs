using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace AbstractFactory;


public interface IShoes
    {
        
        public string[] Materials{ get; set; }

    }

public interface ISneakers : IShoes {}
public interface IWomensShoes : IShoes {}
public interface IMensShoes : IShoes {}

public interface IShoesSupplier
{
    
    ISneakers CreateSneakers();
    IWomensShoes CreateWomensShoes();
    IMensShoes CreateMensShoes();

}

public static class Suppliers
{
    
    //

    private static IShoesSupplier ChooseSupplier()
    {

        Logger.Instance.Log("[ChooseSupplier] called");

        InputHelper input = new InputHelper();

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("Which material type do you want?");

            Console.WriteLine("1. Naturall leather;");
            Console.WriteLine("2. Synthetic leather;");
            Console.WriteLine("3. Leather with furr elements.");

            switch (input.GetInt())
            {

                case 1:
                    {
                        
                        return new ShoesSupplier_Naturall();

                    }
                case 2:
                    {
                        
                        return new ShoesSupplier_Synthetic();

                    }
                case 3:
                    {
                        
                        return new ShoeSupplier_NatAndFurr();

                    }
                default:
                    {
                        
                        Console.WriteLine("Incorrect value: no such option");
                        break;

                    }

            }

        }

    }

    public static IShoes BuyShoes()
    {
        
        Logger.Instance.Log("[BuyShoes] called");

        InputHelper input = new InputHelper();

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("Which type of shoe do you want?");

            Console.WriteLine("1. Sneakers;");
            Console.WriteLine("2. Womens shoes;");
            Console.WriteLine("3. Mens shoes.");

            //int whichShoes = input.GetInt();

            switch (input.GetInt())
            {

                case 1:
                    {
                        
                        
                        return ChooseSupplier().CreateSneakers();

                    }
                case 2:
                    {
                        
                        return ChooseSupplier().CreateWomensShoes();

                    }
                case 3:
                    {
                        
                        return ChooseSupplier().CreateMensShoes();

                    }
                default:
                    {
                        
                        Console.WriteLine("Incorrect value: no such shoe type");
                        break;

                    }

            }

        }

        //

    }

}

public class Menu
{
    
    public static void MainMenu()
    {
        
        InputHelper input = new InputHelper();

        Logger.Instance.Log("[MainMenu] Called");
        Console.Clear();
        Console.WriteLine("====MENU====");
        Console.WriteLine("1. Buy shoes");
        Console.WriteLine("2. Exit");
        Console.WriteLine("============");
        
        switch (input.GetInt())
        {
            
            case 1:
                {
                    
                    Suppliers.BuyShoes();
                    break;

                }
            case 2:
                {
                    
                    Logger.Instance.Log("[Exit] called");
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                }
            default:
                {
                    
                    Console.WriteLine("Incorrect value: no such option");
                    break;

                }

        }

    }

}

class Program
{
    static void Main(string[] args)
    {

        while (true)
            Menu.MainMenu();

    }
}
