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
    public class Gift_Sevice : IGiftService
    {
        private readonly GiftRepo _repository;
        public Gift_Sevice()
        {
            _repository = new GiftRepo();
        }

        public bool Delete(Gift_BLL entity)
        {
            return _repository.Delete(entity.ToBLL());
        }       

        public Gift_BLL Get(int id)
        {
            return _repository.Get(id).ToREPO();
        }

        public IEnumerable<Gift_BLL> GetAll()
        {
            return _repository.GetAll().Select(x=>x.ToREPO());
        }

        public int Insert(Gift_BLL entity)
        {
            return _repository.Insert(entity.ToBLL());
        }

        public bool Update(Gift_BLL data)
        {
            return _repository.Update(data.ToBLL());
        }        
    }
}
