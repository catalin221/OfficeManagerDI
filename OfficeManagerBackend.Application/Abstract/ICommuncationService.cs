namespace OfficeManagerBackend.Application.Abstract;

public interface ICommunicationService
{
    void MakePhoneCall(string message);
    void MakeViberCall(string message);
    void MakeSkypeCall(string message);
}
