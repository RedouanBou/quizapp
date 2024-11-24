namespace QuizApp.Extentions;

using System;
using System.Collections.Generic;

public static class IEnumerableExtensions
{
    private static Random random = new Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        var count = list.Count;
        while (count > 1)
        {
            count--;
            int k = random.Next(count + 1);
            T value = list[k];
            list[k] = list[count];
            list[count] = value;
        }
    }
}