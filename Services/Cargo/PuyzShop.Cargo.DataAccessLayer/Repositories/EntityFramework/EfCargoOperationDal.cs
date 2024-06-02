using PuyzShop.Cargo.DataAccessLayer.Abstract;
using PuyzShop.Cargo.DataAccessLayer.Concrete.EntityFramework.Context;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.DataAccessLayer.Repositories.EntityFramework
{
    public class EfCargoOperationDal : GenericRepository<CargoOperation, CargoContext>, ICargoOperationDal
    {
    }
}
