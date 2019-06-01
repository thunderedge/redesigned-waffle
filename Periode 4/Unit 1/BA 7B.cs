using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA7B
{
    public class Fighter
    {
        public int healthPoints;
        public int strength;

        public Fighter(int hp, int strength)
        {
            this.healthPoints = hp;
            this.strength = strength;
        }


        public int GetHP()
        {
            return this.healthPoints;
        }

        public virtual int Attack()
        {
            return this.strength;
        }

        public virtual void TakeDamage(int amount)
        {
            this.healthPoints -= amount;
        }
    }

    public class Knight : Fighter
    {
        public double blockChance;

        public Knight(int hp, int strength, double blockChance) : base(hp, strength)
        {
            this.blockChance = blockChance;
        }

        public override void TakeDamage(int amount)
        {
            if (this.Block())
            {
                this.healthPoints -= amount / 4;
            }
            else
            {
                this.healthPoints -= amount;
            }
        }

        public bool Block()
        {
            Random random = new Random(this.healthPoints);
            return (this.blockChance >= random.NextDouble());
        }
    }

    public class Paladin : Knight
    {
        public Paladin(int hp, int strength, double blockChance) : base(hp, strength, blockChance)
        {
            this.blockChance += 0.1;
        }

        public override void TakeDamage(int amount)
        {
            if (this.Block())
            {
                this.healthPoints -= amount / 4;
            }

            if (this.healthPoints >= 0)
            {
                // Whenever a Paladin blocks, they heal a bit of their healthPoints.
                this.healthPoints += this.HealAmount();
            }
            else
            {
                this.healthPoints -= amount;
            }
        }

        public int HealAmount()
        {
            return strength / 5;
        }
    }

    public class DarkKnight : Knight
    {
        public double critChance;

        public DarkKnight(int hp, int strength, double blockChance, double critChance) : base(hp, strength, blockChance)
        {
            this.blockChance = 0.25;
            this.critChance = 0.3;
        }

        public override int Attack()
        {
            if (this.CriticalHit())
            {
                // Dark Knights have a chance to double their damage.
                return 2 * this.strength;
            }
            else
            {
                return this.strength;
            }
        }

        public bool CriticalHit()
        {
            Random random = new Random(this.healthPoints);
            return (this.critChance >= random.NextDouble());
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            var paladin = new Paladin(1200, 100, 0.25);
            var darkKnight = new DarkKnight(1000, 120, 0.25, 0.30);

            // The paladin and the dark knight are about to duke it out!

            int damage2Paladin;
            int damage2DarkKnight;

            while (paladin.GetHP() > 0 && darkKnight.GetHP() > 0)
            {
                damage2DarkKnight = paladin.Attack();
                darkKnight.TakeDamage(damage2DarkKnight);
                damage2Paladin = darkKnight.Attack();
                paladin.TakeDamage(damage2DarkKnight);
            }

            string outcome;

            if (paladin.GetHP() > 0 && darkKnight.GetHP() <= 0)
            {
                outcome = "A glorious victory for the Paladin!";
            }
            else if (paladin.GetHP() <= 0 && darkKnight.GetHP() > 0)
            {
                outcome = "The Dark Knight has risen!";
            }
            else
            {
                outcome = "In war there are no winners, only widows.";
            }
        }
    }
}
