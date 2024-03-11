// See https://aka.ms/new-console-template for more information

String[] names = new string[10];

for (int x=0; x < 10; x++)
{
    Console.WriteLine(" Escriba su nombre");
    names[x] = Console.ReadLine();
}

foreach (string x in names)
    Console.WriteLine(x);
