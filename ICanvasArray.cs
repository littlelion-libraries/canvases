using System;
using Transforms;

namespace Canvases
{
    public interface ICanvasArray
    {
        ITransform this[int index] { get; }
        ITransform this[Index index] { get; }
    }
}