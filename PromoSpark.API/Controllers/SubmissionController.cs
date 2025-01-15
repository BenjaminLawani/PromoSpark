using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromoSpark.Application.Models.DTOs;
using PromoSpark.Application.Models.Requests;
using PromoSpark.Domain.Entities;
using System.Security.Claims;
using AutoMapper;
using PromoSpark.Application.Interfaces;
using System.Collections.Generic;
using PromoSpark.Domain.Common.Enums;

namespace PromoSpark.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SubmissionsController : ControllerBase
    {
        private readonly ISubmissionRepository _submissionRepository;
        private readonly IChallengeRepository _challengeRepository;
        private readonly IMapper _mapper;

        public SubmissionsController(
            ISubmissionRepository submissionRepository,
            IChallengeRepository challengeRepository,
            IMapper mapper)
        {
            _submissionRepository = submissionRepository;
            _challengeRepository = challengeRepository;
            _mapper = mapper;
        }

        [HttpGet("challenge/{challengeId}")]
        public async Task<ActionResult<IEnumerable<SubmissionDto>>> GetChallengeSubmissions(Guid challengeId)
        {
            var submissions = await _submissionRepository.GetByChallengeIdAsync(challengeId);
            return Ok(_mapper.Map<IEnumerable<SubmissionDto>>(submissions));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubmissionDto>> GetSubmission(Guid id)
        {
            var submission = await _submissionRepository.GetByIdAsync(id);
            if (submission == null)
                return NotFound();

            return Ok(_mapper.Map<SubmissionDto>(submission));
        }

        [HttpPost]
        [Authorize(Roles = "Participant")]
        public async Task<ActionResult<SubmissionDto>> CreateSubmission(CreateSubmissionRequest request)
        {
            var challenge = await _challengeRepository.GetByIdAsync(request.ChallengeId);
            if (challenge == null)
                return NotFound("Challenge not found");

            if (challenge.Status != StatusEnum.Active)
                return BadRequest("Challenge is not active");

            if (challenge.Deadline < DateTime.UtcNow)
                return BadRequest("Challenge deadline has passed");

            if (!challenge.AllowedPlatforms.Contains(request.Platform))
                return BadRequest("Platform not allowed for this challenge");

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var submission = new Submission
            {
                ChallengeId = request.ChallengeId,
                ParticipantId = Guid.Parse(userId),
                VideoUrl = request.VideoUrl,
                Caption = request.Caption,
                Platform = request.Platform,
                PlatformPostUrl = request.PlatformPostUrl,
                IsVerified = false,
                CreatedAt = DateTime.UtcNow
            };

            await _submissionRepository.AddAsync(submission);
            return CreatedAtAction(nameof(GetSubmission), new { id = submission.Id },
                _mapper.Map<SubmissionDto>(submission));
        }

        [HttpPut("{id}/verify")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> VerifySubmission(Guid id)
        {
            var submission = await _submissionRepository.GetByIdAsync(id);
            if (submission == null)
                return NotFound();

            submission.IsVerified = true;
            submission.UpdatedAt = DateTime.UtcNow;

            await _submissionRepository.UpdateAsync(submission);
            return NoContent();
        }

        [HttpPut("{id}/rank")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateSubmissionRank(Guid id, int rank)
        {
            var submission = await _submissionRepository.GetByIdAsync(id);
            if (submission == null)
                return NotFound();

            var challenge = await _challengeRepository.GetByIdAsync(submission.ChallengeId);
            if (rank > challenge.NumberOfWinners)
                return BadRequest("Rank exceeds number of winners");

            submission.Rank = rank;
            submission.UpdatedAt = DateTime.UtcNow;

            // Calculate reward amount based on rank
            if (rank == 1)
                submission.RewardAmount = challenge.RewardPool * 0.5m; // 50% for first place
            else if (rank == 2)
                submission.RewardAmount = challenge.RewardPool * 0.3m; // 30% for second place
            else if (rank == 3)
                submission.RewardAmount = challenge.RewardPool * 0.2m; // 20% for third place

            await _submissionRepository.UpdateAsync(submission);
            return NoContent();
        }

        [HttpGet("participant")]
        [Authorize(Roles = "Participant")]
        public async Task<ActionResult<IEnumerable<SubmissionDto>>> GetParticipantSubmissions()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var submissions = await _submissionRepository.GetByParticipantIdAsync(Guid.Parse(userId));
            return Ok(_mapper.Map<IEnumerable<SubmissionDto>>(submissions));
        }
    }
}


