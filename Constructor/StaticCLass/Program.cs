// See https://aka.ms/new-console-template for more information

static class Product
{
    public static int ProId;
    public static string ProName;
    public static int ProPrize;

    public static string ProDescription;

    static Product()
    {
        ProId = 101;
        ProName = "Lamborgini";
        ProPrize = 40;
        ProDescription = "Car";
    }

    public static void GetDeails()
    {
        Console.WriteLine("Product Id is {0}", ProId);
        Console.WriteLine("Product Name is {0}", ProName);
        Console.WriteLine("Product Prize is {0} Crore", ProPrize);
        Console.WriteLine("Product Desciption is {0}", ProDescription);

    }
    public static void GetDiscount() 
    {
        int discount = ProPrize / 10;
        Console.WriteLine( "Total Price of Product is {0} Crore",(ProPrize - discount));
    }


}
class MyProgram
{
    static void Main()
    {
        //Error - Cannot create instance of static class also we cannot inherit the static class
        //Product p = new Product();
        Product.GetDeails();
        Product.GetDiscount();
    }
    
}
