using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClientSession : MonoBehaviour {

    public bool useHLAPI;
    private NetworkManager m_netManager;
    private NetworkWriter writer;
    private byte[] buffer = new byte[1024];
    private int bufferSize = 1024;
    private bool clientStarted = false;

    public void StartClient()
    {

        Debug.Log("Starting Client.");

        if (useHLAPI)
        {
            m_netManager.StartClient();
        }

        clientStarted = true;
    }

    public void SendProgress(string jsonProgress)
    {
        // Custom message type for us to use.
        short msgType = 444;
        writer.StartMessage(msgType);
        writer.Write(jsonProgress);
        writer.FinishMessage();
        m_netManager.client.SendWriter(writer, 0);
    }

    // Use this for initialization
    void Start () {
        if (useHLAPI)
        {
            m_netManager = gameObject.AddComponent<NetworkManager>();
            //gameObject.AddComponent<NetworkManagerHUD>();
            writer = new NetworkWriter(buffer);
            
        }	
        else
        {

        }
	}

	// Update is called once per frame
	void Update () {

	}

    public bool ClientStarted
    {
        get { return clientStarted; }
    }
}
