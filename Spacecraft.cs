namespace OOP_Lab
{
    public class Spacecraft
    {
        private string craftName;
        private string destination;
        private bool enginesOn;
        private int fuelLevel;
        private int numPassengers;

        // Constructor creates an instance of the Spacecraft class, object
        public Spacecraft(string craftName)
        {
            this.craftName = craftName;
            destination = "Orbit"; // Default destination
            enginesOn = false; // Default engine off
            fuelLevel = 100;  // Default fuel level
            numPassengers = 11;  // Default number of passengers
        }

        // Gets the number of passengers and returns it
        public int GetNumPassengers()
        {
            return numPassengers;
        }

        // Gets the destination and returns it
        public string GetDestination()
        {
            return destination;
        }

        // Gets the craft name and returns it
        public string GetCraftName()
        {
            return craftName;
        }

        // Sets destination equal to user input destination
        public void SetDestination(string destination)
        {
            this.destination = destination;
        }

        // Gets the fuel level and returns it
        public int GetFuelLevel()
        {
            return fuelLevel;
        }

        // Toggles the spacecraft's engine state
        public void ToggleEngines()
        {
            enginesOn = !enginesOn;
        }

        // Increases the number of passengers by 1
        public void AddPassenger()
        {
            numPassengers += 1;
        }

        // Decreases the number of passengers by 1
        public void RemovePassenger()
        {
            numPassengers -= 1;
        }

        // Represents the current state of the spacecraft as a string
        public override string ToString()
        {
            if (enginesOn) {
                return "The spacecraft " + craftName + " heading to " + destination + " has its engines activated.";
            }
            else {
                return "The spacecraft " + craftName + " heading to " + destination + " has its engines deactivated.";
            }
        }
    }
}
