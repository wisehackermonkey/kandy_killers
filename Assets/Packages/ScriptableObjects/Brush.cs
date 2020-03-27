using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
[CreateAssetMenu(fileName = "New Brush", menuName = "Brushs")]
public class Brush : ScriptableObject
{
    public bool shake;
    public  string brush_name;
    public float intensity;
    public GameObject brush_obj;
    public void ShakeCamera() {
        Debug.Log("Shakes Camera");
        brush_obj.GetComponent<StressReceiver>().InduceStress(intensity);
    }
}
