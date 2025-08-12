using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningToCode : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Crisp());
    }

    IEnumerator Crisp()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("crisp");
    }
}
