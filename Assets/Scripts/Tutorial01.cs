using UnityEngine;

public class Tutorial01 : MonoBehaviour
{
    void OnConnectionEvent() { }
    void OnMessageArrived() { }

    private void Update()
    {
        var sender = GetComponent<SerialController>();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            sender.SendSerialMessage("Open");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            sender.SendSerialMessage("Close");
        }
    }
}
