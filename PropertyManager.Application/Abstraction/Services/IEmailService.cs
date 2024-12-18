using PropertyManager.Domain.Common.Email;

namespace PropertyManager.Application.Abstraction.Services;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest request, CancellationToken cancellationToken);
}
