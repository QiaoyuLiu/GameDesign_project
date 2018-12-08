using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheild_creator : MonoBehaviour {
    public GameObject m_sheild;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(m_sheild, transform.position, transform.rotation);
    }
}
