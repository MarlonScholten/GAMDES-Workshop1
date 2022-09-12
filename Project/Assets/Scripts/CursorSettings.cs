using UnityEngine;

public class CursorSettings : MonoBehaviour
{
    public bool hideCursor;
    public bool lockCursor;
    private void Start()
    {
        if(hideCursor)
            Cursor.visible = false;
        
        if(lockCursor)
            Cursor.lockState = CursorLockMode.Locked;
    }
}
