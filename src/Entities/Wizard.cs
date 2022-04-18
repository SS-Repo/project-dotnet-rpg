namespace project_dotnet_rpg.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(int id,string name,int level,string heroType)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

         public string Attack(){
            return this.name + " Lançou Magia";
        }

        public string Attack(int bonus){
            if(bonus > 6 ){
                return this.name + " Lançou Magia Super Efetiva - Dano:" + bonus;
            }else{
                return this.name + " Lançou Magia Fraca - Dano:" + bonus;
            }
        }
    }
}