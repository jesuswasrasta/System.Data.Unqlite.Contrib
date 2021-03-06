﻿#region Usings
using System.Runtime.Serialization;


#endregion


namespace System.Data.Unqlite.Contrib
{
	/// <summary>
	///     Abstract Entity for all the common entities.
	/// </summary>
	[DataContract]
	[Serializable]
	public abstract class BaseEntity : IEntity<string>
	{
		#region Public Properties
		/// <summary>
		///     Gets or sets the id for this object (the primary record for an entity).
		/// </summary>
		/// <value>The id for this object (the primary record for an entity).</value>
		[DataMember]
		public virtual string Id { get; set; }
		#endregion
	}
}