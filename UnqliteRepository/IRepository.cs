#region Usings
using System;
using System.Collections.Generic;
using System.Data.Unqlite;
using System.Linq;
using System.Linq.Expressions;


#endregion


namespace UnqliteRepository
{
	/// <summary>
	///     IRepository definition.
	/// </summary>
	/// <typeparam name="T">The type contained in the repository.</typeparam>
	/// <typeparam name="TKey">The type used for the entity's Id.</typeparam>
	public interface IRepository<T, in TKey> where T : IEntity<TKey>, IDisposable
	{
		/// <summary>
		/// Sets up the repository configuration.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		void Setup(IRepositoryConfiguration configuration);

		/// <summary>
		/// Opens this instance.
		/// </summary>
		void Open(string fileName, UnqliteOpenMode openMode);

		/// <summary>
		///     Returns the T by its given id.
		/// </summary>
		/// <param name="id">The value representing the ObjectId of the entity to retrieve.</param>
		/// <returns>The Entity T.</returns>
		T GetById(TKey id);

		/// <summary>
		///		Returns a collection of <see cref="T"/> that satisfies the <see cref="predicate"/>.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		IQueryable<T> Get(Expression<Func<T, bool>> predicate);


		/// <summary>
		///     Adds the new entity in the repository.
		/// </summary>
		/// <param name="entity">The entity to add.</param>
		/// <returns>The added entity including its new ObjectId.</returns>
		T Add(T entity);

		/// <summary>
		///     Adds the new entities in the repository.
		/// </summary>
		/// <param name="entities">The entities of type T.</param>
		void Add(IEnumerable<T> entities);

		/// <summary>
		///     Upserts an entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <returns>The updated entity.</returns>
		T Update(T entity);

		/// <summary>
		///     Upserts the entities.
		/// </summary>
		/// <param name="entities">The entities to update.</param>
		void Update(IEnumerable<T> entities);

		/// <summary>
		///     Deletes an entity from the repository by its id.
		/// </summary>
		/// <param name="id">The entity's id.</param>
		void Delete(TKey id);

		/// <summary>
		///     Deletes the given entity.
		/// </summary>
		/// <param name="entity">The entity to delete.</param>
		void Delete(T entity);

		/// <summary>
		///     Deletes the entities matching the predicate.
		/// </summary>
		/// <param name="predicate">The expression.</param>
		void Delete(Expression<Func<T, bool>> predicate);

		/// <summary>
		///     Deletes all entities in the repository.
		/// </summary>
		void DeleteAll();

		/// <summary>
		///     Counts the total entities in the repository.
		/// </summary>
		/// <returns>Count of entities in the repository.</returns>
		long Count();

		/// <summary>
		///     Checks if the entity exists for given predicate.
		/// </summary>
		/// <param name="predicate">The expression.</param>
		/// <returns>True when an entity matching the predicate exists, false otherwise.</returns>
		bool Exists(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Closes this instance.
		/// </summary>
		void Close();
	}
}