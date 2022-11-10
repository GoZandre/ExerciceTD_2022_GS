namespace GSGD1
{
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class AWeapon : MonoBehaviour
	{
		[SerializeField]
		private Timer _timer = null;

        [SerializeField]
		private Tempo _tempo;

		[SerializeField]
		private int _currentBeat;

		public void SetCurrentBeat(int beat)
        {
			_currentBeat = beat;
        }

        private void OnEnable()
        {
			_tempo = LevelReferences.Instance.Tempo;

			_tempo.FireOnTempo.RemoveListener(Fire);
			_tempo.FireOnTempo.AddListener(Fire);
        }
        private void OnDisable()
        {
			_tempo.FireOnTempo.RemoveListener(Fire);
		}
		

        public virtual bool CanFire()
		{
			return _timer.IsRunning == false;
		}

		protected virtual void Update()
		{
			_timer.Update();
		}
		public void Fire()
		{
			if(_tempo.getTimeOnBeat <= _currentBeat)
            {
				DoFire();
            }
		}
		protected abstract void DoFire();

	}

}