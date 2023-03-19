using SalesW.Data;
using SalesW.Models;
using static SalesW.Controllers.SellersController;

namespace SalesW.Services
{
    public class SellerService 
    {
        private readonly SalesWContext _context;

        public SellerService(SalesWContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


    }
}
