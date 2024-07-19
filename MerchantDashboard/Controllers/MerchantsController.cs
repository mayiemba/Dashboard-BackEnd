using MerchantDashboard.DbContexts;
using MerchantDashboard.Entities;
using MerchantDashboard.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MerchantDashboard.Controllers
{
    [ApiController]
    [Route("api/merchants")]
    public class MerchantsController : ControllerBase
    {
        private readonly MerchantRepository _merchantRepository;

        public MerchantsController(MerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository ?? throw new ArgumentNullException();
        }

        [HttpGet("getMerchants")]
        public ActionResult<Merchant> GetAllMerchants()
        {
            var merchantResult = _merchantRepository.GetAllMerchants();
            if (merchantResult == null)
            {
                return NotFound("Merchants not listed");
            }

            return Ok(merchantResult);
        }

        [HttpGet("getMerchantById/{id}")]
        public ActionResult<Merchant> GetMerchant(int id)
        {
            var merchantResult = _merchantRepository.GetMerchant(id);
            if (merchantResult == null)
            {
                return NotFound("Merchant not found");
            }

            return Ok(merchantResult);
        }

        [HttpPost("createMerchant")]
        public ActionResult<Merchant> CreateMerchant(Merchant merchant)
        {
            var merchantResult = _merchantRepository.Create(merchant);
            if (merchantResult == null)
            {
                return NotFound("Creation failed");
            }

            return Ok(merchantResult);
        }

        [HttpPost("updateMerchant")]
        public ActionResult<Merchant> UpdateMerchant(Merchant merchant)
        {
            var merchantResult = _merchantRepository.Update(merchant);
            if (merchantResult == null)
            {
                return NotFound("Update failed");
            }

            return Ok(merchantResult);
        }

        [HttpDelete("removeMerchant")]
        public ActionResult<Merchant> RemoveMerchant(Merchant merchant)
        {
            var merchantResult = _merchantRepository.Delete(merchant);
            if (merchantResult == null)
            {
                return NotFound("Failed to remove the merchant");
            }

            return Ok(merchantResult);
        }
    }
}
