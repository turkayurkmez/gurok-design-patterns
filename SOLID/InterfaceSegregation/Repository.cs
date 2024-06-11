using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {

    }

    public class Order
    {

    }

    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        void Add(T entity);
     
    }

    public interface ISearchable<T> where T : class
    {
        IList<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

      
    }

    public class SearcherComponent<T> where T:class
    {
        public void Search(ISearchable<T> repository, string name)
        {
            repository.SearchByName(name);
        }
    }

}
