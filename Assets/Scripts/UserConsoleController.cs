using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
public class UserConsoleController : MonoBehaviour {

    public UserPanelController userPanel;
    public bool sendProgress = true;

    int maxConnections = 10;
    int myReliableChannelId;
    int myUnreliableChannelId;
    int hostId;
    int socketPort = 8888;
    int connectionId;

    // Use this for initialization
    void Start () {
        NetworkTransport.Init();
        ConnectionConfig config = new ConnectionConfig();
        myReliableChannelId = config.AddChannel(QosType.Reliable);
        myUnreliableChannelId = config.AddChannel(QosType.Unreliable);
        HostTopology topolgy = new HostTopology(config, maxConnections);
	}

    void Connect()
    {
        Network.Connect()
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
		
	}
}
