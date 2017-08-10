using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
public class UserConsoleController : MonoBehaviour {

    public UserPanelController userPanel;
    public bool sendProgress = false;

    private ProgressTracker tracker;
    private ClientSession clientSession;
    int maxConnections = 10;
    int myReliableChannelId;
    int myUnreliableChannelId;
    int socketId;
    int socketPort = 8888;
    int connectionId;

    private void Awake()
    {
        tracker = GetComponent<ProgressTracker>();
        clientSession = GetComponent<ClientSession>();
    }

    // Use this for initialization
    void Start () {

    }

    void SendMessage()
    {

    }

    public Progress GetProgress()
    {
        Progress temp = new Progress();

        temp.currentTest = userPanel.CurrentTest;
        temp.username = userPanel.Username;
        temp.maxTestNum = userPanel.MaxTestNum;
        temp.currentTestNum = userPanel.CurrentTestNum;
        return temp;
    }
	public void SendProgress(string jsonProgress)
    {
        
    }
	// Update is called once per frame
	void Update () {
		if(GetComponent<ClientSession>().ClientStarted && !sendProgress)
        {
            sendProgress = true;
            tracker.StartTracking();
        }
	}
}
