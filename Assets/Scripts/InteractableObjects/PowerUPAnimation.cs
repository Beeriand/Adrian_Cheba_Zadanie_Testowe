using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPAnimation : MonoBehaviour
{
    bool fly= true;

    void Update()
    {
        Animate();
    }

    void Animate()
    {
        
        if(fly)
        {
            transform.Translate(new Vector3(0, 0.005f, 0));
            if (transform.localPosition.y >= 2.5f) fly = false; 

        }
        else
        {
            transform.Translate(new Vector3(0, -0.005f, 0));
            if (transform.localPosition.y <= 1.5f) fly = true;
        }
    }
}
