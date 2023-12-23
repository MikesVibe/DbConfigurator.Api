using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.AccountFeature;
using DbConfigurator.Domain.SecurityEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAccountRepository _accountRepository;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(
            UserManager<AppUser> userManager,
            IAccountRepository accountRepository,
            ITokenService tokenService,
            IMapper mapper)
        {
            _userManager = userManager;
            _accountRepository = accountRepository;
            _tokenService = tokenService;
            _mapper = mapper;
        }


        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDto registerDto)
        {
            if(await _accountRepository.UserExists(registerDto.UserName))
            {
                return BadRequest("Username is taken.");
            }

            var user = _mapper.Map<AppUser>(registerDto);


            //var user = new AppUser
            //{
            //    DisplayName = registerDto.UserName,
            //    UserName = registerDto.UserName.ToLower(),
            //};

            var result = await _accountRepository.CreateAsync(user, registerDto.Password);
            if(result.IsFailed)
            {
                return BadRequest("Invalid password.");
            }
            else
            {
                var userDto = _mapper.Map<UserDto>(result.Value);
                userDto.Token = _tokenService.CreateToken(result.Value);
                userDto.UserRoles = (await _accountRepository.GetUserRolesAsync(user)).ToList();
                return userDto;
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto login)
        {
            var resultUser = await _accountRepository.GetUserAsync(login.UserName);
        
            if(resultUser.IsFailed)
            {
                return Unauthorized("Invalid username.");
            }
            var user = resultUser.Value;

            var resultPassword = await _accountRepository.CheckPasswordAsync(user, login.Password);
            if(!resultPassword)
            {
                return Unauthorized("Invalid Password.");
            }

            var userDto = _mapper.Map<UserDto>(user);
            userDto.Token = _tokenService.CreateToken(user);
            userDto.UserRoles = (await _accountRepository.GetUserRolesAsync(user)).ToList();
            return userDto;
        }
    }
}
