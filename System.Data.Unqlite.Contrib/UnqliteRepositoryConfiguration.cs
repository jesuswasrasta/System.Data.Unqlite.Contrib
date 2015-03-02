namespace System.Data.Unqlite.Contrib
{
	public class UnqliteRepositoryConfiguration : IRepositoryConfiguration
	{
		#region Constructors
		public UnqliteRepositoryConfiguration()
		{
		}
		#endregion


		#region Properties
		public string Filename { get; private set; }
		#endregion
	}
}