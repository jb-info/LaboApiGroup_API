using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Repositories;
using LaboApiGroup_BL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Services
{
    public class Role_Service : IRoleService
    {
        private readonly RoleRepo _repository;

        public Role_Service()
        {
            _repository = new RoleRepo();
        }

        public bool Delete(Role_BLL entity)
        {
            return _repository.Delete(entity.ToBLL());
        }

        public Role_BLL Get(int id)
        {
            return _repository.Get(id).ToREPO();
        }

        public IEnumerable<Role_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.ToREPO());
        }

        public int Insert(Role_BLL entity)
        {
            return _repository.Insert(entity.ToBLL());
        }

        public bool Update(Role_BLL data)
        {
            return _repository.Update(data.ToBLL());
        }
    }
}
