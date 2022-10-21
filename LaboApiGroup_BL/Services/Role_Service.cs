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
            return _repository.Delete(entity.R_REPOtoR_BLL());
        }

        public Role_BLL Get(int id)
        {
            return _repository.Get(id).R_BLLtoR_REPO();
        }

        public IEnumerable<Role_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.R_BLLtoR_REPO());
        }

        public int Insert(Role_BLL entity)
        {
            return _repository.Insert(entity.R_REPOtoR_BLL());
        }

        public bool Update(Role_BLL data)
        {
            return _repository.Update(data.R_REPOtoR_BLL());
        }
    }
}
