using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float timer =0f;
    float nexTime = 0f;
    public int counter = 10;
    public int minheight = 1;
    public int maxheight = 10;
    public float horizontalSpacing = 1f;
    public float verticalSpacing = 1.1f;
	// Update is called once per frame
	void Update () {
        if (counter > 0 && Time.fixedTime > nexTime)
        {
            nexTime = Time.fixedTime + timer ;
            int randomNumber = Random.Range (minheight , maxheight );
            for (int i =0; i<randomNumber;i++)
            {
                GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = new Vector3(counter * horizontalSpacing, i * verticalSpacing, 0);
              
            }
            counter--;
        }
	}
}
