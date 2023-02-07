using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UItext : MonoBehaviour
{
    
    

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = Keycount.key_count.ToString();
    }
}
