using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooFactory.interfaces;

namespace ZooFactory.factories
{
	abstract class ZooAbstractFactory
	{
		public abstract IAnimalProduct createProduct();
	}
}
