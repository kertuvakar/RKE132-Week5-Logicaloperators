//Natuke leebem ülikool
//Math >=90; Chemistry >=90

//Math && Chemistry || Chemistry && Biology  || Math && Biology

int Math, Biology, Chemistry;

Console.WriteLine("Enter your math result:");
Math = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your chemistry result:");
Chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
Biology = Int32.Parse(Console.ReadLine());

if ((Math >= 90 && Chemistry >= 90) || (Chemistry >= 90 && Biology >= 90) || (Math >= 90 && Biology >= 90))
{
    Console.WriteLine("Your are accepted!");
}
else
{
    Console.WriteLine("Your application was denied");
}