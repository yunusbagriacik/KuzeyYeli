using KuzeyYeli.DTO;
using KuzeyYeli.Entity.Models;
using KuzeyYeli.Extensions;
using KuzeyYeli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KuzeyYeli.WCF
{
    public class ServiceBase<Rep, Entity, DTO> : IService<DTO>   where DTO : class
        where Entity : class
        where Rep : RepositoryBase<Entity>
    {
        private Rep repository;
        //Activator sınıfı içerisindeki CreateInstance isimli generic metot içerisine verilen generic tipten instance üretmeti sağlar.
        public Rep Repository
        {
            get
            {
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }

            set { repository = value; }
        }

        public bool Ekle(DTO dto)
        {
            return Repository.Ekle(dto.Changer<Entity>());
        }

        public bool Guncelle(DTO dto)
        {
            return Repository.Guncelle(dto.Changer<Entity>());
        }

        public List<DTO> Listele()
        {
            return Repository.Listele().Select(x => x.Changer<DTO>()).ToList();
        }

        public bool Sil(DTO dto)
        {
            return Repository.Sil(dto.Changer<Entity>());
        }
    }
}