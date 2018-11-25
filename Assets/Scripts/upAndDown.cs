using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upAndDown : MonoBehaviour {

    bool isChanged = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -3.88f)  // 下界
        {
            isChanged = false;
        }
        else if (transform.position.y >= 0.93f)   // 上界
        {
            isChanged = true;
        }
        if (isChanged)
        {
            transform.Translate(0, -4 * Time.deltaTime, 0, Space.World);
        }
        else
        {
            transform.Translate(0, 4 * Time.deltaTime, 0, Space.World);
        }
	}
}
