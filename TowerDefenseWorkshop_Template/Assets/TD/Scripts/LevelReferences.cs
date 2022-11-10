namespace GSGD1
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class LevelReferences : Singleton<LevelReferences>
	{
		[SerializeField]
		private PlayerPickerController _playerPickerController = null;

		[SerializeField]
		private SpawnerManager _spawnerManager = null;

		[SerializeField]
		private PlayerStats _playerStats = null;

		[SerializeField]
		private Tempo _tempo = null;

		public PlayerPickerController PlayerPickerController => _playerPickerController;
		public SpawnerManager SpawnerManager => _spawnerManager;
		public PlayerStats PlayerStats => _playerStats;	
		public Tempo Tempo => _tempo;
	}
}