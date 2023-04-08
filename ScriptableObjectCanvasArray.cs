using System;
using Transforms;
using UnityEngine;

namespace Canvases
{
    [CreateAssetMenu(menuName = "Canvases/Canvases Array", fileName = "Canvases Array", order = 1)]
    public class ScriptableObjectCanvasArray : ScriptableObject, ICanvasArray
    {
        private ICanvasArray _impl;

        public ICanvasArray Impl
        {
            set => _impl = value;
        }

        public ITransform this[int index] => _impl[index];
        public ITransform this[Index index] => _impl[index];
    }
}