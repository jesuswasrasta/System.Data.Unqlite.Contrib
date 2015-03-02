#region Usings
using System.Runtime.Serialization;


#endregion


namespace System.Data.Unqlite.Contrib
{
	/// <summary>
	///     Abstract Entity for all the common entities.
	/// </summary>
	[DataContract]
	[Serializable]
	public abstract class BaseEntity : IEntity<string>, IDisposable
	{
		#region Fields
		private bool _disposed;
		#endregion


		#region Public Properties
		/// <summary>
		///     Gets or sets the id for this object (the primary record for an entity).
		/// </summary>
		/// <value>The id for this object (the primary record for an entity).</value>
		[DataMember]
		public virtual string Id { get; set; }
		#endregion


		#region Dispose
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				//do dispose thing you need to
			}

			_disposed = true;
		}

		public virtual void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~BaseEntity()
		{
			Dispose(false);
		}
		#endregion
	}
}