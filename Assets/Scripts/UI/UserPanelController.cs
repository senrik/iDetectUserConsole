using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserPanelController : MonoBehaviour {

    public InputField username;
    public Dropdown currentTest;
    public Slider progressSlider;

    private bool noEdit = true;
    private string prevUsername = "<username>";

    void UpdateUsername(InputField input)
    {
        prevUsername = input.text;
    }

    private void Start()
    {
        username.onEndEdit.AddListener(delegate { UpdateUsername(username); });
    }

    public string Username
    {
        get { return prevUsername; }
    }

    public string CurrentTest
    {
        get { return currentTest.captionText.text; }
    }

    public int MaxTestNum
    {
        get { return (int)progressSlider.maxValue; }
    }

    public int CurrentTestNum
    {
        get { return (int)progressSlider.value; }
    }
}
