using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    /*This interface is generic becuase this repository should be able to handle all the classes like category, users,....
     IRepository<T> where T : class => this is the way how you make your repository generic
     */
    public interface IRepository<T> where T : class
    {
        // T = Category
        // Method to edit a category
        T GetFirstOrDefault(Expression<Func<T,bool>>filter);
        // method to get all the categories
        IEnumerable<T> GetAll();
        // Method to add a category
        void Add(T entity);

        // Method to delete a category
        void Remove(T entity);
        // Method to remove more than one entity
        void RemoveRange(IEnumerable<T> entity);

    }
}
