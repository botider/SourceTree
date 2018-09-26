using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {

    public Transform brick;
    Vector3 position;
    Vector3 scale;
    [Range(10, 100)]
    public int resolution = 10;

    void Awake ()
    {
        //GetComponent<GameObject>();
        //for (int y = 0; y < 5; y++)
        //{
        //    for (int x = 0; x < 5; x++)
        //    {
        //        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //        cube.AddComponent<Rigidbody>();
        //        cube.transform.position = new Vector3(x, y, 0);
        //    }
        //}

      
            for (int i = 0; i < resolution; i++)
            {
            brick.localScale = Vector3.one*(2f/resolution) ;
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x;
            Instantiate(brick, position, Quaternion.identity);
            }
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
