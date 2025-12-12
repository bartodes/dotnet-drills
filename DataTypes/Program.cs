// NUMBERS //
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