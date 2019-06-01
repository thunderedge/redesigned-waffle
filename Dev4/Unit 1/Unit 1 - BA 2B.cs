using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA2B
{
    public class Tool
	{
        public int durability;

        public Tool()
		{
			this.durability = 100;
		}
		public virtual void Use()
		{
			this.durability = this.durability - 1;
		}
	}

    class StoneHammer:Tool
	{
        public StoneHammer():base()
		{

		}

        public override void Use()
		{
            this.durability = this.durability - 10;
		}
	}

    class IronHammer : Tool
	{
		public IronHammer():base()
		{

		}
		public override void Use()
		{
			this.durability = this.durability - 2;
		}
	}

    class PhasePistol:Tool
	{
		public PhasePistol():base()
		{

		}
		public override void Use()
		{
			this.durability = this.durability - 5;
		}
	}

    class Tests
    {
        public static void Main(string[] args)
		{
            var[] tools = new[]{ new IronHammer(), new StoneHammer(), new PhasePistol() };
            for (int i = 0; i < 5; i = i + 1)
			{
                for (int j = 0; j < tools.Length; j = j + 1)
                {
                    IronHammer.Use();
					StoneHammer.Use();
					PhasePistol.Use();
				}
			}
		}
	}
}