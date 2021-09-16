using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
	
	public interface ICustomerRepo
	{
		Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc);
		Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc);
		Task<List<ViewModelCustomer>> CustomerListAsync();

	}
	

	
	

}
  
