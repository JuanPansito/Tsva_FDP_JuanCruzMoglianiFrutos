using UnityEngine;

public class cameraSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("resetCamera", 1);
        
    }
    void resetCamera()
    {
        Camera.main.Reset();
    }
}
