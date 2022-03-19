using System;

public class Program
{
    public static bool InvokeWithRetry(Action action, int maxAttempts)
    {
        for (int i = 0; i < maxAttempts; i++)
        {
            action.Invoke();
        }

        return true;
    }
}