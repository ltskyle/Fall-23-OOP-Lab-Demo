using OOP_Lab;
Console.Clear();

//Variable to accept user input
string destination;

// Declare and instantiate a spacecraft object
Spacecraft starship = new Spacecraft("Galactic Voyager");

// Toggle the engines on
starship.ToggleEngines();

// Display the state of the spacecraft
Console.WriteLine(starship.ToString());

// Prompt the user for input and store it in the destination variable
Console.WriteLine("Which planet or space station do you want to head to? ");
destination = Console.ReadLine();

// Set the destination of the spacecraft
starship.SetDestination(destination);

// Increase the communication signal of the spacecraft
starship.IncreaseSignal();

// Display the current destination and signal strength
Console.WriteLine("Destination: " + starship.GetDestination() + " \nCommunication Signal Strength: " + starship.GetSignalStrength());

Console.WriteLine("Signal too strong! Lowering the communication signal.");

// Decrease the communication signal
for (int x = 0; x < 6; x++) {
    starship.DecreaseSignal();
}

// Display the current destination and signal strength
Console.WriteLine("Destination: " + starship.GetDestination() + " \nCommunication Signal Strength: " + starship.GetSignalStrength());

// create a blank line
Console.WriteLine();

// HERE IS WHERE YOU DO TASK 5
Spacecraft explorer = new Spacecraft("Galactic Explorer");

explorer.ToggleEngines();

Console.WriteLine(explorer.ToString());

Console.WriteLine("Which planet or space station do you want to head to? ");
destination = Console.ReadLine();
explorer.SetDestination(destination);

for (int i = 0; i < 2; i++) {
    explorer.DecreaseSignal();
}

Console.WriteLine("Destination: " + explorer.GetDestination() + " \nCommunication Signal Strength: " + explorer.GetSignalStrength());
