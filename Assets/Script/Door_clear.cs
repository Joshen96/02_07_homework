using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_clear : MonoBehaviour
{

    public static bool uIclear = false;

    private void Start()
    {
        uIclear = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("���� ����");

            if (Keycount.key_count == 0&& Rockhit.mosterdie==true)
            {
                Debug.Log("Ŭ����");
                Time.timeScale = 0;
                uIclear = true;
            }
            else
            {
                
                Debug.Log("����Ű��"+ Keycount.key_count +"���� ��������"+ Rockhit.mosterdie + "Ŭ����Ұ�");
            }


        }
    }
}
