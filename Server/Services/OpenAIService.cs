using System;
using AiChef.Shared;

namespace AiChef.Server.Services
{
	public class OpenAIService : IOpenAIAPI
	{
		public OpenAIService()
		{
		}

        public Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}

