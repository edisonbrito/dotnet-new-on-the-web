﻿namespace Tracking.Application
{
    public interface IOutputConverter
    {
        T Map<T>(object source);
    }
}
