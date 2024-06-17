using Microsoft.AspNetCore.Mvc;
using PuyzShop.Basket.Dtos;
using PuyzShop.Basket.LoginServices;
using PuyzShop.Basket.Services;

namespace PuyzShop.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginService;

        public BasketsController(IBasketService basketService, ILoginService loginService)
        {
            _basketService = basketService;
            _loginService = loginService;
        }

        [HttpGet]
        public async Task<ActionResult> GetBasket()
        {
            var user = User.Claims;
            var values = await _basketService.GetBasketAsync(_loginService.GetUserId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<ActionResult> SaveBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginService.GetUserId;
            await _basketService.SaveBasketAsync(basketTotalDto);
            return Ok("Sepetteki değişiklikler kaydedildi");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasketAsync(_loginService.GetUserId);
            return Ok("Sepet başarıyla silindi");
        }
    }
}
