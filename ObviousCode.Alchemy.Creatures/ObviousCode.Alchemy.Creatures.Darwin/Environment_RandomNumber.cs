﻿using System;
using ObviousCode.Alchemy.Library.Populous;
using ObviousCode.Alchemy.Library;
using System.Collections.Generic;

namespace ObviousCode.Alchemy.Creatures.Darwin
{
	public class Environment_RandomNumber : Environment
	{
		public Environment_RandomNumber () : base ("Random")
		{
		}

		protected override Population<byte> ExecuteOneGeneration ()
		{
			return Engine.ExecuteOneGeneration ();
		}

		protected override double Evaluate (Creature creature)
		{
			Random random = new Random ();
					
			int i = 0;
			double fitness;

			while (creature.IsAlive && i < LifetimeIterations) {
				creature.Digest (random.Next (1000));	
				i++;
			}
				
			if (creature.IsAlive) {	
				fitness = Math.Min (.9999999999d, .5d + (((double)creature.Energy / 1000d) / 2d));//.5->.99995 (or .99999999)
			} else {
				fitness = (Math.Max (1d, (double)i) / (double)LifetimeIterations) / 2d;//.005 -> .5
			}				

			creature.Fitness = fitness;

			return fitness;
		}

		protected override void PrepareForNextGeneration ()
		{
		}
	}
}