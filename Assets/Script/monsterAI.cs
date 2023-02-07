using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAI : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pos; //������ġ

    public float delta = 5.0f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 3.0f; // �̵��ӵ�

    Rigidbody2D mosterrigi;




    void Start()
    {
        mosterrigi = GetComponent<Rigidbody2D>();
        mosterrigi.constraints = RigidbodyConstraints2D.FreezeRotation;
        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);

        // �¿� �̵��� �ִ�ġ �� ���� ó���� �̷��� ���ٿ� ���ְ� �ϳ׿�.

        transform.position = v;

    }

  
}
