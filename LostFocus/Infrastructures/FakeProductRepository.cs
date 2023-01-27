using Bogus;
using LostFocus.Interfaces;
using LostFocus.Models;
using LostFocus.Models.SearchCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostFocus.Infrastructures
{


    public abstract class FakeEntityRepository<TEntity> : IEntityRepository<TEntity>
    where TEntity : BaseEntity
    {
        protected readonly ICollection<TEntity> entities;

        public FakeEntityRepository(Faker<TEntity> faker)
        {
            entities = faker.Generate(100);
        }

        public ICollection<TEntity> Get()
        {
            return entities;
        }
    }
    public class FakeProductRepository : FakeEntityRepository<Product>, IProductRepository
    {
        public FakeProductRepository(Faker<Product> faker) : base(faker)
        {
        }

        public ICollection<Product> Get(ProductSearchCriteria searchCriteria)
        {
            var query = entities.AsQueryable();

            if (!string.IsNullOrEmpty(searchCriteria.Name))
            {
                query = query.Where(x => x.Name.Contains(searchCriteria.Name));
            }

            if (!string.IsNullOrEmpty(searchCriteria.Description))
            {
                query = query.Where(x => x.Description.Contains(searchCriteria.Description));
            }

            if (!string.IsNullOrEmpty(searchCriteria.Color))
            {
                query = query.Where(x => x.Color.Equals(searchCriteria.Color, StringComparison.OrdinalIgnoreCase));
            }

            if (searchCriteria.FromPrice.HasValue)
            {
                query = query.Where(x => x.Price >= searchCriteria.FromPrice.Value);
            }

            if (searchCriteria.ToPrice.HasValue)
            {
                query = query.Where(x => x.Price <= searchCriteria.ToPrice.Value);
            }

            return query.ToList();
        }

        public ICollection<Product> GetByColor(string color)
        {
            // Linq
            return entities.Where(x => x.Color == color).ToList();
        }
    }
}
