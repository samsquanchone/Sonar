using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScanner : MonoBehaviour
{
    public GameObject terrainParticle;
    public float duration;
    public float size = 500;

    bool canFire = true;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && GameManager.Instance.GetGameState() == GameState.Normal && canFire)
        {
            SpawnTerrainScanner();
        }
    }

    void SpawnTerrainScanner()
    {
        canFire = false;
        GameObject terrainScanner = Instantiate(terrainParticle, this.gameObject.transform.position, Quaternion.identity) as GameObject;
        ParticleSystem terrainScannerPS = terrainScanner.transform.GetChild(0).GetComponent<ParticleSystem>();

        if (terrainScannerPS != null)
        {
            var main = terrainScannerPS.main;
            main.startLifetime = duration;
            main.startSize = size;
        }

        else
        {
            Destroy(terrainScanner, duration + 1);
        }

        StartCoroutine("sonarCooldown");


    }

    IEnumerator sonarCooldown()
    {
        yield return new WaitForSeconds(2f);
        canFire = true;
    }
}
