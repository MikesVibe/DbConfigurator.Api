using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.AccountFeature;
using DbConfigurator.Domain.SecurityEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(
            IAccountRepository accountRepository,
            ITokenService tokenService,
            IMapper mapper)
        {
            _accountRepository = accountRepository;
            _tokenService = tokenService;
            _mapper = mapper;
        }


        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDto registerData)
        {
            if(await _accountRepository.UserExists(registerData.UserName))
            {
                return BadRequest("Username is taken.");
            }

            var user = new AppUser
            {
                DisplayName = registerData.UserName,
                UserName = registerData.UserName.ToLower(),
            };

            var result = await _accountRepository.AddAsync(user);
            if(result.IsFailed)
            {
                return BadRequest();
            }
            else
            {
                return new UserDto
                {
                    UserName = user.UserName,
                    DisplayName = user.DisplayName,
                    Token = _tokenService.CreateToken(user)
                };
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto login)
        {
            var result = await _accountRepository.GetUserAsync(login.UserName);
        
            if(result.IsFailed)
            {
                return Unauthorized("Invalid username.");
            }
            var user = result.Value;


            return new UserDto
            {
                UserName = user.UserName,
                DisplayName = user.DisplayName,
                Token = _tokenService.CreateToken(user)
            };
        }
    }
}
