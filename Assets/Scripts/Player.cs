using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnimator;
    public StarterAssets.StarterAssetsInputs playerInputs;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInputs.move == Vector2.zero)
        {
            // Debug.Log("not moving");
            playerAnimator.SetBool("isMoving", false);
        }
        else
        {
            // Debug.Log("moving");
            playerAnimator.SetBool("isMoving", true);
        }
        playerAnimator.SetBool("isRunning", playerInputs.sprint);
    }
}
