namespace GSGD1
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ProjectileLauncher : AWeapon
    {
        [SerializeField]
        private AProjectile _projectile = null;

        [SerializeField]
        private AProjectile _projectileBoost = null;


        [SerializeField]
        private Transform _projectileAnchor = null;

        private RythmTower _rythmTower = null;

        private Tower _tower = null;


        private void Awake()
        {
            RythmTower rythmTowerTest = GetComponentInParent<RythmTower>();

            if (rythmTowerTest != null)
            {
                _rythmTower = rythmTowerTest;

            }

            Tower towerTest = GetComponentInParent<Tower>();

            if (towerTest != null)
            {
                _tower = towerTest;
            }
        }

        protected override void DoFire()
        {
            if (_tower.enabled)
            {
                //Debug.Log("Het");
                var instance = Instantiate(_projectile, _projectileAnchor.position, _projectileAnchor.rotation);
                SetRythmTowerAsBoostable();

            }
        }

        public void DoBoostedFire()
        {
            var instance = Instantiate(_projectileBoost, _projectileAnchor.position, _projectileAnchor.rotation);
            SetRythmTowerAsNOTBoostable();
            Debug.Log("ZA WARUDO");
        }

        private void SetRythmTowerAsBoostable()
        {
            _rythmTower.SetIsBoostable(true);
            Debug.Log("Trying to make tower boostable");
        }

        private void SetRythmTowerAsNOTBoostable()
        {
            _rythmTower.SetIsBoostable(false);
        }
    }
}