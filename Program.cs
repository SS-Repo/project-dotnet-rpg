using project_dotnet_rpg.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight arus = new Knight(1,"Arus",12,"Knight");
        Wizard jennica = new Wizard(2,"Jennica",12,"White Wizard");
        Princess diana = new Princess(3,"Diana",3,"Princess");
        Monster dragon = new Monster(4,"Dragon",51,"Monster");

        Console.WriteLine("Dragon Quest - DIO - RPG\n");

        Console.WriteLine("Personagens: \n" );
        Console.WriteLine($"HERO:{arus}  \nBOSS:{jennica}  \nPRINCESS:{diana}  \nMONSTER:{dragon} \n");

        Console.WriteLine("------------------------------------------------------------------------- \n");
        
        Console.WriteLine("Tipos de Ataques \n");

        Console.WriteLine(arus.Attack() + "\n" );
        Console.WriteLine(jennica.Attack(10) + " \n");
        Console.WriteLine(diana.Attack() + " \n");
        Console.WriteLine(dragon.Attack(31) + "\n");

        Console.WriteLine("------------------------------------------------------------------------- \n");

        Console.WriteLine("**Rodada - 1**\n");

        Console.WriteLine("Dragao ataca cavaleiro - " + dragon.Attack(31) + "\n");
        Console.WriteLine("Cavaleiro - life:" + arus.LosingLife(arus.life,31) + "\n");

        Console.WriteLine("**Rodada - 2**\n");

        Console.WriteLine("Mago ataca dragao - " + jennica.Attack(50) + "\n");
        Console.WriteLine("Dragao - life:" + dragon.LosingLife(dragon.life,50));
    }
}
