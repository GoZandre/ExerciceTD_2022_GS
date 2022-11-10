namespace GSGD1
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;

    public class VictoryCondition : MonoBehaviour
    {
        [SerializeField] Canvas _mainCanvas = null;
        [SerializeField] Canvas _victoryCanvas = null;
        [SerializeField] Canvas _defeatCanvas = null;

        [SerializeField]
        private WaveDatabase _levelWaves;

        public UnityEvent TestWin;




        private void Awake()
        {
            _victoryCanvas.enabled = false;
            _defeatCanvas.enabled = false;
        }

        private void OnEnable()
        {
            TestWin.RemoveListener(TestEnemiesAlive);
            TestWin.AddListener(TestEnemiesAlive);
        }
        private void OnDisable()
        {
            TestWin.RemoveListener(TestEnemiesAlive);
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

        public void TestEnemiesAlive()
        {
            if(LevelReferences.Instance.SpawnerManager.getWaveIndex >= _levelWaves.Waves.Count - 1)
            {
                if (LevelReferences.Instance.EnemiesList.Count == 0)
                {
                    PlayerWin();
                }
            }
            
        }
    }
}