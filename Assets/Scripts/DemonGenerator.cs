using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonGenerator : MonoBehaviour
{
    public GameObject demonPrefab;

	void Start ()
    {
        Invoke("generateDemon",5f);
	}
	
    void generateDemon()
    {
        Instantiate(demonPrefab, this.transform);
        Invoke("generateDemon", 5f);
    }
}
