using MvvmHelpers.Commands;

using System.Threading.Tasks;

#nullable enable

namespace MvvmHelpers.UnitTests
{
	public class TestFile
	{
		public AsyncCommand<string> MyCommand { get; }

		public TestFile()
		{
			MyCommand = new AsyncCommand<string>(Test, null);
		}

		private Task Test(string test) => Task.CompletedTask;
	}
}