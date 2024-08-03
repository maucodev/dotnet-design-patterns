using System;
using Bridge.RemoteControlExample;

namespace Bridge
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Remote Control Example
            //

            var remoteControl = new RemoteControl(new SonyDevice());
            var advancedRemoteControl = new AdvancedRemoteControl(new SonyDevice());

            remoteControl.TurnOn();
            
            advancedRemoteControl.SetChannel(5);

            remoteControl = new RemoteControl(new SamsungDevice());
            advancedRemoteControl = new AdvancedRemoteControl(new SamsungDevice());

            remoteControl.TurnOn();
            
            advancedRemoteControl.SetChannel(5);

            Console.ReadLine();
        }
    }
}
