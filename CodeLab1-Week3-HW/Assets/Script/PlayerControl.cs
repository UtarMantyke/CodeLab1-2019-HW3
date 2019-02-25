using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
    {
    
        public KeyCode upKey;
        public KeyCode downKey;
        public KeyCode leftKey;
        public KeyCode rightKey;
        public float forceAmount = 1;
    
        public int EnterTimes=0;
        
        public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newForce = new Vector2(0,0); //the force we will add to our player
		
        if (Input.GetKey(upKey)) //When someone presses "W"
        {
            newForce.y += forceAmount;
        }
		
        if (Input.GetKey(downKey)) //When someone presses "S"
        {
            newForce.y -= forceAmount;
        }
		
        if (Input.GetKey(leftKey)) //When someone presses "A"
        {
            newForce.x -= forceAmount;
        }
		
        if (Input.GetKey(rightKey)) //When someone presses "D"
        {
            newForce.x += forceAmount;
        }
		
        rb.AddForce(newForce);
        
    }
    
    }
