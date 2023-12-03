using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

public class Spawner : MonoBehaviour
{
    public Bird BirdScript;
   
    public GameObject Borular;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

   
    void Update()
    {
       
    }

    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isdead)
        {

           Instantiate(Borular, new Vector3(3, UnityEngine.Random.Range(-height, height), 0), quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
}
