namespace AbstractFactory
{
    
    public class Sneakers_NatAndFurr : ISneakers
    {
        
        public string[] Materials { get; set; }

        public Sneakers_NatAndFurr()
        {
            
            Materials = [ "Leather", "Furr" ];

        }

    }

    public class WomensShoes_NatAndFurr : IWomensShoes
    {
        
        public string[] Materials { get; set; }

        public WomensShoes_NatAndFurr()
        {
            
            Materials = [ "Leather", "Furr" ];

        }

    }

    public class MensShoes_NatAndFurr : IMensShoes
    {
        
        public string[] Materials { get; set; }

        public MensShoes_NatAndFurr()
        {
            
            Materials = [ "Leather", "Furr" ];

        }

    }

    public class ShoeSupplier_NatAndFurr : IShoesSupplier
    {
        
        public ISneakers CreateSneakers()
        {
            
            Console.WriteLine("Got new sneakers made from leather with furr elements");
            Console.ReadLine();
            return new Sneakers_NatAndFurr();

        }

        public IWomensShoes CreateWomensShoes()
        {
            
            Console.WriteLine("Got new womens shoes made from leather with furr elements");
            Console.ReadLine();
            return new WomensShoes_NatAndFurr();

        }

        public IMensShoes CreateMensShoes()
        {
            
            Console.WriteLine("Got new mens shoes made from leather with furr elements");
            Console.ReadLine();
            return new MensShoes_NatAndFurr();

        }

    }

}