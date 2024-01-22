using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public TankController tankController {get; private set;}
    private float movement;
    private float rotate;
    public List<MeshRenderer> tankParts;
    public void SetTankController(TankController tankController) => this.tankController = tankController;
    public Rigidbody GetRigidbody() => rb;
    private void Update()
    {
        if (tankController != null)
        {
            Movement();
        }
    }
    private void Movement()
    {
        movement = Input.GetAxisRaw("Vertical");
        rotate = Input.GetAxisRaw("Horizontal");
        
        if (movement != 0) tankController.Move(movement);
        if (rotate != 0) tankController.Rotate(rotate);
    }
}
