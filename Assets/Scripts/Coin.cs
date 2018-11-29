using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public Transform UICoin;    // 这里直接手动找了位置, 那个位置跟Player一起跑，相对屏幕静止
    public GameObject player;

    bool isCollected = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (isCollected)
            CoinMove();
	}

    public void CoinMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, UICoin.position, 5*Time.deltaTime);
        if (Vector3.Distance(transform.position, UICoin.position) < 0.1f)
        {
            player.GetComponent<Player>().money++;
            player.GetComponent<Player>().SetMoney();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            isCollected = true;
    }

}

