using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{

    class RobotEventArgs : EventArgs
    {
        public Robot Robot { get; set; }
        public bool RequestHelp { get; set; }
        public string Message { get; set; }
    }

    // Base class
    class Robot
    {
        public event EventHandler<RobotEventArgs> CommunicateWithOtherRobot;
        public string Name;
        public bool isWorking;


        #region Robot Constructor
        public Robot(string name)
        {
            Name = name;
        }
        #endregion

        #region Robot Deconstructor
        ~Robot()
        {
            //System.Console.WriteLine("Cleaning up Robot");
        }
        #endregion

        #region DoWork
        public virtual void DoWork()
        {
            //if (jobsWorking <= 2)
            //{
            //    // ask the robot to do a job
            //    System.Console.WriteLine("\t" + this.GetType().Name + " is working on a new task");

            //    // set the state of the Robot to be working
            //    isBusyWorking = true;
            //    jobsWorking += 1;
            //}
            //else
            //{
            //    // ask helper robot to do a job via event/delegate
            //    System.Console.WriteLine("\tI need to ask my HelperRobot to help me");
            //}
        } 
        #endregion

        #region FinishWork
        public virtual void FinishWork()
        {
            //if (this.isBusyWorking)
            //{

            //    // tell the robot to finish a job
            //    System.Console.WriteLine(this.GetType().Name + " Finished working on a task");

            //    // reset the state of the Robot
            //    this.isBusyWorking = false;

            //}

            //OnHandleCommunication();


        }
        #endregion

        protected virtual void OnHandleCommunication(RobotEventArgs args)
        {
            if (CommunicateWithOtherRobot != null)
                CommunicateWithOtherRobot(this, args);
        }


    }

    


}
