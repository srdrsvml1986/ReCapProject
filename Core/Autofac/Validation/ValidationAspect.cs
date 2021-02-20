using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Autofac.Validation
{
    public class ValidationAspect:MethodInterception
    {
        private readonly Type _validatorType;
        /// <summary>
        /// Gönderilen validatorType ın FluentValidation olup olmadığı denetlenir
        /// </summary>
        /// <param name="validatorType"></param>
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new ArgumentException("AspectMessages.WrongValidationType");
            }
            _validatorType = validatorType;
        }
        /// <summary>
        ///  Activator ile validatorun yeni bir instance alınır
        /// </summary>
        /// <param name="invocation"></param>
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //GetGenericArguments gabliba sürekli olarak 1 elaman taşıyor 
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //entityType={Name = "Car" FullName = "Entities.Concrete.Car"} şeklinde oluyor
            var entities = invocation.Arguments.Where(t=>t.GetType()==entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator,entity);
            }
        }
    }
}
