namespace GSGD1
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerStats : MonoBehaviour
    {
        [SerializeField]
        private int _playerHealth = 1;


        public void TakeDamage(int damage)
        {
            _playerHealth = _playerHealth - damage;
            if (_playerHealth <= 0)
            {
                Debug.Log("PlayerIsDead");
                VictoryCondition victoryCondition = GetComponent<VictoryCondition>();
                if (victoryCondition != null)
                {
                    victoryCondition.PlayerLose();
                }
            }
        }


    }

}
