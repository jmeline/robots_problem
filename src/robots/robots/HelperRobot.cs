using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{

    class HelperRobot : Robot
    {
        public HelperRobot(EventHandler eventHandler)
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized");

        }

        ~HelperRobot()
        {
            System.Console.WriteLine("Cleaning up HelperRobot");
        }
    }

}
