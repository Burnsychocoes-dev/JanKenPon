using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    //[Serialized Field]
    protected Weapon weapon;

    //[Serialized Field]
    protected int maxHp;
    protected int hp;

    //[Serialized Field]
    protected float movementSpeed;

	// Use this for initialization
	void Start () {
        hp = maxHp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void Move()
    {
        if (!weapon.inRangeForAttack())
        {

        }
    }
}
