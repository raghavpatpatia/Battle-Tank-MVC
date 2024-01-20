using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObjectList", menuName = "ScriptableObjects/Tank/TankScriptableObjectList")]
public class TankScriptableObjectList : ScriptableObject
{
    public TankScriptableObject[] list;
}