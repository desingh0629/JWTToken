using JWTTokenAuthenicationProj.Data;
using JWTTokenAuthenicationProj.Helpers;
using JWTTokenAuthenicationProj.Interfce;
using JWTTokenAuthenicationProj.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTTokenAuthenicationProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {
        public readonly ApplicationDBContext _context;
        public readonly ICommonService _commonService;
        public ApplicationUsersController(ApplicationDBContext context, ICommonService commonService)
        {
            _context = context;
            _commonService = commonService;
        
        }

        [HttpPost]
        [Route("PostLoginDetails")]
        public async Task<IActionResult> POSTLoginDetails(UserHelperModel user)
        {
            if(user != null)
            {
                var resutLoginCheck = _context.ApplicationUsers.Where(e=>e.EMailId == user.Email && e.Password == user.Password).FirstOrDefault();
                if(resutLoginCheck != null)
                {
                    user.UserMessage = "Login SuccessFully";
                    user.AccessToken = _commonService.GetTokent(user);
                    return Ok(user);
                }
                else
                {
                    return BadRequest("Invalid Credential");
                }
            }
            else
            {
                return BadRequest("No Data");
            }
           
        }

        
    }
}
