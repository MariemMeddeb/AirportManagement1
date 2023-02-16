// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using AM.Core.Domain;

//TP 1 Question 7
Plane plane = new Plane();
plane.Capacity = 30;
plane.ManufactureDate = new DateTime(2000,1,1);
plane.MyPlaneType = PlaneType.Boeing;

//Question8
Plane plane1 = new Plane(PlaneType.Airbus, 100, new DateTime(2002, 1, 2));


//Question9
Plane  plane2 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2004,2,12)
};

//TP1.QUestion12.b
Passenger passenger = new Passenger();
Passenger staff = new Staff();
Passenger traveller = new Traveller();
Console.WriteLine(passenger.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());
Console.WriteLine(traveller.GetPassengerType());

int calculateAge = 0;
passenger.GetAge(new DateTime(2000, 1, 1), ref calculateAge);
Console.WriteLine(calculateAge);
passenger.BirthDate = new DateTime(2000, 1, 1);
passenger.GetAge(passenger);
Console.WriteLine(passenger.GetAge(new DateTime(2000, 1, 1), ref calculateAge));

//question 14
Passenger john = new Passenger(35);
int age = john.getAge();
Console.WriteLine(john.getAge());