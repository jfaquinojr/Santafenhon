using Microsoft.AspNetCore.Identity.UI.Services;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Shared.Infrastructure
{
    public class BrgyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Log.Debug("sending email to {email} with {subject} and {message}", email, subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
