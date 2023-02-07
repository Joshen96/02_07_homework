using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockhit : MonoBehaviour
{
    public string monster;
    public GameObject Ground;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Ground.gameObject) //땅에 맞을때
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == monster) //몬스터에 맞을때 이때 몬스터 클리어 기록 해야함
        {
            Destroy(this.gameObject);
            collision.gameObject.SetActive(false);

        }
    }
}
