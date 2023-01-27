using LostFocus.Models;
using LostFocus.Models.SearchCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostFocus.Interfaces
{
    public interface IProductRepository : IEntityRepository<Product>
    {
        ICollection<Product> GetByColor(string color);

        // zła praktyka
        // ICollection<Product> Get(string name, string description, string color, decimal? fromPrice, decimal? toPrice);

        // dobra praktyka
        ICollection<Product> Get(ProductSearchCriteria searchCriteria);

    }
    // Interfejs generyczny (szablon)
    public interface IEntityRepository<TEntity>
        where TEntity : BaseEntity
    {
        ICollection<TEntity> Get();
    }


}
