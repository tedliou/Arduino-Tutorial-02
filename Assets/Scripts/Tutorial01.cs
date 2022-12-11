using UnityEngine;

public class Tutorial01 : MonoBehaviour
{
    private void Update()
    {
        var sender = GetComponent<SerialController>();
        if (Input.GetKeyDown(KeyCode.Q))
            sender.SendSerialMessage("1");
        else if (Input.GetKeyDown(KeyCode.E))
            sender.SendSerialMessage("0");
    }
}
