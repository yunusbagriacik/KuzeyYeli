using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    
    using KuzeyYeli.Entity;
    using KuzeyYeli.Entity.Models;

    public class RepositoryBase<TT> : IRepository<TT> where TT:class
    {
        private static KuzeyYeliEntities context;

        //Singleton Pattern:Uygulamanın tek context veya tek connection üzerinden işlem yapmasının sağlandığı tasarım desenidir.
        public static KuzeyYeliEntities Context
        {
            get
            {
             context = context ?? new KuzeyYeliEntities(); //?? "null ise" demek. Null ise instance al.
                return context;
            }
            set { context = value; }
        }


        public bool Ekle(TT entity)
        {
            Context.Set<TT>().Add(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Guncelle(TT entity)
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<TT> Listele()
        {
            return Context.Set<TT>().ToList();
        }

        public bool Sil(TT entity)
        {
            Context.Set<TT>().Remove(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
                
            }
        }
    }
}
