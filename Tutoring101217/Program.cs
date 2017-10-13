using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring101217
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you need a friend?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() == "YES")
            {
                Friend firstFriend = new Friend();
                Console.WriteLine("Do you want your friend to be alive?");
                string aboveGround = Console.ReadLine();
                if (aboveGround.ToUpper() == "YES")
                {
                    firstFriend.IsAlive = true;
                }
                Console.WriteLine("What is your friend's name?");
                firstFriend.Name = Console.ReadLine();
                Console.WriteLine("Give {0} a high five!", firstFriend.Name);
            }
            else
            {
                Console.WriteLine("Yeah, who needs friends anyways?");
            }


        }
    }
}
