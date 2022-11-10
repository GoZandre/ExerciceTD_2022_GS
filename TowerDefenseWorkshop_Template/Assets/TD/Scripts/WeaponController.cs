namespace GSGD1
{
	using UnityEngine;

	public class WeaponController : MonoBehaviour
	{
		[SerializeField]
		private AWeapon _weapon = null;

		public AWeapon getAWeapon
        {
            get { return _weapon; }
        }

		[SerializeField]
		private float _rotationSpeed = 5f;

		[SerializeField]
		private float _minAngleToFire = 10f;

		[System.NonSerialized]
		private Quaternion _lastLookRotation = Quaternion.identity;

		public void LookAt(Vector3 position)
		{
			Vector3 direction = (position - transform.position).normalized;
			_lastLookRotation = Quaternion.LookRotation(direction, Vector3.up);
			transform.rotation = Quaternion.Slerp(transform.rotation, _lastLookRotation, _rotationSpeed * Time.deltaTime);
		}

		public void LookAtAndFire(Vector3 position)
		{
			LookAt(position);
			if (Quaternion.Angle(_lastLookRotation, transform.rotation) < _minAngleToFire)
			{
				//_weapon.Fire();
			}
		}

		private void LateUpdate()
		{
			_lastLookRotation = transform.rotation;
		}
	}
}