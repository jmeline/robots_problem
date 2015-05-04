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
        public bool RequestTask { get; set; }
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
            System.Console.WriteLine("Cleaning up Robot");
        }
        #endregion

        #region DoWork
        public virtual void DoWork(){
        }
        #endregion

        #region FinishWork
        public virtual void FinishWork()
        {
        }
        #endregion

        protected virtual void OnHandleCommunication(RobotEventArgs args)
        {
            if (CommunicateWithOtherRobot != null)
                CommunicateWithOtherRobot(this, args);
        }


    }

    


}
