using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{

    ParticleSystem ps;
    GameObject[] cubes;

    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cubes = GameObject.FindGameObjectsWithTag("PickUp");
        ps = GetComponent<ParticleSystem>();
        var trigger = ps.trigger;
        trigger.enabled = true;
        for(int i = 0; i < cubes.Length; i++)
        {
            trigger.AddCollider(cubes[i].GetComponent<BoxCollider>());
        }
    }
    private void OnParticleTrigger()
    {
        //Get all particles that entered a box collider
        List<ParticleSystem.Particle> enteredParticles = new List<ParticleSystem.Particle>();
        int enterCount = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enteredParticles);

       

        
            for (int i = 0; i < cubes.Length; i++)
            {
              
                Debug.Log("Distance from cube: " + Vector3.Distance(player.transform.position, cubes[i].transform.position));
            }
        


        Debug.Log("Boo");
    }
}
