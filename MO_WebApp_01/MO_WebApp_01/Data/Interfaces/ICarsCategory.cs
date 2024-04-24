using MO_WebApp_01.Data.Models;

namespace MO_WebApp_01.Data.Interfaces
{
    using MO_WebApp_01.Data.Models;

    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategory { get; }
    }

}
