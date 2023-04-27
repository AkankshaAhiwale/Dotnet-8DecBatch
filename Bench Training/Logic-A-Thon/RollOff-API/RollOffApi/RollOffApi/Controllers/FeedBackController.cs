using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RollOffApi.DTO;
using RollOffApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly IFeedBack feedbackrepo;
        private readonly IMapper mapper;
        public FeedBackController(IFeedBack feedbackrepo, IMapper mapper)
        {
            this.feedbackrepo = feedbackrepo;
            this.mapper = mapper;
        }

        
        [HttpPost]
        public async Task<IActionResult> AddFeedbackAsync(FeedBackDTO feedBackDTO)
        {
            try
            {
                //DTO to Model
                var employeeForm = mapper.Map<FeedbackForm>(feedBackDTO);
                var response = await feedbackrepo.AddFeedbackAsync(employeeForm);             //Convert back to DTO
                var feedBackDTO2 = mapper.Map<FeedBackDTO>(response);
                return Ok(feedBackDTO2);
            }
            catch(Exception e)
            {
                return BadRequest("Something went wrong"+e);
            }
            
        }
        [HttpGet]
        public async Task<IActionResult> GetFeedback()
        {
            var feedbackDetails = await feedbackrepo.GetFeedbackDetailsAsync();

  
            var feedbackDetailsDTO = mapper.Map<List<FeedBackDTO>>(feedbackDetails);

            return Ok(feedbackDetailsDTO);
        }

        [HttpGet]
        [Route("{id:double}")]
        public async Task<IActionResult> GetDetailByID(double id)
        {
            try
            {
                var result = await feedbackrepo.GetByIdAsync(id);

                if (result == null)
                {
                    return NotFound();
                }

                var resultDTO = mapper.Map<FeedBackDTO>(result);

                return Ok(resultDTO);
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e);
            }
        }
    }
}
