using AITech.WebUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly IGeminiService _geminiService;

        public NewsletterController(IGeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost]
        public async Task<IActionResult> AskQuestion([FromBody] NewsletterQuestionRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Question))
            {
                return Json(new { success = false, message = "Please enter a question." });
            }

            try
            {
                var aiPrompt = $"You are a customer service representative for AI.Tech, an artificial intelligence and technology company. " +
                              $"You provide information about the company and AI technologies. " +
                              $"Company services: Robotic Automation, Machine Learning, Education & Science, Predictive Analysis. " +
                              $"User question: {request.Question}. " +
                              $"Please provide a short, clear answer in English.";

                var response = await _geminiService.GetGeminiDataAsync(aiPrompt);

                return Json(new { success = true, answer = response });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred. Please try again." });
            }
        }
    }

    public class NewsletterQuestionRequest
    {
        public string Question { get; set; }
    }
}
