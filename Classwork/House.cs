using System;
namespace Classwork
{
    public class House
    {
        //The following are fields.
        string _foundation;
        string _roof;
        string _windows;
        string _door;
        string _paintdoor;

        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }
 
     public string Windows
        {
            get
            {
                return _windows;
            }
            set
            {
                this._windows = value;
            }
        }
        public string Roof { get; set; }

        public string PaintDoor {
            get
            {
            return _paintdoor;   
            }
            set
            {
                this._paintdoor = value;
            }
        }

        //The following are methods.
        public void OpenDoor()
        {
            Console.WriteLine("tits!");
        }
        public void CloseDoor()
        {
           Console.WriteLine("Boobs!"); 

        }
    }
}    