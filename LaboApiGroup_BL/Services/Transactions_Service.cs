using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using LaboApiGroup_BL.Mapper;
using LaboApiGroup_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Services
{
    public class Transactions_Service : IGlobalInterfaces<int, Transactions_BLL>
    {
        private TransactionRepo _repository;
        public Transactions_Service()
        {
            _repository = new TransactionRepo();
        }

        public bool Delete(Transactions_BLL entity)
        {
            return _repository.Delete(entity.Tr_REPOtoTrBLL());
        }

        public Transactions_BLL Get(int id)
        {
            return _repository.Get(id).Tr_BLLtoTr_REPO();
        }

        public IEnumerable<Transactions_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.Tr_BLLtoTr_REPO());
        }

        public int Insert(Transactions_BLL entity)
        {
            return _repository.Insert(entity.Tr_REPOtoTrBLL());
        }

        public bool Update(Transactions_BLL data)
        {
            return _repository.Update(data.Tr_REPOtoTrBLL());
        }
    }
}
