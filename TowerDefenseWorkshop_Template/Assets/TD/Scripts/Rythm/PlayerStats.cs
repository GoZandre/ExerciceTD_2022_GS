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
        }


    }

}
