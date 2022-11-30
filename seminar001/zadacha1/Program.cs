/*
int a = 2;
int b = 3;
int c = 7;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.WriteLine(max);
*/

/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.WriteLine("Write first number ");

int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write second number ");

int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write third number ");

int thirdnumber = Convert.ToInt32(Console.ReadLine());

int max = firstnumber;

if (firstnumber > max) max = firstnumber;
if (secondnumber > max) max = secondnumber;
if (thirdnumber > max) max = thirdnumber;


Console.Write(max);

 



