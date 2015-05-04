using System;
using System.Collections.Generic;
using System.Diagnostics;
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


            // Running Script
            Debug.Assert(masterRobot.NumberOfJobsWorking == 0);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);

            Console.WriteLine("\n2. The application asks the MasterRobot to do a job. \n");
            masterRobot.DoWork();

            Console.WriteLine("\n3. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued. \n");
            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 1);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);

            Console.WriteLine("\n4. The application asks the MasterRobot to do a second job. \n");
            masterRobot.DoWork();

            System.Console.WriteLine("\n5. The application confirms with MasterRobot that it has 2 jobs working and 0 jobs queued. \n");

            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 2);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);


            Console.WriteLine("\n6. The application asks the MasterRobot to do a third job. \n");
            masterRobot.DoWork();
            
            Console.WriteLine("\n7. The application confirms with MasterRobot that it has 2 jobs working and 1 job queued.\n");
            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 2);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 1);

            Console.WriteLine("\n8. The application asks the MasterRobot to do a fourth job. \n");
            masterRobot.DoWork();

            Console.WriteLine("\n9. The application confirms with MasterRobot that it has 2 jobs working and 2 jobs queued.\n");
            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 2);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 2);

            Console.WriteLine("\n10. The application tells the HelperRobot that it is finished doing its job.\n");
            helperRobot.FinishWork();

            Console.WriteLine("\n11. The application confirms with MasterRobot that it has 2 jobs working and 1 jobs queued.\n ");

            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 2);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 1);

            Console.WriteLine("\n12. The application tells the HelperRobot that it is finished doing its job.\n");
            helperRobot.FinishWork();

            Console.WriteLine("\n13. The application confirms with MasterRobot that it has 2 jobs working and 0 job queued.\n ");

            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 2);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);

            Console.WriteLine("\n14. The application tells the HelperRobot that it is finished doing its job.\n");
            helperRobot.FinishWork();

            Console.WriteLine("\n15. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued.\n ");

            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 1);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);

            Console.WriteLine("\n16. The application tells the MasterRobot that it is finished doing its job.\n");
            masterRobot.FinishWork();

            Console.WriteLine("\n17. The application confirms with MasterRobot that it has 1 job working and 0 jobs queued.\n ");

            Console.WriteLine(masterRobot);

            Debug.Assert(masterRobot.NumberOfJobsWorking == 0);
            Debug.Assert(masterRobot.NumberOfJobsQueued == 0);

            Console.WriteLine("\nScript Complete\n");

        }
    }
}
