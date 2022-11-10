namespace GSGD1
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;

    public class PlayerStats : MonoBehaviour
    {
        [SerializeField]
        private int _playerHealth = 1;

        public UnityEvent DamageTaken;

        public void TakeDamage(int damage)
        {
            _playerHealth = _playerHealth - damage;
            DamageTaken.Invoke();
            if (_playerHealth <= 0)
            {
                Debug.Log("PlayerIsDead");
                LevelReferences.Instance.victoryCondition.PlayerLose();
                Controller controllerTest = GetComponent<Controller>();

                if (controllerTest != null)
                {
                    controllerTest.enabled = false;
                }

                //if (victoryCondition != null)
                //{
                //    victoryCondition.PlayerLose();
                //}
            }
        }

        public int GetHealth()
        {
            return _playerHealth;
        }
    }

}
