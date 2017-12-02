namespace RyanPenfold.BusinessBase.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class BaseService<T> : IService<T>
    {
        protected IRepository<T> Repository; 

        /// <summary>
        /// Find all the <see cref="T"/> instances.
        /// </summary>
        /// <returns>A set of <see cref="T"/> instances.</returns>
        public IList<T> FindAll()
        {
            return this.Repository.FindAll();
        }

        /// <summary>
        /// Attempts to find an <see cref="T"/> instance with the given identifier.
        /// </summary>
        /// <param name="id">
        /// The identifier of the instance to search for
        /// </param>
        /// <returns>
        /// A <see cref="T"/> if found, otherwise null
        /// </returns>
        public T FindById(object id)
        {
            return this.Repository.FindById(id);
        }

        /// <summary>
        /// Generates a new identifier
        /// </summary>
        /// <returns>A new identifier</returns>
        public object NewId()
        {
            return this.Repository.NewId(this.Repository.TypeMap.PrimaryKeyColumnNames.First());
        }

        /// <summary>
        /// Removes a <see cref="T" /> instance from a repository.
        /// </summary>
        /// <param name="subject">The instance to remove</param>
        public void Remove(T subject)
        {
            this.Repository.Remove(subject);
        }

        /// <summary>
        /// Saves a <see cref="T" /> instance to a repository.
        /// </summary>
        /// <param name="subject">The instance to save</param>
        public void Save(T subject)
        {
            this.Repository.Save(subject);
        }
    }
}
