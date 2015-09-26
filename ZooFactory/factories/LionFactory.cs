using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooFactory.interfaces;
using ZooFactory.products;

namespace ZooFactory.factories
{
	class LionFactory : ZooAbstractFactory
	{
		public override IAnimalProduct createProduct()
		{
			return new Lion();
		}
	}
}
