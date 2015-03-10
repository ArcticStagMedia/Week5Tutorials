using UnityEngine;
using System.Collections;
using System;
using System.Numeric;

public class GenericClass
{
    public T GenericMethod<T>(T param) 
    {
        return param;
    }

    public T Square<T>(T param) where T :
    {
        return param * param;
    }
}
