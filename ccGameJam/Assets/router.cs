﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class router : MonoBehaviour {

    [SerializeField]
    GameObject WiFiWaveSphere;
    [SerializeField]
    int sphereCount;
    [SerializeField]
    Transform forwardDir;


    float respawnTimer = 2;
    [SerializeField]
    float respawnTime;

    

	// Use this for initialization
	void Start () {




    }
	
	// Update is called once per frame
	void Update () {


        if (respawnTimer > respawnTime)
        {
            instantiateSpheres();
        }
        else
        {
            respawnTimer += 1 * Time.deltaTime;
        }


    }



    void instantiateSpheres()
    {

        float x;
        float z;

        float angle = 20f;

        Vector3 routerPosition = transform.position;

        

        for (int i = 0; i < (sphereCount + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle);
            z = Mathf.Cos(Mathf.Deg2Rad * angle);

            GameObject temp = Instantiate<GameObject>(WiFiWaveSphere, new Vector3((transform.position.x + x), transform.position.y, (transform.position.z + z)), new Quaternion(0,0,0,0), this.gameObject.transform);
            temp.transform.LookAt(transform.position);

            angle += (360f / sphereCount);
        }



        

        for (int i = 0; i < sphereCount; i++)
        {

        }
        respawnTimer = 0;

    }
}
