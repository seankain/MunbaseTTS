using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SharpTalk;

public class MunbaseTTS : MonoBehaviour
{
    private InputField textInput;
    private FonixTalkEngine tts;

    // Start is called before the first frame update
    void Start()
    {
        textInput = GetComponent<InputField>();
        tts = new FonixTalkEngine();
        //using (var tts = new FonixTalkEngine())
        //{
        //    string msg;
        //    while ((msg = Console.ReadLine()) != "exit")
        //    {
        //        tts.Speak(msg);
        //    }
        //}
        //phoneme<duration,pitch>
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            tts.Speak(textInput.text);
        }
    }

    private void OnDestroy()
    {
        tts.Dispose();
    }

}
