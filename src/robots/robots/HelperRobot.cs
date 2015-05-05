using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{

    public class HelperRobot : Robot
    {
        public HelperRobot(string name) : base(name)
        {
            System.Console.WriteLine(Name + " has been initialized");
        }

        public void OnHandleCommunication(object source, RobotEventArgs e)
        {
            // Case where MasterRobot asks HelperRobot to help out and HelperRobot is available to help
            if (e.RequestHelp && !isWorking)
            {
                isWorking = true;            
                Console.WriteLine(Name + ": I am willing to help out... Busy working");
                base.OnHandleCommunication(new RobotEventArgs() { Robot = this, Message = "" });
            }

            // Case where a request to help comes in but the HelperRobot is already busy
            else if (e.RequestHelp && isWorking)
            {
                Console.WriteLine(Name + ": I am willing to help but I am currently busy");
                base.OnHandleCommunication(new RobotEventArgs(){ Robot = this, Message = "I cannot accept the job"});
            }

            // Notification if other robot is finished working
            if (!e.Robot.isWorking)
            {
                Console.WriteLine(Name + ": " + e.Robot.Name + " Just Finished Work");
            }

        }

        public override void DoWork()
        {
            // If the HelperRobot is not already doing a job, it will do the job.
            if(!isWorking)
            {
                // set helperRobot to be busy
                isWorking = true;
                Console.WriteLine(Name + ": I can do the job... Busy working!");
            }
            // If the HelperRobot is already doing a job, it will answer that it cannot accept the job.
            else 
            {
                Console.WriteLine(Name + " I can not work because I am working");
            }

            base.DoWork();
        }

        public override void FinishWork()
        {
            // If the HelperRobot is working, have it finish up one task and check queue
            if (isWorking)
            {
                Console.WriteLine(Name + " I am finishing up work.");
                isWorking = false;
                base.OnHandleCommunication(new RobotEventArgs() { Robot = this, Message = "", RequestTask = true });                 
                
            }
            base.FinishWork();
        }


        ~HelperRobot()
        {
            System.Console.WriteLine("Cleaning up HelperRobot");
        }

    }



}
