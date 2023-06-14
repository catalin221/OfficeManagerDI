using OfficeManagerBackend.Application.Abstract;

namespace OfficeManagerBackend.Domain.Entities
{
    public class OfficeManager
    {
        private readonly ICommunicationService _communicationService;

        public OfficeManager(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        public void CallViaPhone(string message)
        {
            _communicationService.MakePhoneCall(message);
        }

        public void CallViaViber(string message)
        {
            _communicationService.MakeViberCall(message);
        }

        public void CallViaSkype(string message)
        {
            _communicationService.MakeSkypeCall(message);
        }
    }
}
