using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //invocation çalışan metod demek
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            //ben sana content type gönderdim diyorum
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

            //validation kurallarında kurala uymayan bir request olursa bunu kullanıcıya göstersin istiyorum

            string message = "Internal Server Error";

            //validation hatası ise
            IEnumerable<ValidationFailure> errors;
            if (e.GetType()==typeof(ValidationException))
            {
                message = e.Message;

                //validation hatası olmadığını, client taraflı hata olduğunu söylüyoruz
                errors = ((ValidationException)e).Errors;
                httpContext.Response.StatusCode = 400;

                //new ErrorDetails değil artık => new ValidationErrorDetails
                return httpContext.Response.WriteAsync(new ValidationErrorDetails
                {
                    StatusCode=400,
                    Message=message,
                    Errors=errors
                }.ToString());
            }

            return httpContext.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = httpContext.Response.StatusCode,
                Message=message
                //burası sistemsel hata fırlattığı için Error=null olarak client'a gönderir. buda frontend için bug'a sebep olabilir...bunun için bu ErrorDetails ufak bir inherit yapalım
            }.ToString());



        }
    }
}
