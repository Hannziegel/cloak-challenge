using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloack : MonoBehaviour
{
    [SerializeField]
    private GameObject secHand, minHand, hourHand;
    private bool isCloakRunning = false;
    void Start()
    {
        
    }


    void Update()
    {
        StopCoroutine(CloakTimer());
    }

    public void Play()
    {
        if(!isCloakRunning)
        {
            StartCoroutine(CloakTimer());
        }
    }

    public void Stop()
    {
        StopAllCoroutines();
        isCloakRunning = false;
    }
    IEnumerator CloakTimer(float countTime = 1.0f)
    {
        isCloakRunning = true;
        while(isCloakRunning)
        {
            yield return new WaitForSeconds(countTime);
            secHand.transform.Rotate(0, 0, -6, Space.Self);
            minHand.transform.Rotate(0, 0, -(6f/60f), Space.Self);
            hourHand.transform.Rotate(0, 0, -(6f/3600f), Space.Self);
        }
        isCloakRunning = false;
    }
}
