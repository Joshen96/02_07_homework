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
        if (collision.gameObject.name == Ground) //���� ������
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == monster) //���Ϳ� ������ �̶� ���� Ŭ���� ��� �ؾ���
        {
            collision.gameObject.SetActive(false);
            mosterdie = true;
            Destroy(this.gameObject);
            Debug.Log("���� ����" + mosterdie);
        }

        Destroy(this.gameObject, 5f);
    }
}
