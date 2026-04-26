namespace AbstractFactory
{
    
    public class Sneakers_Nat : ISneakers
    {
        
        public string[] Materials { get; set; }

        public Sneakers_Nat()
        {
            
            Materials = [ "Leather" ];

        }

    }

    public class WomensShoes_Nat : IWomensShoes
    {
        
        public string[] Materials { get; set; }

        public WomensShoes_Nat()
        {
            
            Materials = [ "Leather" ];

        }

    }

    public class MensShoes_Nat : IMensShoes
    {
        
        public string[] Materials { get; set; }

        public MensShoes_Nat()
        {
            
            Materials = [ "Leather" ];

        }

    }

    public class ShoesSupplier_Naturall : IShoesSupplier
    {
        
        public ISneakers CreateSneakers()
        {
            
            Console.WriteLine("Got new sneakers made from leather");
            Console.ReadLine();
            return new Sneakers_Nat();

        }

        public IWomensShoes CreateWomensShoes()
        {
            
            Console.WriteLine("Got new womens shoes made from leather");
            Console.ReadLine();
            return new WomensShoes_Nat();

        }

        public IMensShoes CreateMensShoes()
        {
            
            Console.WriteLine("Got new mens shoes made from leather");
            Console.ReadLine();
            return new MensShoes_Nat();
            
        }

    }

}