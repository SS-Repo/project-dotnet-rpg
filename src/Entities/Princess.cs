namespace project_dotnet_rpg.src.Entities
{
    public class Princess : Character
    {
        public Princess(int id,string name,int level,string heroType)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

         public string Attack(){
            return this.name + " Não tem ataque" + " Dano:" + 0;
        }
        
    }
}