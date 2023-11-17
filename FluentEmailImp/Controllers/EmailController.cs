using FluentEmailImp.Helper;
using FluentEmailImp.Models;
using FluentEmailImp.Service;
using Microsoft.AspNetCore.Mvc;

namespace FluentEmailImp.Controllers
{
    [Route("[controller]/[action]")]
    public class EmailController : Controller
    {
        private readonly IEmailService _iEmailService;
        public EmailController(IEmailService iEmailService)
        {
            _iEmailService = iEmailService ?? throw new ArgumentNullException(nameof(iEmailService));
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SendSingleEmail(string ReceiverEmail)
        {
            try
            {
                var EmailTitle = "FluentEmail Test email";
                var EmailBody = Common.GetTestEmailBody();
                EmailMetadata _EmailMetadata = new(ReceiverEmail, EmailTitle, EmailBody);
                await _iEmailService.Send(_EmailMetadata);
                return Ok("Email Send Successfully.");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
                throw;
            }
        }
        [HttpGet]
        public async Task<IActionResult> SendWithEmailTemplate(string ReceiverEmail)
        {
            try
            {
                var EmailTitle = "FluentEmail Test email";
                EmailMetadata _EmailMetadata = new(ReceiverEmail, EmailTitle);

                User model = new("John Doe", "john@gmail.com", "Silver");
                var _EmailTemplate = $"{Directory.GetCurrentDirectory()}/Views/Email/EmailTemplate.cshtml";
                await _iEmailService.SendUsingTemplateFromFile(_EmailMetadata, model, _EmailTemplate);
                return Ok("Email Send Successfully.");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
                throw;
            }
        }
    }
}
