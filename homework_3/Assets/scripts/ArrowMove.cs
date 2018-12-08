using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowMove : MonoBehaviour {

    // Use this for initialization
    public float m_speed;
    public float m_treelife;

    private GameObject boss;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, m_treelife);
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position += transform.forward * Time.deltaTime * m_speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sheild")
        {
            dircheck();
        }
    }

    private void dircheck()
    {
        try
        {
            boss = GameObject.Find("boss");
            Quaternion q = Quaternion.LookRotation(boss.transform.position - transform.position);
            transform.rotation = q;
        }
        catch (Exception)
        {
            GetComponent<ArrowMove>().enabled = false;
            Destroy(gameObject);
        }
    }
}
