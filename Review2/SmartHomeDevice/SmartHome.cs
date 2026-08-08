using System;


namespace SmartHomeDevice 
{
    //abstract base class for all smart home devices
    abstract class Device
    {
        public int Id;
        public string Name;
        protected bool isOn;

        public Device(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            isOn = false;
        }

        public abstract void turnOn();
        public abstract void turnOff();
    }

    //smartHome class manages multiple rooms in the home.
    class SmartHome
    {
        public string HomeName;
        public Room[] rooms;
        public int roomCount;

        public SmartHome(string HomeName)
        {
            this.HomeName = HomeName;
            rooms = new Room[5];
            roomCount = 0;
        }

        public void AddRoom(Room room)
        {
            rooms[roomCount] = room;
            roomCount++;

            Console.WriteLine($"{room.userName} room added successfully");
        }

        public void removeRoom()
        {
            if (roomCount > 0)
            {
                roomCount--;
                Console.WriteLine("Room removed successfully");
            }
        }

        public void ShowHome()
        {
            Console.WriteLine($"Home Name: {HomeName}");
            Console.WriteLine($"Total Rooms: {roomCount}");

            for (int i = 0; i < roomCount; i++)
            {
                rooms[i].showRoom();
            }
        }
    }

    //room class manages devices belonging to a particular room.
    class Room
    {
        public string userName;
        public Device[] devices;
        public int deviceCount;

        public Room(string name)
        {
            this.userName = name;
            devices =new Device[5];
            deviceCount = 0;
        }

        public void addDevice(Device device)
        {
            devices[deviceCount] = device;
            deviceCount++;
            Console.WriteLine($"{device.Name} Device added");
        }

        public void removeDevice()
        {
            if (deviceCount > 0)
            {
                deviceCount--;
                Console.WriteLine("Device removed");
            }
        }

        public void showRoom()
        {
            Console.WriteLine($"Room: {userName}");

            for (int i = 0; i < deviceCount; i++)
            {
                Console.WriteLine($"Device: {devices[i].Name}");
            }
        }
    }

    //interface created to provide scheduling functionality.
    //any device that supports scheduling can implement this interface.
    interface ISchedulable
    {
        void ScheduleOn(string time);
        void ScheduleOff(string time);
    }

    //light inherits common functionality from Device
    class Light : Device, ISchedulable
    {
        public int Brightness;

        public Light(int id, string name) : base(id, name)
        {
            Brightness = 0;
        }

        public override void turnOn()
        {
            isOn = true;
            Brightness = 100;
            Console.WriteLine($"{Name} Light is ON");
        }

        public override void turnOff()
        {
            isOn = false;
            Brightness = 0;
            Console.WriteLine($"{Name} Light turn OFF");
        }
        public void ScheduleOn(string time)
        {
            Console.WriteLine($"{Name} scheduled to turn ON at {time}");
        }

        public void ScheduleOff(string time)
        {
            Console.WriteLine($"{Name} scheduled to turn OFF at {time}");
        }
    }

    //thermostat also supports scheduling, so it implements ISchedulable.
    class Thermostat : Device, ISchedulable
    {
        public double temp;

        public Thermostat(int id, string name) : base(id, name)
        {
            temp = 24;
        }

        public override void turnOn()
        {
            isOn = true;
            Console.WriteLine("Thermostat turnon");
        }

        public override void turnOff()
        {
            isOn = false;
            Console.WriteLine("Thermostat turn off");
        }

        public void ScheduleOn(string time)
        {
            Console.WriteLine($"{Name} scheduled to turn ON at {time}");
        }

        public void ScheduleOff(string time)
        {
            Console.WriteLine($"{Name} scheduled to turn OFF at {time}");
        }
    }

    //securityCamera inherits from Device and provides
    //its own implementation of turnOn() and turnOff().
    class SecurityCamera : Device
    {

        public SecurityCamera(int id, string name) : base(id, name)
        {
        }

        public override void turnOn()
        {
            isOn = true;
            Console.WriteLine("Camera turnon");
        }

        public override void turnOff()
        {
            isOn = false;
            Console.WriteLine("Camera turn off");
        }
    }

    //doorLock inherits from Device and overrides
    //the device-specific ON and OFF behavior.
    class DoorLock : Device
    {

        public DoorLock(int id, string name) : base(id, name)
        {
        }

        public override void turnOn()
        {
            isOn = true;
            Console.WriteLine("Lock turnon");
        }

        public override void turnOff()
        {
            isOn = false;
            Console.WriteLine("Lock turn off");
        }
    }


    //user class is responsible for controlling smart devices.
    class User
    {
        public string name;
        public string action;

        public User(string name,string action)
        {
            this.name = name;
            this.action = action;
        }

        //polymorphism apply here as turnOn/turnOff is called at runtime
        public void controlDevice(Device device,string action)
        {
            if (action == "on")
            {
                device.turnOn();
            } else
            {
                device.turnOff();
            }
        }
    }
}


