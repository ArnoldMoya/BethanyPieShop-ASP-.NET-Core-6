using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category> 
            {
                new Category {CategoryId = 1, CategoryName="Fruit pies", Description="All-fruity pies"},
                new Category {CategoryId = 2, CategoryName="Cheese pies", Description="Cheese all the way"},
                new Category {CategoryId = 3, CategoryName="Seasonal pies", Description="Get in the mood for seasonal pie"}
            };
    }
}
