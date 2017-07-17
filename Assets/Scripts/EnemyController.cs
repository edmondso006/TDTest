using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;

    public PlayerController thePlayer;
    public int damageToGive;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();

	}
	
	// Update is called once per frame
	void Update () {
        if(thePlayer != null)
        {
            //turning the enemy to look at the player
            transform.LookAt(thePlayer.transform.position);
        }
        
	}

    //want to move rigid body in fixed update and not just update
    void FixedUpdate()
    {
        myRB.velocity = transform.forward * moveSpeed;  
    }

    void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.tag == "player")
            {
                other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);

            }
  
    }
}
