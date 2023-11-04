using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_enum
{
    public static class Bird
    {
        public static bool IsCanFly()
        {
            BirdInformation birdInformation = new BirdInformation();
            if (birdInformation.canFly == true)
            {
                return false;

            }
            return true;
        }

        public static void SetBirdInformation()
        {
            BirdInformation birdInformation = new BirdInformation();
            Console.Write("id: ");
            birdInformation.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("name: ");
            birdInformation.name = Console.ReadLine();
            Console.Write("descreption: ");
            birdInformation.description = Console.ReadLine();
            Console.Write("type: ");
            birdInformation.type = Console.ReadLine();
            Console.Write("canFly: ");
            birdInformation.canFly = Convert.ToBoolean(Console.ReadLine());

        }
    }
}
