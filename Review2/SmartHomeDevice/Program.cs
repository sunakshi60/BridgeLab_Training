using System;

namespace SmartHomeDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHome home = new SmartHome("My Smart Home");

            //create rooms
            Room livingRoom = new Room("Living Room");
            Room bedroom = new Room("Bedroom");

            //differnt types of smart devices
            Light light = new Light(1, "Living Room Light");
            Thermostat thermostat = new Thermostat(2, "Room Thermostat");
            SecurityCamera camera = new SecurityCamera(3, "Security Camera");
            DoorLock doorLock = new DoorLock(4, "Main Door Lock");

            //add devies to their rooms
            livingRoom.addDevice(light);
            livingRoom.addDevice(camera);

            bedroom.addDevice(thermostat);
            bedroom.addDevice(doorLock);

            //add rooms to smart home
            home.AddRoom(livingRoom);
            home.AddRoom(bedroom);

            //display home, rooms, devices
            home.ShowHome();

            //schedule devices
            light.ScheduleOn("7:00 PM");
            thermostat.ScheduleOff("11:00 PM");

            Console.WriteLine();

            //create user with different actions
            User user1 = new User("Sunakshi", "on");
            User user2 = new User("Rahul", "off");

            Console.WriteLine("Device Control:");

            //control same device 
            user1.controlDevice(light, "on");
            user2.controlDevice(light, "off");
            Console.ReadLine();

            /*
             * 
             Changes / Updates Made:
             Initially, I was not clear about how to implement the scheduling
             functionality in the Smart Home Device system.

             After referring to and understanding the given class diagram,
             I understood that scheduling should be handled using an interface.
             So, I created the ISchedulable interface with ScheduleOn() and
             ScheduleOff() methods.

             I then implemented the ISchedulable interface in the Light and
             Thermostat classes, as these devices require scheduling functionality.

             This update helped me understand how interfaces can be used to
             provide a specific functionality to selected classes without
             adding that functionality to every device.

             I also updated the code accordingly and tested the scheduling
             functionality using the Light and Thermostat objects.
             *
             */
        }
    }
}