using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleDisplay : MonoBehaviour
{
    public Text consoleText;
    public float timetext = 5f;

    void Start()
    {
        consoleText.text = "";
    }

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        consoleText.text += logString + "\n";
        StartCoroutine(DestroyText());
    }

    IEnumerator DestroyText()
    {
        yield return new WaitForSeconds(timetext);
        consoleText.text = "";
    }
}
