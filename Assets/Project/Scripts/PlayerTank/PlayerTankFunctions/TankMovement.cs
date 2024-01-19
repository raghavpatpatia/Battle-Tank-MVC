using UnityEngine;
public class TankMovement
{
    private TankController controller;
    public TankMovement(TankController controller)
    {
        this.controller = controller;
    }

    public void Move(float movement)
    {
        controller.rb.velocity = controller.tankView.transform.forward * movement * controller.tankModel.tankSpeed * Time.deltaTime;
    }

    public void Rotate(float rotate)
    {
        Vector3 rotation = new Vector3(0, rotate * controller.tankModel.rotationSpeed, 0);
        Quaternion deltaRotation = Quaternion.Euler(rotation * Time.deltaTime);
        controller.rb.MoveRotation(controller.rb.rotation * deltaRotation);
    }
}