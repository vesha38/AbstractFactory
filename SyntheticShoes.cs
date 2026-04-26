using System.Dynamic;

namespace AbstractFactory
{

    public class Sneakers_Synth : ISneakers
    {
        
        public string[] Materials { get; set; }

        public Sneakers_Synth()
        {
            
            Materials = [ "Synthetic leather" ];

        }

    }

    public class WomensShoes_Synth : IWomensShoes
    {
        
        public string[] Materials { get; set; }

        public WomensShoes_Synth()
        {
            
            Materials = [ "Synthetic leather" ];

        }

    }

    public class MensShoes_Synth : IMensShoes
    {
        
        public string[] Materials { get; set; }

        public MensShoes_Synth()
        {
            
            Materials = [ "Synthetic leather" ];

        }

    }

    public class ShoesSupplier_Synthetic : IShoesSupplier
    {
        
        public ISneakers CreateSneakers()
        {
            
            Console.WriteLine("Got new sneakers made from synthetic leather");
            Console.ReadLine();
            return new Sneakers_Synth();

        }

        public IWomensShoes CreateWomensShoes()
        {
            
            Console.WriteLine("Got new womens shoes made from synthetic leather");
            Console.ReadLine();
            return new WomensShoes_Synth();
            
        }

        public IMensShoes CreateMensShoes()
        {
            
            Console.WriteLine("Got new mens shoes made from synthetic leather");
            Console.ReadLine();
            return new MensShoes_Synth();

        }

    }

}