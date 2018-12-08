using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject m_arrow;
    public float m_timebetweenarrow;
    public int m_enemyNumber;
    public float m_threshold;

    private float _currtime;
    // Use this for initialization
    void Start()
    {
        _currtime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioController.average[m_enemyNumber]*1000 > m_threshold && (Time.time - _currtime)>=m_timebetweenarrow)
        {
            GameObject bullet = Instantiate(m_arrow, transform.position, transform.rotation);
            bullet.transform.parent = GameObject.Find("bamboos").transform;
            _currtime = Time.time;
        }
        if (bossController.Gameover == true) Destroy(gameObject);
    }

   
}
