using System.Collections.Generic;
using System.Linq;
using WishList.WebApi.Contexts;
using WishList.WebApi.Domains;
using WishList.WebApi.Interfaces.Repositories.Base;

namespace WishList.WebApi.Repositories {
    public class DesejoRepository : IStandardRepository<Desejo> {
        WishListContext ctx = new WishListContext();

        public void Delete(int id) {
            ctx.Desejos.Remove(SearchById(id));
            ctx.SaveChanges();
        }

        public List<Desejo> ListAll() {
            return ctx.Desejos.ToList();
        }

        public void Register(Desejo newEntity) {
            ctx.Desejos.Add(newEntity);
            ctx.SaveChanges();
        }

        public Desejo SearchById(int id) {
            return ctx.Desejos.FirstOrDefault(d => d.IdDesejos == id);
        }

        public void Update(int id, Desejo newEntity) {
            Desejo searchedUser = ctx.Desejos.Find(id);

            if(newEntity != null) {
                searchedUser.Desejo1 = newEntity.Desejo1;
                searchedUser.Descricao = newEntity.Descricao;
            }

            ctx.Desejos.Update(searchedUser);
            ctx.SaveChanges();
        }
    }
}
