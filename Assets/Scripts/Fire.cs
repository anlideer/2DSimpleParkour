using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject player;

    bool isInSpace = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isInSpace)
        {
            if (Mathf.Abs(player.transform.position.x - transform.position.x) < 4)
            {
                transform.Translate(0, -4 * Time.deltaTime, 0, Space.World);
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isInSpace = false;
        }
        else if (collision.gameObject.tag == "Player")
        {
            GM.isOver = true;
            GM.winned = false;
        }
    }
}
