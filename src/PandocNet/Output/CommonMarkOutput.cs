﻿namespace PandocNet;

public class CommonMarkOutput :
    OutputOptions
{
    public CommonMarkOutput(Stream stream) :
        base(stream)
    {
    }

    public CommonMarkOutput(string file) :
        base(file)
    {
    }

    public override string Format => "commonmark";
}