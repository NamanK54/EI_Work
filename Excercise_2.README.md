Excercise 2

Problem Statement : Satellite Command System

Satellite Command System is a well-rounded exercise that involves state management, command execution, and the use of design patterns. Here's how we can approach it.

Goal : Create a console-based application that simulates controlling a satellite in orbit. The satellite starts in a default state and can accept a series of commands to change its orientation, 
manage its solar panels, and collect data.

1) Functional Requirements

Initialize the Satellite : The satellite should start with the following default state :-

Orientation : "North"

Solar Panels : "Inactive"

Data Collected : 0

Rotate : Implement a command called rotate that takes a direction parameter (North, South, East, West) and sets the satellite’s orientation accordingly.

Activate/Deactivate Solar Panels : Implement commands called activatePanels and deactivatePanels to control the solar panels' status.

Collect Data : Implement a command called collectData that increments the "Data Collected" attribute by 10 units, but only if the solar panels are "Active."

2) Key Focus Areas
   
Behavioral Pattern : Use the Command Pattern to encapsulate the different commands (rotate, activatePanels, deactivatePanels, collectData) as objects.

State Management : Manage the satellite’s state through its various attributes (Orientation, Solar Panels, Data Collected).

Logging & Error Handling : Ensure the application handles errors gracefully and logs important actions.

Step 2 : Design the Solution

Class Structure

Satellite : This class will represent the satellite, holding its current state (orientation, solar panels, data collected) and methods to manipulate that state.

Command Interface : An interface for all commands that the satellite can execute (e.g., rotate, activatePanels, collectData).

Concrete Command Classes : Separate classes for each command (e.g., RotateCommand, ActivatePanelsCommand, CollectDataCommand), implementing the Command interface.

Command Invoker : A class responsible for invoking commands. It could also manage the history of executed commands, allowing for features like undo.

Step 3 : Solution Execution (in_Code)

Step 4 : Explanation

Satellite Class : Holds the current state of the satellite (orientation, solar panel status, and data collected) that provides methods to change the satellite’s state.

Command Interface : An interface ICommand defines the Execute() method that all concrete commands must implement.

Concrete Commands : Separate classes (RotateCommand, ActivatePanelsCommand, etc.) implement the ICommand interface to perform specific actions on the satellite.

Command Invoker : The class is responsible for executing the commands. It allows us to easily add more commands in the future without changing the existing code.

Program Class : Class simulates the satellite operations by executing various commands and displaying the satellite’s status.

Step 5 : Code Result

After execution, it will simulate a series of satellite operations. The output states :-

Satellite rotated to East.

Solar panels activated.

Data collected. Total data: 10 units.

Orientation : East, Solar Panels : Active, Data Collected : 10 units.

Solar panels deactivated.

Cannot collect data. Solar panels are inactive.

Orientation : East, Solar Panels : Inactive, Data Collected : 10 units.

Hence, the output shows that the satellite responds to commands correctly, maintains its state, and handles edge cases (like attempting to collect data with inactive solar panels) gracefully.

At the end, the Satellite Command System showcases the use of the Command Pattern to manage a satellite’s state and execute various operations. 
The design is modular, making it easy to extend with new commands or modify existing ones.
