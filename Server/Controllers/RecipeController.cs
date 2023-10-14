using Microsoft.AspNetCore.Mvc;
using AiChef.Shared;
using AiChef.Server.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AiChef.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {
            return SampleData.RecipeIdeas;
        }
    }
}

