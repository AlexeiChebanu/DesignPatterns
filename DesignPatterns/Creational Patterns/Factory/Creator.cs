using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Factory
{
	public abstract class Creator
	{
		public abstract IProduct FactoryMeethod();
		public string SomeOperation()
		{
			var product = FactoryMeethod();

			return "Creator" + product.Operation();
		}
	}
}
