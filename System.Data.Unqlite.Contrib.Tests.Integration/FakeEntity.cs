namespace System.Data.Unqlite.Contrib.Tests.Integration
{
	public class FakeEntity : IEntity<string>
	{
		public string Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }
	}
}