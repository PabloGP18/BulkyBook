using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product obj)
        {
            // _db.Products.Update(obj); => this way even if you only update the Title property it will update the rest also
            var objFromDb = _db.Product.FirstOrDefault(u=>u.Id == obj.Id);

            // This way when you only update one property it will only will update that property and not the rest
            if(objFromDb != null)
            {
               objFromDb.Title = obj.Title;
               objFromDb.ISBN = obj.ISBN;
               objFromDb.Price = obj.Price;
               objFromDb.Price50 = obj.Price50;
               objFromDb.ListPrice = obj.ListPrice;
               objFromDb.Price100 = obj.Price100;
               objFromDb.Description = obj.Description;
               objFromDb.CategoryId = obj.CategoryId;
               objFromDb.Author = obj.Author;
               objFromDb.CoverType = obj.CoverType;
                // We only want to be able to update an imageUrl if there is one already
                if(obj.ImagerUrl != null)
                {
                    objFromDb.ImagerUrl = obj.ImagerUrl;
                }
            }
        }
    }
}
