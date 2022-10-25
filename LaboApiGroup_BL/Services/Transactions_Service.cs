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
    public class Transactions_Service : ITransactionService
    {
        private readonly TransactionRepo _repository;
        private readonly GiftOfProject_Service _GIftofProjectService;
        private readonly Gift_Sevice _giftService;
        public Transactions_Service()
        {
            _repository = new TransactionRepo();
            _GIftofProjectService = new();
            _giftService = new();

        }
        public int GetFullTransacOfUser(Guid id, int idProject)
        {
            IEnumerable<Transactions_BLL> allTransac = GetAll().Where(x => x.Id_User == id && x.Id_Project == idProject).Select(x => x);
            int total = 0;
            foreach (Transactions_BLL item in allTransac)
            {
                total+= item.Amount;
            }

            return total;
        }
        public IEnumerable<Gift_BLL> GetGifts(Guid id, int IdProject)
        {
            List<Gift_BLL> L_Gifts = new();
            List<Gift_BLL> L_GiftsForUser = new();
            int tot = GetFullTransacOfUser(id, IdProject);
            IEnumerable<GiftOfProject_BLL> allGift =  _GIftofProjectService.GetAll().Where(x => x.Id_Project == IdProject);

            foreach (GiftOfProject_BLL item in allGift)
            {
                L_Gifts.Add(_giftService.Get(item.Id_Gift));
            }
            int pres = 0;
            for (int i = 0; i < L_Gifts.Count; i++)
            {
                if (i == 0) pres = L_Gifts[i].landing;

                if (L_Gifts[i].landing >= tot && L_Gifts[i].landing <= pres && !L_GiftsForUser.Contains(L_Gifts[i]))
                    L_GiftsForUser.Add(L_Gifts[i]);
            }

            return L_GiftsForUser;
        }

        public bool Delete(Transactions_BLL entity)
        {
            return _repository.Delete(entity.ToBLL());
        }

        public Transactions_BLL Get(int id)
        {
            return _repository.Get(id).ToREPO();
        }

        public IEnumerable<Transactions_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.ToREPO());
        }

        public int Insert(Transactions_BLL entity)
        {
            return _repository.Insert(entity.ToBLL());
        }

        public bool Update(Transactions_BLL data)
        {
            return _repository.Update(data.ToBLL());
        }

    }
}
