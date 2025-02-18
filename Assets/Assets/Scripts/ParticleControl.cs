using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    [SerializeField] private bool createDuskOnWalk = true;
    [SerializeField] private ParticleSystem dustParticleSystem;

    public void Start()
    {
        dustParticleSystem = GetComponentInChildren<ParticleSystem>();
    }
    public void CreateDustParticles()
    {
        if(createDuskOnWalk)
        {
            dustParticleSystem.Stop();
            dustParticleSystem.Play();
        }
    }
}
