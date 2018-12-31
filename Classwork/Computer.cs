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
        public string RAM {get; set;}
        public string OS {get; set;}
       
        //Standard longway
        public string ProcessorSpeed {
        get {
            return _ProcessorSpeed;}
        set {
            this._ProcessorSpeed = value;}
        }

        public string VideoResolution {
        get {
            return _VideoResolution;}
        set {
            this._VideoResolution = value;}
        }
        //The following are methods.
        public void TurnOff()
        {

        }
            public void TurnOn()
        {

        }
    }
}