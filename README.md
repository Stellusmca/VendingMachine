Vending Machine

It is a Pure Visual Studio console application Project. 
It is a simple vending machine that takes in user input and returns the appropriate item and change. The user can input coins and select an item to purchase. 
The program will then calculate the change and return the item and change to the user

Quick Start

Fork and download this repo.
Install .NET Core on your device: https://www.microsoft.com/net/core
Open Visual Studio Console Application and Run the program.

Initial Approach

My approach to this challenge will be guided by three main topics:

OOP & single responsibility

Extendability

TDD & good exception handling

XUnit Testing.


In terms of testing, I need to unit test the main logic behind the application. Since this is a Console application;


My main thoughts on the classes are as follows:


Item class:
I could just use a C# dictionary to input each item and its price. However, i feel like extending this would be a mess as you would be left with a massive dictionary, and what if you wanted to add extra properties to the item such as description or quantity, then the dictionary would bloat up. I have chosen to add an Item class for extendability purposes.
Vending Machine class:
This class will hold instantiated Items as an array property.
Price class:
This class will hold the price of the items and the coins inserted by the user.
Controller class:
This is where all the application comes together, this class wil configure the required loops to run the program; as well as delegate user input to the appropriate class.

Extendability:
By adopting single responsability principles, this program can be easily extended; for example to add a new "item", you would just need to add the item to the Vendor class, the program would function as normal and you would not need to amend anything else.
OOP:
This program demonstrates very good OOP principles throughout its design.
Well tested and good exception handling:
I have unit tested the main classes in this program. Exception handling is designed to never break out of the application.
