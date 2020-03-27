using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Settings", menuName ="Settings")]
public class Settings : ScriptableObject
{
    //[Range(0.1f,1)]
    //public float timestep;
  
    //[Range(-5, 5)]
    //public float speed;
    //[Space]
    public float shake;
    [Space]
    [Range(0.1f, 10)]
    public float intensity;

    //public bool gameover;
    public void Shake() {
        shake = intensity;
    }


 }
