using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;

        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<UserToDisplayDto>>> GetMultipleUsers()
        {
            var users = await _userRepository.GetUsersToDisplayAsync();

            return Ok(users);

        }

        [HttpGet("{username}")]
        public async Task<ActionResult<UserToDisplayDto>> GetSingleUser(string username)
        {
            return await _userRepository.GetUserToDisplayAsync(username);
            
        }
    }
}