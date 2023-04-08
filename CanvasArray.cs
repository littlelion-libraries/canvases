using System;
using Transforms;

namespace Canvases
{
    public class CanvasArray : ICanvasArray
    {
        private ITransform[] _impl;

        public ITransform[] Impl
        {
            set => _impl = value;
        }

        public ITransform this[int index] => _impl[index];
        public ITransform this[Index index] => _impl[index];
    }
}