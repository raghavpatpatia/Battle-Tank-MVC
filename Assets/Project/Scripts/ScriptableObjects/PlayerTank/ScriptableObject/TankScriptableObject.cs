using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObjects/Tank/TankScriptableObject")]
public class TankScriptableObject : ScriptableObject
{
    public TankView tankView;
    public Vector3 tankCameraPosition;
    public Vector3 tankCameraRotation;
    public float tankSpeed;
    public float rotationSpeed;
}