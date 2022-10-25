using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Repositories;
using LaboApiGroup_BL.Mapper;


namespace LaboApiGroup_BL.Services
{
    public class UserInProject_Service : IUserInProjectService
    {
        private readonly UserInProjectRepo _repository;
        public UserInProject_Service()
        {
            _repository = new UserInProjectRepo();
        }      
        public bool Delete(UsersInProject_BLL entity)
        {
            return _repository.Delete(entity.ToREPO());
        }

        public UsersInProject_BLL Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<UsersInProject_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.ToBLL());
        }

        public int Insert(UsersInProject_BLL entity)
        {
            return _repository.Insert(entity.ToREPO());
        }

        public bool Update(UsersInProject_BLL data)
        {
            return _repository.Update(data.ToREPO());
        }
    }
}
