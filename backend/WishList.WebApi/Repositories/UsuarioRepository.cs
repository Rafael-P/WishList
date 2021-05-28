using System.Collections.Generic;
using System.Linq;
using WishList.WebApi.Contexts;
using WishList.WebApi.Domains;
using WishList.WebApi.Interfaces.Repositories.Base;

namespace WishList.WebApi.Repositories {
    public class UsuarioRepository : IStandardRepository<Usuario> {
        WishListContext ctx = new WishListContext();

        public void Delete(int id) {
            ctx.Usuarios.Remove(SearchById(id));
            ctx.SaveChanges();
        }

        public List<Usuario> ListAll() {
            return ctx.Usuarios.ToList();
        }

        public void Register(Usuario newEntity) {
            ctx.Usuarios.Add(newEntity);
            ctx.SaveChanges();
        }

        public Usuario SearchById(int id) {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Update(int id, Usuario newEntity) {
            Usuario searchedUser = ctx.Usuarios.Find(id);

            if(newEntity != null) {
                searchedUser.Email = newEntity.Email;
                searchedUser.Senha = newEntity.Senha;
            }

            ctx.Usuarios.Update(searchedUser);
            ctx.SaveChanges();
        }
    }
}
