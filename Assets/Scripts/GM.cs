using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

    public GameObject button;
    public Text result;

    public static bool isOver;
    public static bool winned;

	// Use this for initialization
	void Start () {
        isOver = winned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isOver)
        {
            if (winned)
                result.text = "游戏胜利";
            else
                result.text = "游戏失败";
            result.gameObject.SetActive(true);
            button.SetActive(true);
        }
	}

    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }
}
