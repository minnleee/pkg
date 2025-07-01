using UnityEngine;

namespace Pkg.Runtime
{
    using OtherPkg.Runtime;

    public class TempRuntime : MonoBehaviour
    {
        public void Hello()
        {
            Debug.Log($"Hello {OtherTempRuntime.World}");
        }
    }
}
