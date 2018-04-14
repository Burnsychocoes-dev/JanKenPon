using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    protected Collider collider;

    //[Serialized Field]
    protected int damage;

    //attack speed in hit/sec
    //[Serialized Field]
    protected float attackSpeed;

    //[Serialized Field]
    protected float range;

    //cd for the next attack
    protected float cd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool inRangeForAttack()
    {
        return false;
    }
}
