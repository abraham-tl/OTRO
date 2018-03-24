using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLists : MonoBehaviour {
    public GameObject[] allGameObjects;
	// Use this for initialization
	void Start () {
        ArrayList aList = new ArrayList ();
        Object[] allObjects = GameObject.FindObjectsOfType(typeof (Object)) as Object[];

        foreach (Object o in allObjects)
        {
            GameObject go = o as GameObject;
            if (go != null)
            {
                aList.Add(go);
            }
        }
        allGameObjects = new GameObject[aList.Count];
        aList.CopyTo(allGameObjects);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
