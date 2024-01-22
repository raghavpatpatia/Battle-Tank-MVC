using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObjects/Tank/TankScriptableObject")]
public class TankScriptableObject : ScriptableObject
{
    public TankType tankType;
    public BulletScriptableObject bullet;
    public TankView tankView;
    public Material tankMaterial;
    public float tankSpeed;
    public float rotationSpeed;
}