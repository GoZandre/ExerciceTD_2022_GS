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
		private LevelManager _levelManager = null;

		[SerializeField]
		private VictoryCondition VictoryCondition = null;

		[SerializeField]
		private Tempo _tempo = null;

		[SerializeField]
		private List<WaveEntity> _enemiesList = new List<WaveEntity>();

		public PlayerPickerController PlayerPickerController => _playerPickerController;
		public SpawnerManager SpawnerManager => _spawnerManager;
		public PlayerStats PlayerStats => _playerStats;	
		public Tempo Tempo => _tempo;
		public LevelManager LevelManager => _levelManager;
		public VictoryCondition victoryCondition => VictoryCondition;
		public List<WaveEntity> EnemiesList => _enemiesList;

	}
}