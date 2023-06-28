using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate;

public class DelegateSample
{
    private string _globalData;

    public delegate void SingleStringDelegate(string data);

    public SingleStringDelegate Delegate01;
    public SingleStringDelegate Delegate02;

    public DelegateSample()
    {
        Delegate01 = AssignData;
        Delegate02 = WriteData;
    }

    public void AssignData(string data)
    {
        _globalData = data;
    }

    public void WriteData(string data)
    {
        Console.WriteLine($"data: {data}");
    }
}