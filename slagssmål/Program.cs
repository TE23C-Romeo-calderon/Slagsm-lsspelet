int GodHP = 100;
int DevilHP = 100;

string GodName = "GOD";
string DevilName = "DEVIL";

while (GodHP > 0 && DevilHP > 0)
{
  Console.WriteLine("========= Ny runda =========");
  Console.WriteLine($"{GodName}: {GodHP}  {DevilName}: {DevilHP}");

  int GodDamage = Random.Shared.Next(20);
  DevilHP -= GodDamage;
  DevilHP = Math.Max(0, DevilHP);

  Console.WriteLine($"{GodName} gör {GodDamage} skada på {DevilName}");

  int DevilDamage = Random.Shared.Next(20);
  GodHP -= DevilDamage;
  GodHP = Math.Max(0, GodHP);

  Console.WriteLine($"{DevilName} gör {DevilDamage} skada på {GodName}");
  Console.WriteLine("Tryck på vilken knapp som helst för att fortsätta.");
  Console.ReadKey();
}

  Console.WriteLine("======== Striden är över ========");

if (GodHP == 0 && DevilHP == 0)
{ 
  Console.WriteLine("Oavgjort");
}
else if (GodHP == 0)
{
  Console.WriteLine($"{DevilName} Vann!");
}
else
{
  Console.WriteLine($"{GodName} Vann!");
}

  Console.WriteLine("Tryck på vilken knapp som helst för att sluta.");
  Console.ReadKey();
  