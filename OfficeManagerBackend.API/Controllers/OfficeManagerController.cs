using Microsoft.AspNetCore.Mvc;
using OfficeManagerBackend.Domain.Entities;

namespace OfficeManagerBackend.API.Controllers
{
    public class OfficeManagerController : ControllerBase
    {
        private readonly OfficeManager _officeManager;

        public OfficeManagerController(OfficeManager officeManager)
        {
            _officeManager = officeManager;
        }

        [HttpGet("call/phone/{message}")]
        public IActionResult MakePhoneCall(string message)
        {
            _officeManager.CallViaPhone(message);
            return Ok($"Phone call made with message {message}.");
        }

        [HttpGet("call/viber/{message}")]
        public IActionResult MakeViberCall(string message)
        {
            _officeManager.CallViaViber(message);
            return Ok($"Viber call made with message {message}.");
        }

        [HttpGet("call/skype/{message}")]
        public IActionResult MakeSkypeCall(string message)
        {
            _officeManager.CallViaSkype(message);
            return Ok($"Skype call made with message {message}.");
        }
    }
}
