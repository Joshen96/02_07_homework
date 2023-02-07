using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockhit : MonoBehaviour
{
    public string monster;
    //public GameObject Ground;
    public string Ground;
    public static bool mosterdie = false;

    private void Start()
    {
        //mosterdie = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == Ground) //땅에 맞을때
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == monster) //몬스터에 맞을때 이때 몬스터 클리어 기록 해야함
        {
            collision.gameObject.SetActive(false);
            mosterdie = true;
            Destroy(this.gameObject);
            Debug.Log("몬스터 잡음" + mosterdie);
        }

        Destroy(this.gameObject, 5f);
    }
}
