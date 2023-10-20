# ChezGPT: What's in your fridge? 🍳🤖

ChezGPT is an innovative application that leverages the power of ChatGPT and DALL-E to generate creative recipe ideas from a "world-renowned chef". Simply input the ingredients you have on hand, and ChezGPT will suggest unique recipe ideas along with detailed instructions and ingredient lists. [See it in action!](https://chezgpt.augnos.dev)

![App Screenshot](https://github.com/Augnos/ChezGPT/assets/110561217/279d6dd2-4e0d-4c99-9353-e16c08afcb5e)

*Sample screenshot of ChezGPT in action.*

## Features 📋

- **Meal Time**: Choose to make a meal for breakfast, lunch, dinner, or dessert.
- **Ingredient Input**: Easily input a list of ingredients you have available in your fridge or pantry.
- **Recipe Ideas**: Choose between 5 AI-powered recipe ideas based on your ingredient list.
- **Recipe Generation**: Recieve step-by-step instructions and a full ingredient list to make your meal.
- **Print**: Print the recipe to take with you to the kitchen, or save as a PDF for later.

## Technologies Used 💻

- **Language**: C#
- **Framework**: .NET 7
- **Web**: Blazor/WebAssembly
- **IDE**: Visual Studio

## Setup and Installation 🛠

### Prerequisites

- Ensure you have [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed.
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) with Web Development workload.
- An OpenAI API Key, with a payment method provided. [Make an OpenAI account](https://openai.com)

### Steps

1. Open Visual Studio
2. Go to Git > Clone Repository
3. Enter this in the URL: https://github.com/Augnos/ChezGPT.git and select a Target Folder. Then press Clone.
4. Right-click AiChef.Server in the solution, and add your OpenAI API Key
```
{
    "OpenAi:OpenAiKey": "Your-API-Key-Here"
}
```
5. Run the build, and enjoy!

## Usage 🍴

Enter the ingredients you have on hand into the input field and click the "Generate" button. ChezGPT will then provide a list of potential recipes. Click on a recipe to view detailed instructions and the ingredient list.

## Code Structure 📁

- **AiChef.Client**: Pages holds Razor components and CSS files used to build pages. Shared contains Razor Components and templates. wwwroot holds static files.
- **AiChef.Server**: Houses the logic for interacting with ChatGPT and DALL-E API. Sample data can be accessed in Controllers/RecipeController, to not call API and spend unnecessarily during development.
- **AiChef.Shared**: Common components and utility functions.

## License 📄

This project is licensed under the MIT License.

## Contact & Authorship ✍️

ChezGPT was developed by [Joshua Valdez](https://augnos.dev). For any questions, feedback, or suggestions, please reach out at [josh@augnos.com](mailto:josh@augnos.com).

## Acknowledgments 🙌

Special thanks to:

- OpenAI for ChatGPT and DALL-E.
- Coder Foundry, for building the AI Chef Blazor course, and providing the instruction that lead to ChezGPT. 
- The Blazor community for their valuable resources and support.

## Future Plans 💭

- Provide user accounts to save favorite recipes.
- Allow rating and reactions to other users' generated recipes(?)
