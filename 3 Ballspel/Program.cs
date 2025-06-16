namespace _3_Ballspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 20;
            Console.WindowWidth = 30;
            Ball b1 = new Ball(4, 4, 1, 0);
            ChaseBall c1 = new ChaseBall(1, 1);
            PlayerBall player = new EasyPlayerBall(10, 10, 0, 0);
            while (true)
            {

                Console.Clear();

                //Ball
                b1.Update();                
                b1.Draw();

                //ChaseBall
                c1.GiveChase(player);
                c1.Update();
                c1.Draw();

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                if (Ball.CheckHit(b1, player))
                {
                    Console.Clear();
                    Console.WriteLine("Gewonnen!");
                    Console.ReadLine();
                }
                else if (Ball.CheckHit(c1, player))
                {
                    Console.Clear();
                    Console.WriteLine("Verloren!");
                    Console.ReadLine();
                }
                    Thread.Sleep(120);
            }
        }
    }
}
