using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserPanelController : MonoBehaviour {

    public InputField username;
    public Dropdown currentTest;
    public Slider progressSlider;

    public string Username
    {
        get { return username.text; }
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
