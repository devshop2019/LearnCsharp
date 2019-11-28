using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMultiColumnSort
{
	public enum Level
	{
		Beginner,
		Intermediate,
		Advanced,
		Guru,
	}

	public enum OriginRegion
	{
		EU,
		US,
	}
	class Person
	{
		public int ID;
		public string FirstName;
		public string LastName;
		public DateTime Date;
		public OriginRegion Region;
		public Level Level;

		public Person(int id, string firstName, string lastName, DateTime date, OriginRegion region, Level level)
		{
			ID = id;
			FirstName = firstName;
			LastName = lastName;
			Date = date;
			Region = region;
			Level = level;
		}
	}
}
