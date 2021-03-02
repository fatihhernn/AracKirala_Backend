﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(p => p.CarId).NotNull().WithMessage("Lütfen araba Id'si gönderin");
            RuleFor(p => p.ImagePath).NotNull().WithMessage("Fotoğraf seçilmedi");
        }
    }
}