using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{

    class HelperRobot : Robot
    {
        public HelperRobot()
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized");

        }
        public void DoWork()
        {
            if (!isWorking)
            {
                // ask the robot to do a job
                System.Console.WriteLine(this.GetType().Name + " is working on a task");

                // set the state of the Robot to be working
                isWorking = true;
            }
            else
            {
                // ask helper robot to do a job via event/delegate

            }
        }
        ~HelperRobot()
        {
            System.Console.WriteLine("Cleaning up HelperRobot");
        }
    }

}
