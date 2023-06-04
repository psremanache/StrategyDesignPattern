namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Normal Car Problem we will solve it using Bike
            Buggati b = new Buggati();
            b.Drive();
            Mercedes m = new Mercedes();
            m.Drive();
            Maruti m1 = new Maruti();
            m1.Drive();
            Hayabusa hb = new Hayabusa(new SportyRide());
            hb.Ride();
            Ninja ninja = new Ninja(new SportyRide());
            ninja.Ride();
            Splender sp = new Splender(new NormalRide());
            sp.Ride();

        }
    }
}