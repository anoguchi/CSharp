// Create a welcome method, a method to ask for the user's name, and another to tell that user "Hello <name>". Call these methods from Program.cs

using CreatingAMethod;

SampleMethods.Welcome();
string name = SampleMethods.GetUserName();
SampleMethods.Greetings(name);