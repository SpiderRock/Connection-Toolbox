﻿using System;

namespace SpiderRock.SpiderStream;

public class ChangedEventArgs<T> : EventArgs
{
    public T Changed { get; internal set; }
    public Channel Channel { get; internal set; }
}
