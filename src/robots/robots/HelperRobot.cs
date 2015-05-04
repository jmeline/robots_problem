using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{

    class HelperRobot : Robot
    {
        public HelperRobot(string name) : base(name)
        {
            //System.Console.WriteLine("\t" + this.GetType().Name + " has been initialized");
        }

        public void OnHandleCommunication(object sender, RobotEventArgs e)
        {
            Console.WriteLine("HelperRobot: " + e.Robot.Name + " Just Finished Work");
        }

        ~HelperRobot()
        {
            //System.Console.WriteLine("Cleaning up HelperRobot");
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
    }

}
