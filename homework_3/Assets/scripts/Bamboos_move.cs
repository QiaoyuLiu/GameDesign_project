using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboos_move : MonoBehaviour {
    public float m_speed;
    public float m_treelife;


	// Use this for initialization
	void Start () {
        Destroy(gameObject, m_treelife);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += transform.forward * Time.deltaTime * m_speed;
	}
}
