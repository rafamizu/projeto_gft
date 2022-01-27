namespace Projeto_GFT.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, string AttackType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.AttackType = AttackType;

        }

        public Hero()
        {

        }


        public string Name;
        public int Level;
        public string HeroType;

        public string AttackType;


        public override string ToString()
        {
            return this.Name;
        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com sua espada";
        }
    }
}