using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   
    
    private void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision) //�̶� ui�� ǥ�����ֱ�
    {
        if(collision.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
            Keycount.key_count--;
            Debug.Log("����Ȯ��:"+Keycount.key_count);
            
           
        }
    }
}
