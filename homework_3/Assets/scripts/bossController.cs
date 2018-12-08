using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossController : MonoBehaviour {
    public int life;
    public static bool Gameover = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        checklife();
        if (Gameover == true) Destroy(gameObject);
	}

    private void OnTriggerEnter(Collider other)
    {
        life --;

        Destroy(other.gameObject);
    }

    void checklife() {
        if (life <= 0)
        {
            Gameover = true;
        }
    }

}
