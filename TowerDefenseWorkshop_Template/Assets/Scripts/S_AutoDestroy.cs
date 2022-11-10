using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_AutoDestroy : MonoBehaviour
{

    [SerializeField]
    private float _delay;
    private void Start()
    {
        StartCoroutine(AutoDestroy());
    }

    private IEnumerator AutoDestroy()
    {
        yield return new WaitForSeconds(_delay);
        Destroy(gameObject);
    }
}
