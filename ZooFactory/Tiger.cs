﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooFactory.interfaces;

namespace ZooFactory
{
	class Tiger: IAnimalProduct
	{
		public void printName()
		{
			Console.WriteLine("I am tiger.");
		}
	}
}
