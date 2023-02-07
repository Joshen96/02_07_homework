using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockhit : MonoBehaviour
{
    public string monster;
    public GameObject Ground;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Ground.gameObject) //���� ������
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == monster) //���Ϳ� ������ �̶� ���� Ŭ���� ��� �ؾ���
        {
            Destroy(this.gameObject);
            collision.gameObject.SetActive(false);

        }
    }
}
