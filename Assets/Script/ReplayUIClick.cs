using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayUIClick : MonoBehaviour
{
   public void OnClickReplay()
    {
        Debug.Log("리플레이버튼눌림");
        Time.timeScale = 1f;  //
        Rockhit.mosterdie = false;  // 스태틱 사용으로 리플레이시 다시 false 
        SceneManager.LoadScene(0); 
        
    }
    
}
