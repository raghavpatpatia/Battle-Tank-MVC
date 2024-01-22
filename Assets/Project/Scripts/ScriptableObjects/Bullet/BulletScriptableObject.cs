using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/Bullet/BulletScriptableObject")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletView bulletview;
    public Gradient particleColor; 
    public float bulletSpeed;
}