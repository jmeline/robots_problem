using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    class MasterRobot : Robot
    {
        public MasterRobot()
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized");
        }

        ~MasterRobot()
        {
            System.Console.WriteLine("Cleaning up MasterRobot");
        }

        public void PrintState()
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has " + jobsWorking + " jobs working and " + jobsQueued + " jobs queued\n");
        }
        public void DoWork()
        {
            if (jobsWorking <= 2)
            {
                // ask the robot to do a job
                System.Console.WriteLine("\t" + this.GetType().Name + " is working on a new task");

                // set the state of the Robot to be working
                isWorking = true;
                jobsWorking += 1;
            }
            else
            {
                // ask helper robot to do a job via event/delegate
                System.Console.WriteLine("\tI need to ask my HelperRobot to help me");
            }
        }


    }
}
