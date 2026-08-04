using System;

namespace PracticeProblems
{
    class Device
    {
        private int DeviceId;
        private string Status;

        public Device(int id,string status)
        {
            DeviceId = id;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID : {DeviceId}");
            Console.WriteLine($"Status    : {Status}");
        }
    }

    class Thermostat : Device
    {
        private int TemperatureSetting;

        public Thermostat(int id,string status,int temperature): base(id, status)
        {
            TemperatureSetting = temperature;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting : {TemperatureSetting}°C");
        }
    }
}