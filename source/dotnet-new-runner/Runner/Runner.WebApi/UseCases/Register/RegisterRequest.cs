﻿namespace Runner.WebApi.UseCases.Register
{
    public class RegisterRequest
    {
        public string PIN { get; set; }
        public string Name { get; set; }
        public double InitialAmount { get; set; }
    }
}
