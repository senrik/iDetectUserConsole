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
        //StartCoroutine(TrackProgress());
	}

    public void StartTracking()
    {
        Debug.Log("Starting Tracking");
        StartCoroutine(TrackProgress());
    }

	IEnumerator TrackProgress()
    {
        while (m_userConsole.sendProgress)
        {
            sessionProgress = m_userConsole.GetProgress();
            yield return new WaitForSeconds(0.5f);
            // send sessionProgress
            string jsonProgress = JsonUtility.ToJson(sessionProgress);
            Debug.Log(jsonProgress);
            GetComponent<ClientSession>().SendProgress(jsonProgress);

        }
    }
	// Update is called once per frame
	void Update () {

	}

    public string JsonProgress
    {
        get { return JsonUtility.ToJson(sessionProgress); }
    }
}
