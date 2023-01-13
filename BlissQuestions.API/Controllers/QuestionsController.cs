using AutoMapper;
using BlissQuestions.API.DbContexts;
using BlissQuestions.API.Entities;
using BlissQuestions.API.Models;
using BlissQuestions.API.Services;
using BlissQuestions.API.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlissQuestions.API.Controllers
{
    [Route("api/questions")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<QuestionForUpdateDto> _validatorUpdate;
        private readonly IValidator<QuestionForCreationDto> _validatorCreation;
        public QuestionsController(IQuestionsRepository questionsRepository, IMapper mapper, IValidator<QuestionForUpdateDto> validatorUpdate, IValidator<QuestionForCreationDto> validatorCreation)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
            _validatorUpdate = validatorUpdate;
            _validatorCreation = validatorCreation;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionDto>>> GetQuestions(
            [FromQuery(Name = "limit")] int? limit,
            [FromQuery(Name = "offset")] int? offset,
            [FromQuery(Name = "filter")] string? filter)
        {
            var questions = await _questionsRepository.GetQuesionsAsync(limit, offset, filter);
            return Ok(_mapper.Map<IEnumerable<QuestionDto>>(questions));
        }

        [HttpGet("{id}", Name = "GetQuestion")]
        public async Task<ActionResult<QuestionDto>> GetQuestion(int id)
        {
            var question = await _questionsRepository.GetQuestionAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<QuestionDto>(question));
        }
        [HttpPost]
        public async Task<ActionResult<QuestionDto>> AddQuestion(QuestionForCreationDto questionForCreation)
        {

            var validationResult = _validatorCreation.Validate(questionForCreation);
            if (!validationResult.IsValid)
            {
                return BadRequest(new StatusDto() { Status= "Bad request. All fields are mandatory" });
            }
            var questionEntity = _mapper.Map<QuestionEntity>(questionForCreation);
            _questionsRepository.AddQuestion(questionEntity);
            await _questionsRepository.SaveChangesAsync();
            return CreatedAtRoute("GetQuestion", new { questionEntity.Id }, _mapper.Map<QuestionDto>(questionEntity));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<QuestionDto>> UpdateQuestion(int id, QuestionForUpdateDto questionToUpdate)
        {
            var validationResult = _validatorUpdate.Validate(questionToUpdate);
            if (!validationResult.IsValid)
            {
                return BadRequest(new StatusDto() { Status = "Bad request. All fields are mandatory" });
            }
            if (!await _questionsRepository.HasQuestionAsync(id))
            {
                return NotFound();
            }
            var questionEntityUpdate = await _questionsRepository.GetQuestionAsync(id);
            _mapper.Map(questionToUpdate,questionEntityUpdate);
            await _questionsRepository.SaveChangesAsync();
            return Ok(_mapper.Map<QuestionDto>(questionEntityUpdate));
        }
    }
}
