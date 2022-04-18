namespace project_dotnet_rpg.src.Entities
{
    public class Knight : Character
    {
        public Knight(int id,string name,int level,string heroType)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public string Attack(){
            return this.name + " Ataque com espada" + " Dano:" + 1;        
        }
    }
}