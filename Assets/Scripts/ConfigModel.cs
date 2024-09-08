using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ConfigModel : MonoBehaviour
{

    public Resolution Resolution{ get; set; }

    public bool Windowmode { get; set; }

    public bool Vsync { get; set; }

}

[Serializable]
public class Resolution
{
    public int width { get; set; }
    public int Width { get; internal set; }
    public int height { get; set; }
    public int Height { get; internal set; }
}
