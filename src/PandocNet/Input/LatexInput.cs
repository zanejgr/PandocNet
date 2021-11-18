﻿namespace PandocNet;

public class LaTexInput :
    InputOptions
{
    public LaTexInput(Stream stream) :
        base(stream)
    {
    }

    public LaTexInput(string file) :
        base(file)
    {
    }

    public override string Format => "latex";
}