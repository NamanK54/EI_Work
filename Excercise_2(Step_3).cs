using System;

namespace SatelliteCommandSystem
{
    // The Satellite class holds the state of the satellite
    public class Satellite
    {
        public string Orientation { get; private set; } = "North";
        public string SolarPanels { get; private set; } = "Inactive";
        public int DataCollected { get; private set; } = 0;

        // Methods to manipulate the state
        public void Rotate(string direction)
        {
            Orientation = direction;
            Console.WriteLine($"Satellite rotated to {Orientation}.");
        }

        public void ActivatePanels()
        {
            SolarPanels = "Active";
            Console.WriteLine("Solar panels activated.");
        }

        public void DeactivatePanels()
        {
            SolarPanels = "Inactive";
            Console.WriteLine("Solar panels deactivated.");
        }

        public void CollectData()
        {
            if (SolarPanels == "Active")
            {
                DataCollected += 10;
                Console.WriteLine($"Data collected. Total data: {DataCollected} units.");
            }
            else
            {
                Console.WriteLine("Cannot collect data. Solar panels are inactive.");
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Orientation: {Orientation}, Solar Panels: {SolarPanels}, Data Collected: {DataCollected} units.");
        }
    }

    // Command Interface
    public interface ICommand
    {
        void Execute();
    }

    // Concrete Command to rotate the satellite
    public class RotateCommand : ICommand
    {
        private readonly Satellite _satellite;
        private readonly string _direction;

        public RotateCommand(Satellite satellite, string direction)
        {
            _satellite = satellite;
            _direction = direction;
        }

        public void Execute()
        {
            _satellite.Rotate(_direction);
        }
    }

    // Concrete Command to activate solar panels
    public class ActivatePanelsCommand : ICommand
    {
        private readonly Satellite _satellite;

        public ActivatePanelsCommand(Satellite satellite)
        {
            _satellite = satellite;
        }

        public void Execute()
        {
            _satellite.ActivatePanels();
        }
    }

    // Concrete Command to deactivate solar panels
    public class DeactivatePanelsCommand : ICommand
    {
        private readonly Satellite _satellite;

        public DeactivatePanelsCommand(Satellite satellite)
        {
            _satellite = satellite;
        }

        public void Execute()
        {
            _satellite.DeactivatePanels();
        }
    }

    // Concrete Command to collect data
    public class CollectDataCommand : ICommand
    {
        private readonly Satellite _satellite;

        public CollectDataCommand(Satellite satellite)
        {
            _satellite = satellite;
        }

        public void Execute()
        {
            _satellite.CollectData();
        }
    }

    // Command Invoker
    public class CommandInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Satellite satellite = new Satellite();
            CommandInvoker invoker = new CommandInvoker();

            // Rotate the satellite to East
            invoker.SetCommand(new RotateCommand(satellite, "East"));
            invoker.ExecuteCommand();

            // Activate the solar panels
            invoker.SetCommand(new ActivatePanelsCommand(satellite));
            invoker.ExecuteCommand();

            // Collect data
            invoker.SetCommand(new CollectDataCommand(satellite));
            invoker.ExecuteCommand();

            // Display the current status
            satellite.DisplayStatus();

            // Deactivate the solar panels
            invoker.SetCommand(new DeactivatePanelsCommand(satellite));
            invoker.ExecuteCommand();

            // Attempt to collect data with inactive solar panels
            invoker.SetCommand(new CollectDataCommand(satellite));
            invoker.ExecuteCommand();

            // Display the final status
            satellite.DisplayStatus();
        }
    }
}