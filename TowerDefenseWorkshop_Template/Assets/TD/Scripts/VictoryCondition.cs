namespace GSGD1
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class VictoryCondition : MonoBehaviour
    {
        [SerializeField] Canvas _mainCanvas = null;
        [SerializeField] Canvas _victoryCanvas = null;
        [SerializeField] Canvas _defeatCanvas = null;



        private void Awake()
        {
            _victoryCanvas.enabled = false;
            _defeatCanvas.enabled = false;
        }

        public void PlayerWin()
        {
            _mainCanvas.enabled = false;
            _victoryCanvas.enabled = true;
        }

        public void PlayerLose()
        {
            _mainCanvas.enabled = false;
            _defeatCanvas.enabled = true;
        }
    }
}