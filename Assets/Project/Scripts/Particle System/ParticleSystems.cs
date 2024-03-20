using System;
using UnityEngine;

public class ParticleSystems : MonoBehaviour
{
    [SerializeField] private Particle[] particle;
    private static ParticleSystems instance;
    public static ParticleSystems Instance { get { return instance; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayParticles(Transform location, ParticleTypes particle)
    {
        ParticleSystem particleSystem = GetParticleSystem(particle);
        if (particleSystem != null)
        {
            ParticleSystem newParticleSystem = Instantiate(particleSystem, location.position, location.rotation);
            newParticleSystem.Play();
            Destroy(newParticleSystem.gameObject, particleSystem.main.duration);
        }
        else
        {
            Debug.LogError("Particle System not found, Particle Type: " + particle);
        }
    }
    private ParticleSystem GetParticleSystem(ParticleTypes particles)
    {
        Particle p = Array.Find(particle, i => i.particle == particles);
        if (p != null)
        {
            return p.particleSystem;
        }
        return null;
    }
}