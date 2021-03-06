﻿using System;

namespace ObviousCode.Alchemy.Creatures.DecisionProcessing
{
	public class FalsePredicate : Predicate
	{
		public override bool GetValue ()
		{
			return false;
		}

		public override string Describe ()
		{
			return "FALSE";
		}

		public override Predicate CreateNew ()
		{
			return new FalsePredicate ();
		}

		public override PredicateType Type {
			get {
				return Predicate.PredicateType.False;
			}
		}
	}
}

