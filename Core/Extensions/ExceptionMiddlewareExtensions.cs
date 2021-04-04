using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        //araya middleware yazacağız =>(EXTENTION konusu) extent ediyoruz ExceptionMiddleware ekle... UseMiddleware .net core'dan geliyor
        public static void ConfigureCustomMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
