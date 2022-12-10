using UnityEngine;

public class Tutorial02 : MonoBehaviour
{
    void OnConnectionEvent() { }
    void OnMessageArrived() { }

    private void Update()
    {
        var sender = GetComponent<SerialController>();
        if (Input.GetKeyDown(KeyCode.A))
        {
            sender.SendSerialMessage("0");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            sender.SendSerialMessage("40");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            sender.SendSerialMessage("200");
        }
    }
}
