using System;

namespace CrossAPp
{
	public class Bill
	{
		public Bill ()
		{
			
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public int Day { get; set; }

		public double Value { get; set; }

		public override string ToString ()
		{
			return Name;
		}
	}
}

