using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.Models;


namespace MO_WebApp_01.Data.Repository
{
    public class CategoriesRepository : ICarsCategory
    {
        public readonly AppDBContent appDbContent;

        public CategoriesRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategory => throw new NotImplementedException();
    }
}
