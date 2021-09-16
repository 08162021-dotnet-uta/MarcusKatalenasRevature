using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IOrderRepo
    {
        
        Task<List<ViewModelOrder>> OrderListAsync();
        Task<List<ViewModelOrder>> OrderListByStoreIDAsync();
        Task<List<ViewModelOrder>> OrderListByCustomerIDAsync();


    }
}
