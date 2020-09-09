using System;

namespace modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            player gubbe = new player();

            gubbe.y = 1;
            gubbe.x = 0;
            gubbe.health = 50;
            gubbe.damage = 10;

            platform p1 = new platform();

            p1.x = 0;
            p1.y = 0;
            p1.width = 5;
            p1.height = 1;

            enemy e1 = new enemy();

            e1.x = 5;
            e1.y = 2;
            e1.health = 10;
            e1.damage = 1;

            enemy e2 = new enemy();

            e2.x = 10;
            e2.y = 5;
            e2.health = 20;
            e2.damage = 15;

            Console.ReadLine();
        }
    }
}
