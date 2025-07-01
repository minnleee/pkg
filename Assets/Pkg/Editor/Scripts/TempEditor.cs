using UnityEngine;

namespace Pkg.Editor
{
    using System;
    using Pkg.Runtime;
    using UnityEditor;

    public class TempEditor : EditorWindow
    {
        [MenuItem("Pkg/TempEditor")]
        private static void GetWindow()
        {
            GetWindow<TempEditor>();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Hello"))
            {
                var go = new GameObject("Temp", typeof(TempRuntime));
                var hello = go.GetComponent<TempRuntime>();
                hello.Hello();
            }
        }
    }
}
