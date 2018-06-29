using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for loginExeption
/// </summary>
public class CustomeExeption : Exception
{
    public CustomeExeption()
    {

    }
    public CustomeExeption(string message)
       : base(message)
    {
    }

    public CustomeExeption(string message, Exception inner)
        : base(message, inner)
    {

    }
}