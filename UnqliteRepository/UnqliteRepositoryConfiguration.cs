namespace UnqliteRepository
{
	public class UnqliteRepositoryConfiguration : IRepositoryConfiguration
	{
		#region Properties
		public string Filename { get; private set; }
		#endregion


		#region Constructors
		public UnqliteRepositoryConfiguration()
		{
		}
		#endregion

	}
}