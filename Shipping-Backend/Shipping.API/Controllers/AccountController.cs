using Microsoft.AspNetCore.Mvc;
using Shipping.BLL.Dtos;
using Shipping.BLL.Managers;
using Shipping.DAL.Data.Models;
using Shipping.DAL.Params;

namespace Shipping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountManager _userManager;

        public AccountController(IAccountManager userManager)
        {
            _userManager = userManager;
        }
      
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDtos loginDTO)
        {
            try
            {
                var token = await _userManager.LoginUser(loginDTO);
                if (token == null)
                    return Ok(new { message = "Invalid" });
                else
                    return Ok(new { Token = token });
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _userManager.LogoutUser();
                return Ok(new { message = "Logged out successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("email")]
        public async Task<IActionResult> UniqueEmail( string email)
        {

            var result =  await _userManager.UniqeEmail(email);
               
            if(result == 0)
            return Ok(new { message = "Invalid" });

            else if(result==1)    
            return Ok(new { message = "Valid" });
            

            return BadRequest();

        }

        [HttpPost("userName")]
        public async Task<IActionResult> UniqueUserName(string userName)
        {

            var result = await _userManager.UniqueUsername(userName);

            if (result == 0)
                return Ok(new { message = "Invalid" });
            else if (result == 1)
            {
                return Ok(new { message = "Valid" });
            }

            return BadRequest();

        }


    }




}

