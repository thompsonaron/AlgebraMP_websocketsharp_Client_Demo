using System;
using UnityEngine;
using WebSocketSharp;
using EventArgs = System.EventArgs;


public class Client : MonoBehaviour
{
    WebSocket ws;
    // Start is called before the first frame update
    void Start()
    {
        ws = new WebSocket("ws://localhost:8080/demo");
        ws.OnOpen += OnSocketOpen;
        ws.Connect();
    }

    private void OnSocketOpen(object sender, EventArgs e)
    {
        Debug.Log("We are in!");
        ws.Send(new byte[] { 0, 1, 2, 3, 4, 5 });
    }


}
