using System.Collections.Generic;

namespace WishList.WebApi.Interfaces.Repositories.Base {
    interface IStandardRepository<T> {
        List<T> ListAll();
        T SearchById(int id);
        void Register(T newEntity);
        void Update(int id, T newEntity);
        void Delete(int id);
    }
}
