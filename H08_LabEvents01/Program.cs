using System;

namespace H08_LabEvents01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Scenario:
             * A NuclearReactor can split atoms, but everytime it splits them, 
             * its temperature increases by one degree.
             * We want to make sure that the temperature never goes above 100 degrees.
             * The NuclearReactor does not know how to decrease its temperature,
             * but it has an alarm that goes on everytime that its temperature increases.
             * 
             * We want a Pump to react to the alarm, so that the temperature can get lower.
             * 
             ******************************************************************
             * 
             * A Reactor has a Split() method.
             * A Reactor has an int Temperature property.
             * Splitting atoms causes the temperature to increase. 
             * When the temperature changes an event is raised.
             *
             * In the handler the current temperature must be available.
             * 
             * Create a delegate that uses a parameter of type NuclearReactor.
             * 
             * There are two types of Pump that can react to the event that the reactor raises:
             * a PneumaticPump and a HydraulicPump. 
             * 
             * A Pump has a Turn method with a NuclearReactor parameter.
             * The PneumaticPump will reduce the temperature by one degree if the temperature is higher than 100 degrees.
             * The HydraulicPump will reduce the temperature by ten degrees if the temperature is higher than 100 degrees.
             * 
             * Create a Main method in which an instance of a NuclearReactor is created 
             * and instances of both types of pumps are created.  
             * Assign the Turn of the pumps as listeners to the NuclearReactor Alarm event.
             * 
             * Create a third listener in your Program class,
             * that writes on the console everytime the temperature changes.
             * 
             * Register the listener on the Alarm event.
             * 
             * Split atoms 300 times.
             * 
             */

            Console.ReadLine();
        }
    }
}
