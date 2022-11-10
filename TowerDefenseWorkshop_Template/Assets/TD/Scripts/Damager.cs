namespace GSGD1
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Damager : MonoBehaviour
    {
        [SerializeField] 
        private int _damage = 1;

       public void DoDamage()
        {
            LevelReferences.Instance.PlayerStats.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }

}
