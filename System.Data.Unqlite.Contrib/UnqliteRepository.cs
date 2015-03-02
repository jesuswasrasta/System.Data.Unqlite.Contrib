#region Usings
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


#endregion


namespace System.Data.Unqlite.Contrib
{
	/// <summary>
	///     Unqlite repository.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	public class UnqliteRepository<T, TKey> : IRepository<T, TKey> where T : IEntity<TKey>, IDisposable
	{
		/// <summary>
		///     Sets up the repository configuration.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Setup(IRepositoryConfiguration configuration)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Opens this instance.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="openMode"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Open(string fileName, UnqliteOpenMode openMode)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Returns the T by its given id.
		/// </summary>
		/// <param name="id">The value representing the ObjectId of the entity to retrieve.</param>
		/// <returns>
		///     The Entity T.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public T GetById(TKey id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Returns a collection of <see cref="T" /> that satisfies the <see cref="predicate" />.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Adds the new entity in the repository.
		/// </summary>
		/// <param name="entity">The entity to add.</param>
		/// <returns>
		///     The added entity including its new ObjectId.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public T Add(T entity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Adds the new entity in the repository.
		/// </summary>
		/// <param name="entities"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Add(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Upserts an entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns>
		///     The updated entity.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public T Update(T entity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Upserts an entity.
		/// </summary>
		/// <param name="entities"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Update(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Deletes an entity from the repository by its id.
		/// </summary>
		/// <param name="id">The entity's id.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Delete(TKey id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Deletes an entity from the repository by its id.
		/// </summary>
		/// <param name="entity"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Deletes an entity from the repository by its id.
		/// </summary>
		/// <param name="predicate"></param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Delete(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Deletes all entities in the repository.
		/// </summary>
		/// <exception cref="System.NotImplementedException"></exception>
		public void DeleteAll()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Counts the total entities in the repository.
		/// </summary>
		/// <returns>
		///     Count of entities in the repository.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public long Count()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Checks if the entity exists for given predicate.
		/// </summary>
		/// <param name="predicate">The expression.</param>
		/// <returns>
		///     True when an entity matching the predicate exists, false otherwise.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public bool Exists(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///     Closes this instance.
		/// </summary>
		/// <exception cref="System.NotImplementedException"></exception>
		public void Close()
		{
			throw new NotImplementedException();
		}
	}
}