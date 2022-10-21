using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboApiGroup_BL.Mapper;
using LaboApiGroup_Repo.Entities;

namespace LaboApiGroup_BL.Services
{
    public class User_Service : IUserService
    {
        private readonly UserRepository _repo;
        public User_Service()
        {
            _repo = new UserRepository();
        }

        public bool Delete(Users_BLL entity)
        {
            return _repo.Delete(entity.ToRepo());
        }

        public Users_BLL Get(Guid id)
        {
            return _repo.Get(id).ToBLL();
        }

        public IEnumerable<Users_BLL> GetAll()
        {
            return _repo.GetAll().Select(x => x.ToBLL()).ToList();
        }

        public Guid Insert(Users_BLL entity)
        {
            return _repo.Insert(entity.ToRepo());
        }

        public Users Login(Users_BLL u)
        {
            return _repo.Login(u.ToRepo());
        }

        public bool Update(Users_BLL data)
        {
            return _repo.Update(data.ToRepo());
        }
    }
}
