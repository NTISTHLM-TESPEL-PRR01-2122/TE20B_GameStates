
string room = "start";

while (room != "end")
{
  if (room == "start")
  {
    Console.WriteLine("Du är i första rummet!");
    Console.WriteLine("Du ser en dörr. Vill du gå in genom den?");
    string a = Console.ReadLine();
    if (a == "yes")
    {
      room = "hallway";
    }
  }

  else if (room == "hallway")
  {
    Console.WriteLine("Du är i en korridor!");
    Console.WriteLine("Du har en dörr bakom dig, och ett hål framför dig.");
    Console.WriteLine("Vill du hoppa ner i hålet eller går du bakåt?");
    string a = Console.ReadLine();
    if (a == "hoppa")
    {
      room = "end";
    }
    else if (a == "bakåt")
    {
      room = "start";
    }
  }

}