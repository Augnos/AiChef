﻿using Microsoft.AspNetCore.Mvc;
using AiChef.Server.Data;
using AiChef.Server.Services;
using AiChef.Shared;
using Microsoft.AspNetCore.Http;

namespace AiChef.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IOpenAIAPI _openAIservice;

        public RecipeController(IOpenAIAPI openAIservice)
        {
            _openAIservice = openAIservice;
        }

        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {
            //string mealtime = recipeParms.MealTime;
            //List<string> ingredients = recipeParms.Ingredients
            //                                      .Where(x => !string.IsNullOrEmpty(x.Description))
            //                                      .Select(x => x.Description!)
            //                                      .ToList();

            //if (string.IsNullOrEmpty(mealtime))
            //{
            //    mealtime = "Breakfast";
            //}

            //var ideas = await _openAIservice.CreateRecipeIdeas(mealtime, ingredients);

            //return ideas;


            return SampleData.RecipeIdeas;
        }
    }
}

