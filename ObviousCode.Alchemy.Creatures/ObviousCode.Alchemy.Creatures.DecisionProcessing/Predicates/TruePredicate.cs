﻿using System;

namespace ObviousCode.Alchemy.Creatures.DecisionProcessing
{
	public class TruePredicate : Predicate
	{
		public override bool GetValue ()
		{
			return true;
		}

		public override string Describe ()
		{
			return "TRUE";
		}

		public override Predicate CreateNew ()
		{
			return new TruePredicate ();
		}

		public override PredicateType Type {
			get {
				return Predicate.PredicateType.True;
			}
		}
	}
}

