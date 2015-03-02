using Moq;

using NUnit.Framework;


namespace System.Data.Unqlite.Contrib.Tests.Integration
{
	[TestFixture]
	public class UnqliteRepositoryTests
	{
		[SetUp]
		public void Setup()
		{

		}

		[TearDown]
		public void Teardown()
		{

		}


		[Test]
		public void UnqliteRepository_SetConfiguration_ConfigurationNull_ThrowsException()
		{
			var entity = new Mock<IEntity<string>>();

			var repo = new UnqliteRepository<BaseEntity, string>();
		}
	}
}
