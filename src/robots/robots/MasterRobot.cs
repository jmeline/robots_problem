using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    class MasterRobot : Robot
    {
        public MasterRobot(EventHandler eventHandler)
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized");
        }

        ~MasterRobot()
        {
            System.Console.WriteLine("Cleaning up MasterRobot");
            
        }

        public void PrintState()
        {
            System.Console.WriteLine("\t" + this.GetType().Name + " has " + jobsWorking + " jobs working and " + jobsQueued + " jobs queued");
        }

        void isFinished()
        {

        }


    }
}
