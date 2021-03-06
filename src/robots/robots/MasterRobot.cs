﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots
{
    public class MasterRobot : Robot
    {

        List<string> WorkQueue;
        internal int NumberOfJobsWorking { get; set; }
        internal int NumberOfJobsQueued { get; set; }

        public MasterRobot(string name) : base(name)
        {
            System.Console.WriteLine(Name + " has been initialized");
            WorkQueue = new List<string>();

            NumberOfJobsWorking = 0;
            NumberOfJobsQueued = 0;
        }
        public override string ToString()
        {

            return String.Format("{2}: I have {0} job(s) working and {1} job(s) queued", NumberOfJobsWorking, NumberOfJobsQueued, Name);
        }

        public void OnHandleCommunication(object source, RobotEventArgs e)
        {

            // Handle case when HelperRobot isn't able to take on more tasks
            if(e.Message.Length > 0 && e.Robot.isWorking)
            {
                Console.WriteLine(Name + ": Received a message from " + 
                    e.Robot.Name + " saying " +
                    e.Message);

                NumberOfJobsQueued += 1;
            }

            // Handle case when HelperRobot is able to work on a task
            else if (e.Robot.isWorking)
            {
                Console.WriteLine(Name + ": Adding task from " + e.Robot.Name);
                NumberOfJobsWorking += 1;
            }

            // Handle when HelperRobot finishes up a task
            if (!e.Robot.isWorking && e.RequestTask)
            {
                Console.WriteLine(Name + ": Received a task completion from " + e.Robot.Name);
                NumberOfJobsWorking -= 1;

                // Give HelperRobot another task from Queue if available
                if (NumberOfJobsQueued > 0)
                {
                    Console.WriteLine(Name + String.Format(": Giving {0} another task from the queue", e.Robot.Name));
                    base.OnHandleCommunication(new RobotEventArgs() { Robot = this, RequestHelp = true });
                    NumberOfJobsQueued -= 1;
                }

            }

        }

        public override void DoWork()
        {
            // If the MasterRobot is not currently doing a job, it will do the job.
            if(!isWorking)
            {
                // I can do work
                isWorking = true;
                Console.WriteLine(Name + ": I can do the job... Busy working!");
                NumberOfJobsWorking += 1;
            }
            //If the MasterRobot is already doing a job, it will ask the HelperRobot to do the job.
            else
            {
                Console.WriteLine(Name + " I am busy but I will ask HelperRobot to do the job");

                base.OnHandleCommunication(new RobotEventArgs() { Robot = this, RequestHelp = true});
            }

        }

        public override void FinishWork()
        {
            if (isWorking)
            {
                Console.WriteLine(Name + " I am finishing up work.");
                isWorking = false;

                NumberOfJobsWorking -= 1;
            }
        }


        ~MasterRobot()
        {
            System.Console.WriteLine("Cleaning up MasterRobot");
        }

    }
}
