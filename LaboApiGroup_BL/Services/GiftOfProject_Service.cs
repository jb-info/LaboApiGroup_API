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
    public class GiftOfProject_Service : IGiftOfProjectService
    {
        private readonly GiftOfProjectRepo _repository;

        public GiftOfProject_Service()
        {
       
            _repository= new GiftOfProjectRepo();
        }

        public bool Delete(GiftOfProject_BLL entity)
        {
            return _repository.Delete(entity.GOP_REPOtoGOP_BLL());
        }

        public GiftOfProject_BLL Get(int id)
        {
            return _repository.Get(id).GOP_BLLtoGOP_REPO();
        }

        public IEnumerable<GiftOfProject_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.GOP_BLLtoGOP_REPO());
        }

        public int Insert(GiftOfProject_BLL entity)
        {
            return _repository.Insert(entity.GOP_REPOtoGOP_BLL());
        }

        public bool Update(GiftOfProject_BLL data)
        {
            return _repository.Update(data.GOP_REPOtoGOP_BLL());
        }
    }
}
