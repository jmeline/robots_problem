using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    public class Script
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("1. Instantiate a MasterRobot and a HelperRobot\n");

            System.Console.WriteLine("Starting MasterRobot");
            MasterRobot masterRobot = new MasterRobot("MasterRobot");
            System.Console.WriteLine("Starting HelperRobot");
            HelperRobot helperRobot = new HelperRobot("HelperRobot");

            // Establish communication channels
            masterRobot.CommunicateWithOtherRobot += helperRobot.OnHandleCommunication;
            helperRobot.CommunicateWithOtherRobot += masterRobot.OnHandleCommunication;

            //masterRobot.FinishWork();
            //helperRobot.FinishWork();

            //Console.WriteLine("");

            //masterRobot.isWorking = true;
            //masterRobot.DoWork();

            System.Console.WriteLine("\n2. The application asks the MasterRobot to do a job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n3. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued. \n");
            Console.WriteLine(masterRobot);

            System.Console.WriteLine("\n4. The application asks the MasterRobot to do a second job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n5. The application confirms with MasterRobot that it has 2 jobs working and 0 jobs queued. \n");
            Console.WriteLine(masterRobot);

            //System.Console.WriteLine("\n6. The application asks the MasterRobot to do a third job. \n");
            //masterRobot.DoWork();

        }
    }
}
