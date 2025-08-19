﻿namespace CoreServices
{
    public interface IMyLogger
    {
        void Log(string message, DebugStatus status);
        void Log(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}