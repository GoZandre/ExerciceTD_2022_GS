namespace GSGD1
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class VictoryCondition : MonoBehaviour
    {
        public void Quit()
        {
            //Debug.Log("TryingToQuit");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}