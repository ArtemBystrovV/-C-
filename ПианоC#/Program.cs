namespace Пиан
{
    internal class Program
    {
        static int[]  One = new int[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
        static int[] two = new int[12] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
        static int[] Okt = new int[12];
        static void Main(string[] args)
        {
            Console.WriteLine("F1,2 - переключение октав.");
            Console.WriteLine(" D-L - белые,R-I - чёрные.");
            Console.WriteLine(" 1 октава.");
            Okt = One;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
                {
                    Oktavi(key);
                }
                Sound(key);
            }
            while (true);
        }
        static int[] Oktavi(System.ConsoleKeyInfo key)
        {
            string okt = key.Key == ConsoleKey.F1 ? " 1 октава" : " 2 октава";
            Console.WriteLine(okt);
            Okt = key.Key == ConsoleKey.F1 ? One : two;
            return Okt;
        }
        static void Sound(System.ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D:
                    Console.Beep(Okt[0], 300);
                    break;
                case ConsoleKey.F:
                    Console.Beep(Okt[2], 300);
                    break;
                case ConsoleKey.G:
                    Console.Beep(Okt[4], 300);
                    break;
                case ConsoleKey.H:
                    Console.Beep(Okt[5], 300);
                    break;
                case ConsoleKey.J:
                    Console.Beep(Okt[7], 300);
                    break;
                case ConsoleKey.K:
                    Console.Beep(Okt[9], 300);
                    break;
                case ConsoleKey.L:
                    Console.Beep(Okt[11], 300);
                    break;
                case ConsoleKey.R:
                    Console.Beep(Okt[1], 300);
                    break;
                case ConsoleKey.T:
                    Console.Beep(Okt[3], 300);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(Okt[6], 300);
                    break;
                case ConsoleKey.U:
                    Console.Beep(Okt[8], 300);
                    break;
                case ConsoleKey.I:
                    Console.Beep(Okt[10], 300);
                    break;
            }
        }
    }
}
