namespace Projeto_GFT.src.Entities
{
    public class Strength : Hero
    {

        public Strength(string Name, int Level, string HeroType, string AttackType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.AttackType = AttackType;
        }

        public override string Attack()
        {
            return this.Name + " " + "Atacou com força";

        }
        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " " + "Atacou com força extrema " + Bonus;
            }
            return this.Name + " " + "Atacou com força " + Bonus;
        }



    }
}