using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
  public float latitude;
  public float longitude;

  private void Start()
  {
    StartCoroutine(StartLocationService());
  }

  private IEnumerator StartLocationService()
  {
    if(!Input.location.isEnabledByUser)
    {
      Debug.Log("User has not enabled GPS");
      yield break;
    }

    Input.location.Start();
    int maxWait = 20;
    while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
    {
      yield return new WaitForSeconds(1);
      maxWait--;
    }

    if (maxWait <= 0)
    {
      Debug.Log("Timed out");
      yield break;
    }
  }
}
