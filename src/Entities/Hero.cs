namespace dotnet_poo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {
            
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public int HpMax { get; set; }

        public int MpMax { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }
    }
}