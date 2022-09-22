using UnityEngine;
using UnityEngine.InputSystem;

public class Pickup : MonoBehaviour
{
    private int amountOfItemsHeld = 0;
    
    private void OnPickupAction(InputValue inputValue)
    {   
        Ray cursorRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(cursorRay.origin, cursorRay.direction * 1000.0f, Color.red, 1.0f);
        
        if (!Physics.Raycast(cursorRay, out var hit, 200.0f)) return;
        if (hit.transform.parent == null) return;
        if (!hit.transform.parent.gameObject.CompareTag("Cross")) return;

        Destroy(hit.transform.parent.gameObject);
        amountOfItemsHeld++;
    }

    private void OnReviveAction(InputValue inputValue)
    {
        if (amountOfItemsHeld <= 0) return;
        
        Ray cursorRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(cursorRay.origin, cursorRay.direction * 1000.0f, Color.red, 1.0f);
        
        if (!Physics.Raycast(cursorRay, out var hit, 200.0f)) return;
        if (!hit.transform.gameObject.CompareTag("Revivable")) return;

        hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
        amountOfItemsHeld--;
    }
}
