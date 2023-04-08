using Transforms;
using UnityEngine;

namespace Canvases
{
    public class LoadCanvasArrayAction : MonoBehaviour
    {
        [SerializeField] private Transform backCanvas;
        [SerializeField] private Transform frontCanvas;
        [SerializeField] private Transform middleCanvas;
        [SerializeField] private ScriptableObjectCanvasArray canvasArray;

        public void Invoke()
        {
            canvasArray.Impl = new CanvasArray
            {
                Impl = new ITransform[]
                {
                    new UnityTransform
                    {
                        Impl = backCanvas
                    },
                    new UnityTransform
                    {
                        Impl = middleCanvas
                    },
                    new UnityTransform
                    {
                        Impl = frontCanvas
                    }
                }
            };
            DontDestroyOnLoad(backCanvas);
            DontDestroyOnLoad(frontCanvas);
            DontDestroyOnLoad(middleCanvas);
        }
    }
}