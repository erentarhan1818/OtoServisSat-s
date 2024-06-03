using OtoServisSatis.Entities;
using OtoServisSatis.Data.Abstract;
using System.Collections;

namespace OtoServisSatis.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
