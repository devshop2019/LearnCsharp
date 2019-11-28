using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMultiColumnSort
{
	public partial class DemoMultiColumnSort : Form
	{
		List<Person> programmers;

		public DemoMultiColumnSort()
		{
			InitializeComponent();

			InitialiseProgrammers();
			PopulateGrid();
		}

		private void PopulateGrid()
		{
			foreach (Person programmer in programmers)
			{
				int rowNum = PersonGrid.Rows.Add( new object[] { programmer.ID,
					programmer.FirstName,programmer.LastName, programmer.Date,
					programmer.Region,
					programmer.Level, programmer.Level.ToString()});
				PersonGrid.Rows[rowNum].Tag = programmer;
			}
		}

		private void InitialiseProgrammers()
		{
			programmers = new List<Person>();

			AddPerson(1924, "Dennis", "Ritchie", new DateTime(1971, 11, 3), OriginRegion.US, Level.Guru);
			AddPerson(1025, "Dennis", "Menace", new DateTime(1938, 7, 26), OriginRegion.EU, Level.Beginner);
			AddPerson(2335, "Bjarne", "Stroustrup", new DateTime(1997, 11, 14), OriginRegion.EU, Level.Guru);
			AddPerson(3378, "Don", "Box", new DateTime(1997, 8, 7), OriginRegion.US, Level.Guru);
			AddPerson(7045, "Paul", "Anderson", new DateTime(2007, 3, 16), OriginRegion.EU, Level.Intermediate);
			AddPerson(8972, "Kevin", "Hoover", new DateTime(2002, 4, 23), OriginRegion.EU, Level.Intermediate);
			AddPerson(6241, "Melinda", "Box", new DateTime(1979, 12, 20), OriginRegion.EU, Level.Advanced);
			AddPerson(1234, "David", "Ritchie", new DateTime(1983, 9, 26), OriginRegion.US, Level.Advanced);
			AddPerson(4321, "Bjarne", "Menace", new DateTime(1997, 8, 7), OriginRegion.EU, Level.Advanced);
			AddPerson(5801, "Don", "Menace", new DateTime(1997, 8, 7), OriginRegion.EU, Level.Beginner);
			AddPerson(7801, "Jonquil", "Menace", new DateTime(1997, 8, 17), OriginRegion.EU, Level.Beginner);
			AddPerson(5801, "Dennis", "Dodger", new DateTime(1997, 8, 27), OriginRegion.EU, Level.Beginner);
			AddPerson(7802, "Nick", "Menace", new DateTime(1997, 8, 7), OriginRegion.EU, Level.Advanced);
			AddPerson(5423, "Bud", "Box", new DateTime(1997, 8, 7), OriginRegion.US, Level.Beginner);
			AddPerson(8423, "Brian", "Hoover", new DateTime(1987, 8, 17), OriginRegion.US, Level.Intermediate);
		}

		private void AddPerson(int id, string firstName, string lastName, DateTime date, OriginRegion region, Level level)
		{
			programmers.Add(new Person(id, firstName, lastName, date, region, level));
		}

		private void PersonGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			toolStripStatusLabel.Text = PersonGrid.SortOrderDescription;
		}
	}
}