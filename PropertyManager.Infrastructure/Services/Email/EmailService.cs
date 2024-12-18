using PropertyManager.Application.Abstraction.Services;
using PropertyManager.Domain.Common.Email;

namespace PropertyManager.Infrastructure.Services.Email;

public class EmailService : IEmailService
{
    public Task SendEmailAsync(MailRequest request, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
