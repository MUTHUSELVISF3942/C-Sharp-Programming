using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager(); //User defined delegates
     public class Events
    {
        private string _eventName;
        public static event EventManager eventLink=null;
        static int i;
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the following event");
            eventLink();
        }
        public void ShowEvent()
        {
            i++;
            System.Console.WriteLine("Event No:"+i+"\tEvent Name:"+_eventName);
        }
    }
}