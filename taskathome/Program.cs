namespace taskathome
{
    internal class Program
    {
     
        static void Main()
        {
            car auto = new car();
            {

                auto.Make = "Toyota";
                auto.Model = "Corolla";
                auto.year = 2013;
                auto.engine = 1.6;
                auto.color = "black";
                auto.horsepower = 128;
                auto.fuel = "gasoline";
                auto.transmisson = "automatic";
                auto.mileage = 160.000;
                auto.condition = "used";


                System.Console.WriteLine(auto);

            }




        }





      }
}
