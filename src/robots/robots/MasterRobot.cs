using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    class MasterRobot : Robot
    {
        public MasterRobot(string name) : base(name)
        {
            //System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized and subscribed");
        }

        public override void DoWork()
        {
            // If the MasterRobot is not currently doing a job, it will do the job.
            if(!WorkingState)
            {
                // I can do work
                WorkingState = true;
                Console.WriteLine(Name + ": working!");
            }
            //If the MasterRobot is already doing a job, it will ask the HelperRobot to do the job.
            else
            {
                Console.WriteLine(Name + "I Can not work but I will ask HelperRobot to do the job");
            }

            //base.DoWork();
        }

        public override void FinishWork()
        {
            if (!WorkingState)
            {
                Console.WriteLine(Name + " I am finishing up work.");
                WorkingState = false;
            }
            base.FinishWork();
        }

        public void OnHandleCommunication(object source, RobotEventArgs e)
        {
            Console.WriteLine("MasterRobot: " + e.Robot.Name + " Just Finished Work");
        }

        ~MasterRobot()
        {
            //System.Console.WriteLine("Cleaning up MasterRobot");
        }

    }
}
