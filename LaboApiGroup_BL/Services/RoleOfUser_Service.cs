using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Mapper;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Services
{
    public class RoleOfUser_Service : IRoleOfUserService
    {
        public readonly RoleOfUserRepo _repository;

        public RoleOfUser_Service()
        {
            _repository = new RoleOfUserRepo();
        }
        public bool Delete(RoleOfUser_BLL entity)
        {
            return _repository.Delete(entity.ROU_REPOtoROU_BLL());
        }

        public RoleOfUser_BLL Get(int id)
        {
            return _repository.Get(id).ROU_BLLtoROU_REPO();
        }

        public IEnumerable<RoleOfUser_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.ROU_BLLtoROU_REPO());
        }

        public int Insert(RoleOfUser_BLL entity)
        {
            return _repository.Insert(entity.ROU_REPOtoROU_BLL());
        }

        public bool Update(RoleOfUser_BLL data)
        {
            return _repository.Update(data.ROU_REPOtoROU_BLL());
        }
    }
}
        
