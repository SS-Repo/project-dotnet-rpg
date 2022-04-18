namespace project_dotnet_rpg.src.Entities
{
    public class Monster : Character
    {
        public Monster(int id,string name,int level,string heroType)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

         public string Attack(int bonus){
            if( bonus > 30 ){
                return this.name + " Ataque com Fogo Super Potente - Dano:" + bonus;
            }else{
                return this.name + " Ataque com Fogo - Dano:" + bonus;
            }
        }
    }
}