using LaboApiGroup_BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Interfaces
{
    public interface IGift_Service:IGlobalInterfaces<int, Gift_BLL>
    {
        Gift_BLL Get(int id);
        IEnumerable<Gift_BLL> GetAll();
        int Insert(Gift_BLL gift_BLL);
        bool Update(Gift_BLL gift_);
        bool Delete(int id);
    }
}
