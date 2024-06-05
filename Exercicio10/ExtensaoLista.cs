using System;
using System.Collections.Generic;


public static class ExtensaoLista
{
    public static List<T> RemovendoRepetido<T>(this IList<T> list)
    {
        return list.Distinct().ToList();
    }
}
