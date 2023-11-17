using FluentEmailImp.Models;

namespace FluentEmailImp.Service
{
    public interface IEmailService
    {
        Task Send(EmailMetadata emailMetadata);
        Task SendUsingTemplateFromFile(EmailMetadata emailMetadata, User model, string templateFile);
    }
}
