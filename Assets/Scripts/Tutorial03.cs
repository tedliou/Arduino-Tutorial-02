using UnityEngine;

public class Tutorial03 : MonoBehaviour
{
    private void Update()
    {
        var sender = GetComponent<SerialController>();
        if (Input.GetKeyDown(KeyCode.Z))
            sender.SendSerialMessage("255,0,0");
        else if (Input.GetKeyDown(KeyCode.X))
            sender.SendSerialMessage("0,255,0");
        else if (Input.GetKeyDown(KeyCode.C))
            sender.SendSerialMessage("0,0,255");
    }
}
