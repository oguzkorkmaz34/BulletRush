using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyCcharacterController : MonoBehaviour
{

    [SerializeField] Rigidbody rb;
    [SerializeField] float moveSpeed;

    protected void Move(Vector3 direction)
    {
        rb.velocity = direction * moveSpeed * Time.deltaTime;
    }



}
public class PplayerController : MyCcharacterController
{
    [SerializeField] SscreenTouchController input;
    private void FixedUpdate()
    {
        var direction = new Vector3(input.Direction.x, 0, input.Direction.y);
        Move(direction);
    }
}

public class EenemyController : MyCcharacterController
{

    private void FixedUpdate()
    {
        var direction = new Vector3(input.Direction.x, 0, input.Direction.y);
        Move(direction);
    }

}