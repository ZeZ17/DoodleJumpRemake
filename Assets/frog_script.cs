using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog_script : MonoBehaviour
{
    public Rigidbody2D frogRigidBody;
    public float jumpStrength;
    //public LogicScript logic;
    public bool frogIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && frogIsAlive)
        {
            frogRigidBody.velocity = Vector2.up * jumpStrength;
        }
    }

}
