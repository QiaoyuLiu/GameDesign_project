using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandit_controller : MonoBehaviour {
    private Animator _animator;
    private float _x;
    [Range (-1f,1f)]
    private float _y;

    public float m_life;
    public float m_speed;
	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Mathf.Clamp(transform.position.z,-12.9f , 4.9f);
        move();
        attack();
        if (bossController.Gameover == true) Destroy(gameObject);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            Destroy(other.gameObject);
            lifecheck();
        }
    }

    float Constraint(float x)
    {
        if ( x >= 1 ) return 1;
        if (x <= -1) return -1;
        else return x;
    }

    void move() {
        _y = Input.GetAxis("Vertical");
        _x = Input.GetAxis("Horizontal");
        _animator.SetFloat("x", _x);
        _animator.SetFloat("y", _y);

        float zMove = _x * Time.deltaTime * m_speed;
        transform.Translate(zMove, 0f, 0f);
        Vector3 clampedPosition = transform.position;
        clampedPosition.z = Mathf.Clamp(transform.position.z, -7f, 0f);
        transform.position = clampedPosition;
    }

    void attack() {
        if (Input.GetKeyDown(KeyCode.Space)) _animator.SetLayerWeight(1,1);
        if (Input.GetKeyUp(KeyCode.Space)) _animator.SetLayerWeight(1, 0);
    }

    void lifecheck() {
        --m_life;
        if (m_life <= 0) {
            Destroy(gameObject);
        bossController.Gameover = true;
        }
    }
}
