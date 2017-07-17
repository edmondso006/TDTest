using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int health;
    private int currentHealth;
    public Material damagedMaterial;
    public Material[] materials;
    public float hurtTime;
    public GameObject healthCoin;


	// Use this for initialization
	void Start () {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;

        hurtTime = hurtTime * Time.deltaTime;

        if(currentHealth == 4)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }else if(currentHealth == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }
        else if(currentHealth == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[2];
        }
        else if (currentHealth == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[3];

        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Current Health:" + currentHealth);
        
        if (collision.transform.tag == "Health")
        {
            Destroy(healthCoin);
            currentHealth = health;
            Debug.Log("New Current Health: " + currentHealth);
        }
    }
}
