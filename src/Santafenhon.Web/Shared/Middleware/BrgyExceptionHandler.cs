using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Santafenhon.Web.Shared.Middleware
{

    public class BrgyExceptionHandler
    {
        private readonly RequestDelegate next;

        public BrgyExceptionHandler(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await handleExceptionAsync(context, ex);
            }
        }

        private async Task handleExceptionAsync(HttpContext context, Exception exception)
        {
            string errorCode = calculateErrorCode(context.TraceIdentifier);
            string message = string.Format("An unhandled exception occurred; please contact the help desk with the following error code: '{0}'  [{1}]", errorCode, context.TraceIdentifier);

            Log.Logger.Error(exception, message);

            await next(context);
        }

        private static string calculateErrorCode(string traceIdentifier)
        {
            const int ErrorCodeLength = 6;
            const string CodeValues = "BCDFGHJKLMNPQRSTVWXYZ";

            MD5 hasher = MD5.Create();

            StringBuilder sb = new StringBuilder(10);

            byte[] traceBytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(traceIdentifier));

            int codeValuesLength = CodeValues.Length;

            for (int i = 0; i < ErrorCodeLength; i++)
            {
                sb.Append(CodeValues[traceBytes[i] % codeValuesLength]);
            }

            return sb.ToString();
        }
    }

    public static class ExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseBrgyExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BrgyExceptionHandler>();
        }
    }
}
