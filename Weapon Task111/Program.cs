using System;
using Weapon_Task;

namespace Weapon_Task11
{

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("WELCOME");
            Console.WriteLine("Write the bullet capacity");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Record the number of bullets");
            int bulletcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Record the release time");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the shooting mode");

            Weapon Gun = new Weapon(25, 12, 5, 1);

            int choice = 0;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Gun.Shoot();
                        break;
                    case 2:
                        Gun.Fire();
                        break;
                    case 3:
                        Gun.GetRemainBulletCount();
                        break;
                    case 4:
                        Gun.Reload();
                        break;
                    case 5:
                        Console.WriteLine("Thank you");
                        break;
                    case 0:
                        Gun.GetInfo();
                        break;
                    
                    default:
                        Console.WriteLine("Use the numbers 1,2,3,4,5,0");
                        break;
                        
                }
            } while (choice != 5);
        }
    }
}
