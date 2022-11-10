namespace GSGD1
{


    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RythmTower : MonoBehaviour
    {
        [SerializeField] float _boostTimeWindow = 0.25f;
        private float _lastBoostWindowTime = 0.0f;

        private bool _IsBoostable = false;
        private ProjectileLauncher _projectileLauncher = null;

        private void Awake()
        {
            ProjectileLauncher testProjectileLauncher = GetComponentInChildren<ProjectileLauncher>();
            if (testProjectileLauncher != null)
            {
                _projectileLauncher = testProjectileLauncher;
            }
        }

        private void Update()
        {

            if (Input.GetButtonDown("TempoPress"))
            {
                //Debug.Log("Pressed");
                if (_IsBoostable)
                {
                    Boost();
                }

                // un scrit qui dit : quand j'ai recu l'info que je suis cliquable, indiquer visuellement que je suis cliquable et si on me clique dessus je fais le boost de ouf 

            }
            if (Time.time >= _lastBoostWindowTime + _boostTimeWindow)
            {
                SetIsBoostable(false);
            }
        }

        private void Boost()
        {
            _projectileLauncher.DoBoostedFire();
            //Debug.Log("Attempting Boosted Fire");
        }

        public void SetIsBoostable(bool isBoostable)
        {
            _IsBoostable = isBoostable;
            //Debug.Log("Tower is now boostable");
            if (_IsBoostable)
            { 
                _lastBoostWindowTime = Time.time;
            }
        }
    }













}
