using System;
//Project 1
Console.WriteLine("Type any number between 1 and 10:  ");
int input1;
if (int.TryParse(Console.ReadLine(), out input1))
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}


//Project 2 + 3 Write a program which takes two numbers from the console and displays the maximum of the two.
Console.WriteLine("Type a number describing an image's height and then width and I will share if it is landscape or portrait");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);
string input3 = Console.ReadLine();
int num3 = int.Parse(input3);

if (num2 > num3)
{
    Console.WriteLine("The image is Portrait because " + input2 + " is greater than " + input3 + "." );
}
else if (num2 < num3)
{
    Console.WriteLine("The Image is Landscape because " + input3 + " is greater than " + input2 + ".");
}
else
{
    Console.WriteLine("Your input is neither landscape nor portrait");
}

//project 4. Ask Speed limit, then speed of car, If Carspeed<limit display ok on console, if Carspeed>limit calculate how many points to give, 1 point for every 5km above limit, display points, if points>12 display "license suspended"
// int speedlimit = int.Parse((Console.ReadLine()));

string speedlimit = (Console.ReadLine());
Console.WriteLine("The Speed Limit is " + speedlimit + " miles per hour");
string carspeed = Console.ReadLine();
Console.WriteLine("The vehicle was going " + speedlimit + " miles per hour");

int limit = int.Parse(speedlimit);
int car = int.Parse(carspeed);
int pointsoff = (car - limit)/5;

}
if (limit >= car)
{
    Console.WriteLine("The vehicle's speed was acceptable");
}
else if (car > limit)
{
    Console.WriteLine("The Vehicle's speed was not acceptable");
    Console.WriteLine("You have been penalized " + pointsoff + " points");
    if (pointsoff > 12)
    {
        Console.WriteLine("You have incurred over the maximum of 12 points. Your License has been suspended");
    }
}