using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_clear : MonoBehaviour
{

    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("���� ����");

            if (Keycount.key_count == 0&& Rockhit.mosterdie==true)
            {
                Debug.Log("Ŭ����");
                Time.timeScale = 0;
            }
            else
            {
                
                Debug.Log("����Ű��"+ Keycount.key_count +"���� ��������"+ Rockhit.mosterdie + "Ŭ����Ұ�");
            }


        }
    }
}
