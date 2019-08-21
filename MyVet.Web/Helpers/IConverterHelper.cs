using System.Threading.Tasks;
using MyVet.Web.Data.Entities;
using MyVet.Web.Models;

namespace MyVet.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetasync(PetViewModel model, string path);
    }
}