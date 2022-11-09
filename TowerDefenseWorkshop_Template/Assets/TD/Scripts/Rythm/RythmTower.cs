namespace GSGD1
{


    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RythmTower : MonoBehaviour
    {
        [SerializeField]
        private float _timePerBeat = 0.0f;


        private void Update()
        {
         
           if (Input.GetButtonDown("TempoPress"))
           {
               Debug.Log("Pressed");

           }
        }
    }




        






}
