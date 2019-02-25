using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("HIT!");
        SceneManager.LoadScene(1);
        GameManager.instance.Score++;
        other.gameObject.GetComponent<PlayerControl>().EnterTimes++;
    }
}
