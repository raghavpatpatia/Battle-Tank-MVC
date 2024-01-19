using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankController tankController {get; private set;}
    private float movement;
    private float rotate;
    [SerializeField] private Rigidbody rb;
    public void SetTankController(TankController tankController) => this.tankController = tankController;
    public Rigidbody GetRigidbody() => rb;
    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        movement = Input.GetAxisRaw("Vertical");
        rotate = Input.GetAxisRaw("Horizontal");
        
        if (movement != 0) tankController.Move(movement);
        if (rotate != 0) tankController.Rotate(rotate);
    }
}
