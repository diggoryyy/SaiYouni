using System.Collections.Generic;
using UnityEngine;

public static class ElementChecker
{
    public static bool ExistsInCollection<T>(IEnumerable<T> collection, T item)
    {
        foreach (T element in collection)
        {
            if (EqualityComparer<T>.Default.Equals(element, item))
                return true;
        }
        return false;
    }
}