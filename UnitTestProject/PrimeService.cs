﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
	public class PrimeService
	{
		public bool IsPrime(int candidate)
		{
			if (candidate < 2)
			{
				return false;
			}
			else if(candidate == 3)
			{
				return false;
			}
			throw new NotImplementedException("Please create a test first");
		}
	}
}
