using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie {PieId = 1, Name="Strawberry", Price = 8.12M, ShortDescription = "SPie" },
            new Pie {PieId =2, Name="Cheese", Price = 8.12M, ShortDescription = "SPie" },
            new Pie {PieId = 3, Name="Berry", Price = 8.12M, ShortDescription = "SPie" },
            new Pie {PieId = 4, Name="Pumpkin", Price = 8.12M, ShortDescription = "SPie" }
        };

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
