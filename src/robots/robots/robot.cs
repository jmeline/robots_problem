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

        public int jobsWorking;
        public int jobsQueued;

        #region Robot Constructor
        public Robot()
        {
            jobsWorking = 0;
            jobsQueued = 0;
        }
        #endregion

        #region Robot Deconstructor
        ~Robot()
        {
            System.Console.WriteLine("Cleaning up Robot");
        }
        #endregion

        #region DoWork
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
        #endregion

        #region FinishWork
        public void FinishWork()
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

            EventHandler eventHandler = new EventHandler();

            System.Console.WriteLine("1. Instantiate a MasterRobot and a HelperRobot\n");

            System.Console.WriteLine("\tStarting MasterRobot");
            MasterRobot masterRobot = new MasterRobot(eventHandler);
            System.Console.WriteLine("\tStarting HelperRobot");
            HelperRobot helperRobot = new HelperRobot(eventHandler);

            System.Console.WriteLine("\n2. The application asks the MasterRobot to do a job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n3. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued. \n");
            masterRobot.PrintState();

            System.Console.WriteLine("\n4. The application asks the MasterRobot to do a second job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n5. The application confirms with MasterRobot that it has 2 jobs working and 0 jobs queued. \n");
            masterRobot.PrintState();

            System.Console.WriteLine("\n6. The application asks the MasterRobot to do a third job. \n");
            masterRobot.DoWork();

        }

    }

    


}
