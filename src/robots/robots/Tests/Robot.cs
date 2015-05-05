using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using robots;

namespace RobotTests
{
    [TestFixture]
    public class Test_MasterRobot
    {
        public MasterRobot masterRobot;
        public HelperRobot helperRobot;

        [Test]
        public void Test_Setup()
        {
            masterRobot = new MasterRobot("Master Robot");
            helperRobot = new HelperRobot("Helper Robot");
            Assert.NotNull(masterRobot);
            Assert.NotNull(helperRobot);

            masterRobot.CommunicateWithOtherRobot += helperRobot.OnHandleCommunication;

            helperRobot.CommunicateWithOtherRobot += masterRobot.OnHandleCommunication;
        }
    }

}
