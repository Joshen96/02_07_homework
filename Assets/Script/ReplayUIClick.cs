using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayUIClick : MonoBehaviour
{
   public void OnClickReplay()
    {
        Debug.Log("���÷��̹�ư����");
        Time.timeScale = 1f;  //
        Rockhit.mosterdie = false;  // ����ƽ ������� ���÷��̽� �ٽ� false 
        SceneManager.LoadScene(0); 
        
    }
    
}
