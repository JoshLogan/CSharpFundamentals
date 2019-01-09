using System;

namespace Classwork
{
    public class Computer
    {
        //The following are fields.
        string _RAM;
        string _OS;
        string _VideoResolution;
        string _ProcessorSpeed;

        //Auto property
        public string RAM { get; set; }
        public string OS { get; set; }

        //Standard longway
        public string ProcessorSpeed
        {
            get
            {
                return _ProcessorSpeed;
            }
            set
            {
                this._ProcessorSpeed = value;
            }
        }

        public string VideoResolution
        {
            get
            {
                return _VideoResolution;
            }
            set
            {
                this._VideoResolution = value;
            }
        }
        //The following are methods.
        public void TurnOff()
        {

        }
        public void TurnOn()
        {

        }

        public Computer() {}

        public Computer(string _RAM, string _OS)
        {
            this._RAM = RAM;
            this._OS = OS;
            VideoResolution = "VR";
            ProcessorSpeed = "PS";
        }

        public void TurnOn(bool IsOn)
        {
            if (IsOn)
            {
                Console.WriteLine("Computer is powered on");
            }
            else
            {
                Console.WriteLine("Computer is turned off");
            }
        }
    }
}