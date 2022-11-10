namespace GSGD1
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;


    public class Tempo : MonoBehaviour
    {

        [SerializeField]
        private float _beatTempo = 0.0f;        //   Le tempo global. Crâne du haut sur l'exemple de Dorian. 

        [SerializeField]
        private float _timePerBeat = 0.0f;      // Le nombre de Beat sur le tempo global. Crâne du bas sur l'exemple de Dorian. 

        public UnityEvent FireOnTempo;

        private float _timer;
        private bool _isPlaying = false;

        private int _timeOnBeat = 1;

        public int getTimeOnBeat
        {
            get { return _timeOnBeat; }
        }

        private void Start()
        {
            
        }

        private void Update()

        {
            float tempoValue = 60 / _beatTempo;                            //
            float timePerBeatValue = 60 / (_beatTempo * _timePerBeat);

            if (_isPlaying == false)
            {
                StartTimer();
            }

            else
            {
                if (UpdateTimer(tempoValue))                            // Mettre un message sur la valeur du tempo 
                {
                    _isPlaying = false;
                }

                if (UpdateTimer(timePerBeatValue * _timeOnBeat))       //     Mettre un message sur la valeur du beat
                {
                    FireOnTempo.Invoke();
                    _timeOnBeat++;
                }
            }

        }


        private void StartTimer()
        {
            _timer = Time.time;              
            _isPlaying = true;

            _timeOnBeat = 1;
        }

        private bool UpdateTimer(float value)        // Depuis quand le jeu à commencé, depuis quand le tempo est lancé et comment il s'incrémente
        {
            if (value <= Time.time - _timer)        // Le tempo commence. 
            {
                return true;
            }
            return false;
        }

    }
}