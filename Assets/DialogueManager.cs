using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI text_label;
    [TextArea(5, 25)]
    public string Line = "Hello sailor! Unfortunately there is a radio connected to my head. Hello sailor! Unfortunately there is a radio connected to my head";
    public float charDelay = 0.05f;
    public float specialCharDelay = 0.15f;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartDialogue(Line);
        }
    }

    static List<char> special_letters = new List<char>{'?', '!', '.'};

    public void StartDialogue(string txt)
    {
        StopAllCoroutines();
        text_label.SetText("");
        
        float delay_for_next_letter = 0;
        for(int i = 0; i < txt.Length; i++)
        {
            float _charDelay = charDelay;

            if(special_letters.Contains(txt[i]))
                _charDelay = specialCharDelay;

            delay_for_next_letter += _charDelay;
            StartCoroutine(TypeOneChar(txt[i], delay_for_next_letter));
        }
    }

    IEnumerator TypeOneChar(char letter_to_type, float delay)
    {
        yield return new WaitForSeconds(delay);
        text_label.SetText(text_label.text + letter_to_type);
    }
}
