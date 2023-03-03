namespace Restaurant03._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant rest4581;//uxaki haytararutyuna like int t;

            //rest4581.t = 85;
            Restaurant rest = new Restaurant();//sarquma instance default ctoric ogtvelov
            Console.WriteLine(rest.t);   //deafult 0
            Console.WriteLine(rest.MakeFood(Menu.Pizza, 6));


            Restaurant rest2 = new Restaurant(66);//sarquma instance poxancelov ctor in 66 tivn
            Console.WriteLine(rest2.t);//66
            Console.WriteLine(rest2.MakeFood(Menu.HotDog, 5));
            Console.ReadKey();
        }
    }
}