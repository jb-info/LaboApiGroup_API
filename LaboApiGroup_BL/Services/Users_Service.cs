using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Services
{
    public class Users_Service:IGlobalInterfaces<Guid,Users_BLL>
    {
        private UserRepository _repository;

        public Users_Service()
        {
            _repository = new UserRepository();
        }

        public bool Delete(Users_BLL entity)
        {
            return _repository.Delete(entity.);
        }

        public Users_BLL Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users_BLL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Guid Insert(Users_BLL entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Users_BLL data)
        {
            throw new NotImplementedException();
        }
    }
}
