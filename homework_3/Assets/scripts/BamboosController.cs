using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamboosController : MonoBehaviour {
    public GameObject m_bamboos;
    public float m_timebetweentrees;

	// Use this for initialization
	void Start () {
        StartCoroutine(TreeCreate());
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator TreeCreate(){
        while (true)
        {
            yield return new WaitForSeconds(m_timebetweentrees);
            GameObject bamboo = Instantiate(m_bamboos, transform.position, transform.rotation);
            bamboo.transform.parent = GameObject.Find("bamboos").transform;
        }
    }
}
