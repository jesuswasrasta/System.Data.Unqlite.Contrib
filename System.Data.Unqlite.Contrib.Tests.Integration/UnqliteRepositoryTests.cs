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
			var repo = new UnqliteRepository<FakeEntity, string>();

			Assert.Throws<ArgumentNullException>(() => repo.Setup(null));
		}

		[Test]
		public void UnqliteRepository_SetConfiguration_ConfigurationNotNull_DoesNotThrowsException()
		{
			var configurationMock = new Mock<IRepositoryConfiguration>();
			var repo = new UnqliteRepository<FakeEntity, string>();
			
			Assert.DoesNotThrow(() => repo.Setup(configurationMock.Object));
		}

		[Test]
		public void UnqliteRepository_AddEntity_EntityCanBeRetrievedById()
		{
			var fakeEntity = new FakeEntity
			{
				Id = "1qazxsw2", 
				FirstName = "Ted", 
				LastName = "Codd"
			};

			var repo = new UnqliteRepository<FakeEntity, string>();
			repo.Add(fakeEntity);

			var entityRetrieved = repo.GetById(fakeEntity.Id);

			Assert.AreEqual(entityRetrieved, fakeEntity);
		}
	}
}
