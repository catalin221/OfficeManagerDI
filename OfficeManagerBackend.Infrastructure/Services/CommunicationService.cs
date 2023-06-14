using OfficeManagerBackend.Application.Abstract;

namespace OfficeManagerBackend.Infrastructure.Services
{
    public class CommunicationService : ICommunicationService
    {
        public void MakePhoneCall(string message)
        {
            Console.WriteLine($"Making a phone call: {message}");
        }

        public void MakeViberCall(string message)
        {
            Console.WriteLine($"Making a Viber call: {message}");
        }

        public void MakeSkypeCall(string message)
        {
            Console.WriteLine($"Making a Skype call: {message}");
        }
    }
}