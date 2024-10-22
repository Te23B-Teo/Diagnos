Console.WriteLine("vällkomen!");

Console.WriteLine("Hur många chanser vill du ha att gissa ordet [1-5]?");

allt();






static void allt(){
string antgiss = Console.ReadLine();

int resultat;
int.TryParse(antgiss, out resultat);
if (resultat >= 1 && resultat <= 5)
{
    for (; resultat > 0; resultat--)
    {
        Console.WriteLine("skriv din gissning:");
        string gissning = Console.ReadLine();
        if (gissning.ToLower() != "hund")
        {
            Console.WriteLine("Nej, det är fel!");
        }
        else if (gissning.ToLower() == "hund"){
            Console.WriteLine("bra gissat, det var rätt Hund var det rätta ordet");
        }
        else if (resultat <= 0){
            Console.WriteLine("tyvärr, du förlorade!");
        }
    }
Console.WriteLine("Du förlorade tryck på ENTER för att avsluta!");
Console.ReadLine();
}
}