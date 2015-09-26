using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooFactory.interfaces;

namespace ZooFactory.factories
{
	class TigerFactory : ZooAbstractFactory
	{
		public override IAnimalProduct createProduct()
		{
			return new Tiger();
		} 
	}
}
