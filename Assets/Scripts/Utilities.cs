using System.Collections.Generic;

public static class Utilities
{
    public static bool ChangeKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey oldKey, TKey newKey)
    {
        TValue value;
        if(!dict.TryGetValue(oldKey, out value))
        {
            return false;
        }

        dict.Remove(oldKey);

        dict.Add(newKey, value);
        return true;
    }

    public static bool s_testMode = false;
    
}
