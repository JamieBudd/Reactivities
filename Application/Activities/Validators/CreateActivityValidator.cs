﻿using Application.Activities.Commands;
using Application.Activities.DTOs;
using FluentValidation;
using System;

namespace Application.Activities.Validators;

public class CreateActivityValidator : BaseActivityValidator<CreateActivity.Command, CreateActivityDto>
{
    public CreateActivityValidator() : base(x => x.ActivityDto)
    {

    }
}
