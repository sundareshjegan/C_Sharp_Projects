using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Completions;

namespace WinformsPractice
{
    static class PromptGenerator
    {
        static async Task Main(string[] args)
        {
            var openAiApiKey = "YOUR_API_KEY"; // Replace with your OpenAI API key

            APIAuthentication aPIAuthentication = new APIAuthentication(openAiApiKey);
            OpenAIAPI openAiApi = new OpenAIAPI(aPIAuthentication);


            try
            {
                string prompt = "Once upon a time";
                string model = "text-davinci-003";
                int maxTokens = 50;

                var completionRequest = new CompletionRequest
                {
                    Prompt = prompt,
                    Model = model,
                    MaxTokens = maxTokens
                };

                var completionResult = await openAiApi.Completions.CreateCompletionAsync(completionRequest);
                var generatedText = completionResult.Completions[0].Text; //completionResult.Choices[0].Text.Trim();

                Console.WriteLine("Generated text:");
                Console.WriteLine(generatedText);
                MessageBox.Show(generatedText);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
