# Specifications

* [ ] **Robot** library class:
  * [ ] Contains a method called DoWork to ask it to do a job
  * [ ] Contains a method called FinishWork to tell it to finish a job
  * [ ] Contains a way for it to notify another object when it has been told a job is finished. 
* [ ] **MasterRobot** library class inherits from Robot.
* [ ] **HelperRobot** library class inherits from Robot.
* [ ] The **HelperRobot** class and **MasterRobot** class cannot know explicitly about each other, and the **MasterRobot** and **HelperRobot** libraries cannot reference each other. 
* [ ] Once a **robot** is told to DoWork, the job is not finished until FinishWork is called. 
* [ ] If the **MasterRobot** is told to DoWork: 
  * [ ] If the **MasterRobot** is not currently doing a job, it will do the job. 
  * [ ] If the **MasterRobot** is already doing a job, it will ask the **HelperRobot** to do the job. 
* [ ] If the **HelperRobot** is told to DoWork:
  * [ ] If the **HelperRobot** is not already doing a job, it will do the job. 
  * [ ] If the **HelperRobot** is already doing a job, it will answer that it cannot accept the job. 
* [ ] If the **MasterRobot** asks the **HelperRobot** to do a job, but the **HelperRobot** cannot accept, the **MasterRobot** will queue the job until a **Robot** is available to do the job. A **Robot** becomes available when either the **MasterRobot** finishes its current job, or the **HelperRobot** informs the **MasterRobot** that it has finished its job.
* [ ] You may NOT use global variables.

# Script

* [ ] Write an application that instantiates a **MasterRobot** and a **HelperRobot** and does any necessary initialization.

* [ ] The application asks the **MasterRobot** to do a job. 

* [ ] The application confirms with **MasterRobot** that it has 1 job working and 0 jobs queued.

* [ ] The application asks the **MasterRobot** to do a second job.

* [ ] The application confirms with **MasterRobot** that it has 2 jobs working and 0 jobs queued.

* [ ] The application asks the **MasterRobot** to do a third job.

* [ ] The application confirms with **MasterRobot** that it has 2 jobs working and 1 job queued.

* [ ] The application asks the **MasterRobot** to do a fourth job.

* [ ] The application confirms with **MasterRobot** that it has 2 jobs working and 2 jobs queued.

* [ ] The application tells the **HelperRobot** that it is finished doing its job.

* [ ] The application confirms with **MasterRobot** that it has 2 jobs working and 1 jobs queued.

* [ ] The application tells the **HelperRobot** that it is finished doing its job.

* [ ] The application confirms with **MasterRobot** that it has 2 jobs working and 0 jobs queued.

* [ ] The application tells the **HelperRobot** that it is finished doing its job.

* [ ] The application confirms with **MasterRobot** that it has 1 job working and 0 jobs queued.

* [ ] The application tells the **MasterRobot** that it is finished doing its job.

* [ ] The application confirms with **MasterRobot** that it has 0 jobs working and 0 jobs queued.
