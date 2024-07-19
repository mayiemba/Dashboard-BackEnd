using MerchantDashboard.DbContexts;
using MerchantDashboard.Entities;

namespace MerchantDashboard.Repositories
{
    public class MerchantRepository
    {
        private readonly MerchantInfoContext _context;

        public MerchantRepository(MerchantInfoContext context)
        {
            _context = context;
        }

        public List<Merchant> GetAllMerchants() 
        { 
            var merchants = _context.Merchants.ToList();

            return merchants;
        }

        public Merchant GetMerchant(int id)
        {
            var merchant = _context.Merchants.Where(m => m.Id == id).FirstOrDefault();

            return merchant;
        }

        public Merchant Create(Merchant merchant) 
        { 
            _context.Merchants.Add(merchant);

            _context.SaveChanges();

            return merchant;
        }

        public Merchant Update(Merchant merchant)
        {
            _context.Merchants.Update(merchant);

            _context.SaveChanges();

            return merchant;
        }

        public Merchant Delete(Merchant merchant)
        {
            _context.Merchants.Remove(merchant);

            _context.SaveChanges();

            return merchant;
        }
    }
}
