using System;

namespace MvvmHelpers.UnitTests
{
	public class PersonViewModel : BaseViewModel
	{
	}

	public class Person : ObservableObject
	{
		public Action Changed { get; set; }

		public Func<string, string, bool> Validate { get; set; }

		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set => SetProperty(ref firstName, value, onChanged: Changed, validateValue: Validate);
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set => SetProperty(ref lastName, value, onChanged: Changed, validateValue: Validate);
		}

		public string SortName => FirstName[0].ToString().ToUpperInvariant();
	}
}