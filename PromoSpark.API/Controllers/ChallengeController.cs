using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using PromoSpark.Application.Interfaces;
using PromoSpark.Application.Models.DTOs;
using PromoSpark.Application.Models.Requests;
using PromoSpark.Domain.Common.Enums;
using AutoMapper;

namespace PromoSpark.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ChallengesController : ControllerBase
    {
        private readonly IChallengeRepository _challengeRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ChallengesController(
            IChallengeRepository challengeRepository,
            IUserRepository userRepository,
            IMapper mapper)
        {
            _challengeRepository = challengeRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ChallengeDto>>> GetActiveChallenges()
        {
            var challenges = await _challengeRepository.GetActiveAsync();
            return Ok(_mapper.Map<IEnumerable<ChallengeDto>>(challenges));
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ChallengeDto>> GetChallenge(Guid id)
        {
            var challenge = await _challengeRepository.GetByIdAsync(id);
            if (challenge == null)
                return NotFound();

            return Ok(_mapper.Map<ChallengeDto>(challenge));
        }

        [HttpPost]
        [Authorize(Roles = "Creative")]
        public async Task<ActionResult<ChallengeDto>> CreateChallenge(CreateChallengeRequest request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var creative = await _userRepository.GetByIdAsync(Guid.Parse(userId));

            var challenge = await _challengeRepository.CreateChallengeAsync(request, creative.Id);
            return CreatedAtAction(nameof(GetChallenge), new { id = challenge.Id },
                _mapper.Map<ChallengeDto>(challenge));
        }

        [HttpPut("{id}/status")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateChallengeStatus(Guid id, StatusEnum status)
        {
            var updated = await _challengeRepository.UpdateStatusAsync(id, status);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpGet("creative")]
        [Authorize(Roles = "Creative")]
        public async Task<ActionResult<IEnumerable<ChallengeDto>>> GetCreativeChallenges()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var challenges = await _challengeRepository.GetByCreativeIdAsync(Guid.Parse(userId));
            return Ok(_mapper.Map<IEnumerable<ChallengeDto>>(challenges));
        }
    }
}
