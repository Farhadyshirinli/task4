namespace taskathome
{
    internal class car

    {        
        
        public string Make;
        public string Model;
        public int year;
        public double engine;
        public int horsepower;
        public string color;
        public string  fuel;
        public string transmisson;
        public double  mileage;
        public string condition;




        public override string ToString()
        {
            return $"{Make} {Model} {year} {engine} {color} {horsepower} {fuel} { transmisson} { mileage} {condition}";
        }
        

    }
     
}
