using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    // Base class
    class Robot
    {
        // give the robot a state
        public bool isWorking = false;
        public delegate void AddWork();
        public delegate void Reply();

        public int jobsWorking;
        public int jobsQueued;

        public Robot()
        {
            jobsWorking = 0;
            jobsQueued = 0;
        }
        ~Robot()
        {
            System.Console.WriteLine("Cleaning up Robot");
        }

        #region DoWork
        public void DoWork()
        {
        }
        #endregion

        #region FinishWork
        void FinishWork()
        {
            if (this.isWorking)
            {

                // tell the robot to finish a job
                System.Console.WriteLine(this.GetType().Name + " Finished working on a task");

                // reset the state of the Robot
                this.isWorking = false;

            }

        }
        #endregion

        static void Main(string[] args)
        {
            System.Console.WriteLine("1. Instantiate a MasterRobot and a HelperRobot\n");

            System.Console.WriteLine("\tStarting MasterRobot");
            MasterRobot masterRobot = new MasterRobot();
            System.Console.WriteLine("\tStarting HelperRobot");
            HelperRobot helperRobot = new HelperRobot();

            System.Console.WriteLine("\n2. The application asks the MasterRobot to do a job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n3. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued. \n");
            masterRobot.PrintState();

            System.Console.WriteLine("\n4. The application asks the MasterRobot to do a second job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n5. The application confirms with MasterRobot that it has 2 jobs working and 0 jobs queued. \n");
            masterRobot.PrintState();

        }

    }

    


}
