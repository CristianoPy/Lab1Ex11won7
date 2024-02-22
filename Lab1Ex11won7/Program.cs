/*Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un
numar intreg va verifica urmatoarele
“unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz*/

Console.WriteLine("Introduce numar: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Numarul este unu.");
        break;

    case 2:
        Console.WriteLine("Numarul este doi.");
        break;

    case 3:
        Console.WriteLine("Numarul este trei.");
        break;

    case 5:
        Console.WriteLine("Numarul este cinci.");
        break;

    case 8:
        Console.WriteLine("Numarul este opt.");
        break;

    default:
        Console.WriteLine("Variabila neidentificata.");
        break;
}
Console.ReadLine();
