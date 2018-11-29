using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject UICoin;

    public float speed = 7f;
    public float upSpeed = 5f;
    public int money;
    public Text moneyText;

    Rigidbody2D myRigid;
    Quaternion origin;

	// Use this for initialization
	void Start () {
        myRigid = GetComponent<Rigidbody2D>();
        origin = transform.rotation;
        money = 0;
        SetMoney();
	}

    // Update is called once per frame
    void Update()
    {
        // 锁一下旋转，免得出什么意外。。。我就爱锁旋转(x
        transform.rotation = origin;

        // 移动
        transform.Translate(speed * Time.deltaTime, 0, 0);
        UICoin.transform.Translate(speed * Time.deltaTime, 0, 0);
        // 跳跃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 0.85f, LayerMask.GetMask("Floor"))) // 第三参数distance表示射线长度, 大概试一试就知道了
            {
                myRigid.AddForce(Vector3.up * upSpeed, ForceMode2D.Impulse);
            }
        }

        // 放缩
        if (transform.localScale.x > 0.5f)
        {
            //按下A键可以缩小方块
            if (Input.GetKey(KeyCode.A))
            {
                transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f, transform.localScale.z - 0.01f);
                speed += 0.05f;
                upSpeed += 0.05f;
            }
        }
        if (transform.localScale.x <= 1)
        {
            //按下D键可以变大方块
            if (Input.GetKey(KeyCode.D))
            {
                //检测到方块上面是天花板则不能变大
                if (Physics2D.Raycast(transform.position, Vector2.up, 0.9f, LayerMask.GetMask("Floor")))
                {

                }
                else
                {
                    transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f, transform.localScale.z + 0.01f);
                    speed -= 0.05f;
                    upSpeed -= 0.05f;
                }
            }
        }
    }

    public void SetMoney()
    {
        moneyText.text = money.ToString();
    }

}
