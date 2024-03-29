﻿using System;

namespace SpiderRock.SpiderStream;

public class UpdatedEventArgs<T> : EventArgs
{
    public T Previous { get; internal set; }
    public T Current { get; internal set; }
    public Channel Channel { get; internal set; }
}
