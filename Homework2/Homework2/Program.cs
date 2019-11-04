using System;


namespace Math
{
    class Math
    {
        static void Main()
        {
            Console.WriteLine("Введите свой угол");
            float round = float.Parse(Console.ReadLine());
            float maincos = MathF.Round(MathF.Cos(round), 3);
            float mainsin = MathF.Round(MathF.Sin(round), 3);
            float fifteensin = MathF.Round(MathF.Sin(15), 3);
            float fifteencos = MathF.Round(MathF.Cos(15), 3);
            float tssin = MathF.Round(MathF.Sin(27), 3);
            float tscos = MathF.Round(MathF.Cos(27), 3);
            float hunthreesin = MathF.Round(MathF.Sin(113), 3);
            float hunthreecos = MathF.Round(MathF.Cos(113), 3);
        
            Console.WriteLine("Косинус вашего угла {0}, синус {1} ", mainsin, maincos);
            Console.WriteLine("cos15 = {0}, sin15 = {1}", fifteencos, fifteensin);
            Console.WriteLine("cos27 = {0}, sin27 = {1}", tscos, tssin);
            Console.WriteLine("cos113 = {0}, sin113 = {1}", hunthreecos, hunthreesin);
            Console.ReadKey();
        }
    }
}
