using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftAndRight : MonoBehaviour {

    bool isChanged = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= 65.1f)  // 左界
        {
            isChanged = false;
        }
        else if (transform.position.x >= 71.8f)   // 右界
        {
            isChanged = true;
        }
        if (isChanged)
        {
            transform.Translate(-4 * Time.deltaTime, 0, 0, Space.World);
        }
        else
        {
            transform.Translate(4 * Time.deltaTime, 0, 0, Space.World);
        }
    }

}

