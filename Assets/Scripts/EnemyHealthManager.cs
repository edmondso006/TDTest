using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour {

    public int health;
    private int currentHealth;


    private InputField input;

	// Use this for initialization
	void Start () {
        currentHealth = health;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            ScoreScript.score++;
            
        }
	}

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
