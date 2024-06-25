using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
    public interface IDbInitializer
    {
        Task CreateSuperAdmin();
        Task SendEmail(string FromEmail, string subject,
            String FromName,
            String Message, string toEmail, string toName, String smtpUser,
            String smtpPassword, string smtpHost, string smtpPort, bool smtpSSl);
            
        Task<string> UploadFile(List<IFormFile> files,
            IWebHostEnvironment evn, string Directory);
    }
}
