using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooFactory.factories;
using ZooFactory.interfaces;

namespace ZooFactory
{
	class Program
	{
		static List<ZooAbstractFactory> zooFactoryList = new List<ZooAbstractFactory>();

		static void createFactory()
		{
			zooFactoryList.Add(new LionFactory());
			zooFactoryList.Add(new LionFactory());
			zooFactoryList.Add(new TigerFactory());
			zooFactoryList.Add(new LionFactory());
			zooFactoryList.Add(new LionFactory());
			zooFactoryList.Add(new TigerFactory());
			zooFactoryList.Add(new TigerFactory());
		}

		static void Main(string[] args)
		{
			createFactory();

			List<IAnimalProduct> animalList = new List<IAnimalProduct>();

			foreach (ZooAbstractFactory factory in zooFactoryList)
				animalList.Add(factory.createProduct());

			foreach (IAnimalProduct animal in animalList)
				animal.printName();

			Console.ReadLine();
		}
	}
}
