using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.Name = "Elma";
        product1.Price = 15;
        product1.Info = "Amasya Elması";

        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "Karpuz";
        product2.Price = 80;
        product2.Info = "Diyarbakır Karpuzu";

        Product[] products = new Product[] { product1, product2 };

        foreach (Product product in products)
        {
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Info);
            Console.WriteLine("------------");
        }

        Console.WriteLine("----------Metotlar------------");

        //Encapsulation

        SepetManager sepetManager = new SepetManager();
        sepetManager.Add(product1);
        sepetManager.Add(product2);

        sepetManager.Add2("Armut", "Yeşil Armut", 12 , 20);
        sepetManager.Add2("Elma", "Yeşil Elma", 20 , 14);
        sepetManager.Add2("Kavun", "Adana Kavunu", 50, 40);

    }
}