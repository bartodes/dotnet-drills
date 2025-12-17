// NUMBERS //
using System.Security.Cryptography;

int age;
age = 23;

Console.WriteLine(age);
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);

// O hacerlo en un misma linea
long num = 9000000; // Poniendo una L mayuscula al final nos aseguramos que sea de tipo Long sino lo  especificamos al inicializar la var
Console.WriteLine(num);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);


double negnum = -23.09D;
Console.WriteLine(negnum);
Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);

float fnum = 4.000F;
Console.WriteLine(fnum);
Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);

decimal dolars = 3.05M;
Console.WriteLine(dolars);
Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);


// We also can defin  e vars like this

int x = 3,
    y = 2,
    z = -1;
Console.WriteLine($"x: {x}, y: {y}, z: {z}");

// STRINGS //

// Text based data types are strict with the use of " or '.
// string -> ""
// char -> ''

string name = "Barto";
char letra = 'c'; // You cant store an empty char literal
Console.WriteLine(name);
Console.WriteLine(letra);

// CONVERSIONS //
string textNum = "103";
int someNum = Convert.ToInt32(textNum);
Console.WriteLine(textNum.GetType());
Console.WriteLine(someNum.GetType());

string textBigNum = "-90000000000";
long bigNum = Convert.ToInt64(textBigNum);

Console.WriteLine(bigNum);
Console.WriteLine(bigNum.GetType());

// BOOLEAN //

bool someVal = true;
Console.WriteLine(someVal);
someVal = false;
Console.WriteLine(someVal);


// OPERATORS //

Console.WriteLine(age);
age++;
Console.WriteLine(age);
age--;
Console.WriteLine(age);
age += 4;
Console.WriteLine(age);
age -= 4;
Console.WriteLine(age);
age *= 3;
Console.WriteLine(age);
age /= 2; // When we divide two int, we obtain a rounded resoult
Console.WriteLine(age);
double someDouble = 69;
someDouble /= 2;
Console.WriteLine(someDouble);

// Concatenation with + operator
string student = "Pepe";
student += " esta programando en C#!";
Console.WriteLine(student);

// With char type it sums the unicode and gives us the char it is equivalent to
char c = 'a';
c += 'b';
Console.WriteLine(c);

// Operator ++ and -- sequence
int i = 0;
Console.WriteLine(i++); // When the ++ is after the var it excecutes after 
Console.WriteLine(i);