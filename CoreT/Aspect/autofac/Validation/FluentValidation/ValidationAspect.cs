﻿using Castle.DynamicProxy;
using CoreT.CrossCuttingConcern.Validation.FluentValidation;
using CoreT.Entities.Abstract;
using CoreT.Helpers.Interceptions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreT.Aspect.autofac.Validation.FluentValidation
{
    public class ValidationAspect<T> : MethodInterception

         where T : class, IEntity, new()
    {
        private readonly Type _validatorType;

        public ValidationAspect(Type type)
        {
            if (!typeof(IValidator).IsAssignableFrom(type))
            {
                throw new Exception("this class don't validation class");
            }
            _validatorType = type;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (T entity in entities)
            {
                ValidationTool<T>.Validation(validator, entity);
            }
        }
    }
}
