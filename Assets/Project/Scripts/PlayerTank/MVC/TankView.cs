using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankController tankController {get; private set;}
    public void SetTankController(TankController tankController) => this.tankController = tankController;
}
