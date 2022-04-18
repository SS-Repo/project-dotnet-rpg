namespace project_dotnet_rpg.src.Entities
{
    public abstract class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public int level { get; set; } 
        public string heroType { get; set; }
        public int life { get; set; }

        public Character()
        {
            this.life = 100;
            this.name = "";
            this.heroType = "";
        }
        public Character (string name,int level,string heroType,int life,int id){

            this.id = id;
            this.life = life;
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public int LosingLife(int life, int attack){
            return life - attack;
        }

        public override string ToString(){
            return " id:" + this.id + " life:" + this.life + " name:" + this.name + " level:" + this.level + " hero-type:" + this.heroType;
        }

        public virtual string Attack(string action){
            return this.name + " " + action;
        }
    }
}