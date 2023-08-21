using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors; //dynamic array of colors
    public Renderer[] mats; //dynamic array of renderer or say the components of which the car has been built from
    public void Red(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color = colors[0];
        }
    }
    public void Green(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color = colors[1];
        }
    }
    public void Blue(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color = colors[2];
        }
    }
    public void Yellow(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color = colors[3];
        }
    }
    
}
