using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BZoom.Api.Models;

namespace BZoom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        [HttpPost]
        [Route("AddSurvey")]
        public IActionResult AddSurvey(Survey model)
        {
            var isEditMode = model.SurveyId > 0;

            if (isEditMode)
            {
                return BadRequest("something went wrong");
            }

            return Ok("Added Successfully");

            //Add to database

        }


        [HttpGet]
        [Route("GetSurveys")]
        public IActionResult GetSurveys()
        {

            var surveys = getFakeSurveyTable();



            return Ok(surveys);
        }
        [HttpGet]
        [Route("GetSurvey")]
        public IActionResult GetSurvey(int surveyId)
        {
            var surveys = getFakeSurveyTable();

            var survey = surveys.FirstOrDefault(a => a.SurveyId == surveyId);
           
            
            if (survey == null) return NotFound();
 
            return Ok(survey);
        }




        private List<Survey> getFakeSurveyTable()
        {
            var dummies = new List<Survey>();

            for (var i = 1; i < 100; i++)
            {
                dummies.Add(new Survey
                {
                    SurveyId = i,
                    Name = $"Survey {i}",
                    CreatedDate = DateTime.Now.AddDays(-i),
                    LastUpdatedDate= DateTime.Now.AddDays(-i),
                    LastUpdatedBy = "sys_admin",
                    CreatedBy = "sys_admin"
                });
            }

            return dummies;

        }


    }
}
