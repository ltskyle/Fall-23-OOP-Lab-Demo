using OOP_Lab;
Console.Clear();

//Variable to accept user input
string destination;

// Declare and instantiate a spacecraft object
Spacecraft starship = new Spacecraft("Enterprise");

// Toggle the engines on
starship.ToggleEngines();

// Display the state of the spacecraft
Console.WriteLine(starship.ToString());

// Prompt the user for input and store it in the destination variable
Console.WriteLine("Which planet or space station do you want to head to? ");
destination = Console.ReadLine();

// Set the destination of the spacecraft
starship.SetDestination(destination);

// Increase the number of passengers in the spacecraft
starship.AddPassenger();

// Display the current destination and signal strength
Console.WriteLine("Destination: " + starship.GetDestination() + " \nNumber of Passengers: " + starship.GetNumPassengers());

Console.WriteLine("Too much weight! Kicking passengers off spacecraft.");

// Decrease the number of passengers
for (int x = 0; x < 6; x++) {
    starship.RemovePassenger();
}

// Display the current destination and signal strength
Console.WriteLine("Destination: " + starship.GetDestination() + " \nNumber of Passengers: " + starship.GetNumPassengers());

// create a blank line
Console.WriteLine();


// HERE IS WHERE YOU DO TASK 5
System.Console.WriteLine("Time to make a new spacecraft!\n");

Spacecraft explorer = new Spacecraft("Voyager");

explorer.ToggleEngines();


Console.WriteLine(explorer.ToString());

for (int i = 0; i < 2; i++) {
    explorer.RemovePassenger();
}

System.Console.WriteLine("Number of passengers: " + explorer.GetNumPassengers());

Console.WriteLine("Which planet or space station do you want to head to? ");
destination = Console.ReadLine();
explorer.SetDestination(destination);



Console.WriteLine("Destination: " + explorer.GetDestination());
