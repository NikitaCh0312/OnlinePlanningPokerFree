﻿namespace UseCases.Handlers.Registration.Dtos;

public class PlayerRegistrationDto
{
    public bool Result { set; get; }
    
    public string JwtToken { set; get; }
}