using Microsoft.AspNetCore.Mvc;

namespace WishList.WebApi.Interfaces.Controllers.Base {
    interface IStandardController<T> {
        IActionResult Get();
        IActionResult Get(int id);
        IActionResult Post(T newEntity);
        IActionResult Put(int id, T newEntity);
        IActionResult Delete(int id);
    }
}
