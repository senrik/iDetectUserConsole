using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour {

    public Progress sessionProgress;

    private UserConsoleController m_userConsole;
    private void Awake()
    {
        m_userConsole = GetComponent<UserConsoleController>();
    }
    // Use this for initialization
    void Start () {
        sessionProgress = m_userConsole.GetProgress();
        StartCoroutine(TrackProgress());
	}
	IEnumerator TrackProgress()
    {
        while (m_userConsole.sendProgress)
        {
            sessionProgress = m_userConsole.GetProgress();
            yield return new WaitForSeconds(0.5f);
            // send sessionProgress
            Debug.Log(JsonUtility.ToJson(sessionProgress));
        }
    }
	// Update is called once per frame
	void Update () {

	}
}
