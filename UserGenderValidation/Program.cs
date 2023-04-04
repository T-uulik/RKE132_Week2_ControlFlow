
//rakendus küsib kasutajal valida tema sugu (M/F)
//rakendus küsib kasutajal sisestada tema perekonna nime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [Kasutaja perekonnanimi] / "Welcome, Ms [Kasutaja perekonnanimi]"

using System.ComponentModel.Design;

Console.WriteLine("Please, enter your name");
string userName = Console.ReadLine();

Console.WriteLine("Please, select your gender (M/F):");
char userGender = Char.Parse(Console.ReadLine());

if (userGender == 'M')
{
    Console.WriteLine($"Welcome, Mr.{userName},!");
}
else if (userGender == 'F')
{
    Console.WriteLine($"Welcome Ms.{userName},!");
}
else
{
    Console.WriteLine($"Welcomeˇ,{userName}!");
}
