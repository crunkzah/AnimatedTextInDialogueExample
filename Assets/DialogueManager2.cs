using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager2 : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    [TextArea(5, 25)]
    public string Line = "Hello sailor! Unfortunately there is a radio connected to my head.";
    public float charDelay = 0.1f;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        }
    }

}
