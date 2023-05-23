using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrelParticleSystem2 : MonoBehaviour, DestroyInterface
{
    [SerializeField]
    GameObject particleSys;

    private void Start()
    {
        particleSys.SetActive(false);
    }

    public void MakeEffect()
    {
        particleSys.SetActive(true);
    }
}
