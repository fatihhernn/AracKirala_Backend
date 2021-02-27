using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive 
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception("bu bir doğruluma sınıfı değildir!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //reflection => çalışma anında bir şeyleri çalıştırıyor. newleme işlemini çalışma anında yapıyor
            //çalışma anında direk instance üretiyoruz
            var validator = (IValidator)Activator.CreateInstance(_validatorType); 

            //validatorün generic typelarında ilkini bul => CAR
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];

            //onun parametrelerine bak => parametrenin tipi ile sınıfın tipi aynı olanı bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //invocation metod demek


            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}