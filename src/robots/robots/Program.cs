using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    public class Program
    {
        static void Main(string[] args)
        {

            RobotNotifier robotNotifier = new RobotNotifier(); // publisher

            System.Console.WriteLine("1. Instantiate a MasterRobot and a HelperRobot\n");

            System.Console.WriteLine("\tStarting MasterRobot");
            MasterRobot masterRobot = new MasterRobot("MasterRobot");
            System.Console.WriteLine("\tStarting HelperRobot");
            HelperRobot helperRobot = new HelperRobot("HelperRobot");

            masterRobot.CommunicateWithOtherRobot += helperRobot.OnHandleCommunication;
            masterRobot.FinishWork();

            helperRobot.CommunicateWithOtherRobot += masterRobot.OnHandleCommunication;
            helperRobot.FinishWork();

            //masterRobot.WorkingState = true;
            //masterRobot.DoWork();

            //robotNotifier.WorkFinished += masterRobot.OnFinishWork;
            //robotNotifier.WorkFinished += helperRobot.OnFinishWork;

            //robotNotifier.OnWorkFinished();

            //System.Console.WriteLine("\n2. The application asks the MasterRobot to do a job. \n");
            //masterRobot.DoWork();

            //System.Console.WriteLine("\n3. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued. \n");
            //masterRobot.PrintState();

            //System.Console.WriteLine("\n4. The application asks the MasterRobot to do a second job. \n");
            //masterRobot.DoWork();

            //System.Console.WriteLine("\n5. The application confirms with MasterRobot that it has 2 jobs working and 0 jobs queued. \n");
            //masterRobot.PrintState();

            //System.Console.WriteLine("\n6. The application asks the MasterRobot to do a third job. \n");
            //masterRobot.DoWork();

        }
    }
}
