using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteCinta : MonoBehaviour
{
    public motorCintas motorcintasScript;

    private void OnTriggerEnter2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "LimiteCinta")
        {
            Destroy(cInfo.transform.parent.gameObject);
            motorcintasScript.CreaCintas();
            

          
        }
    }
}
