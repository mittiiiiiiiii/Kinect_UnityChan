using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll_35 : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform Object;
    double l,lx,ly,r,rx,ry;
    
    void Update()
    {
    
        lx = System.Math.Abs(target1.position.x-Object.position.x);
        ly = System.Math.Abs(target1.position.y-Object.position.y);

        rx =System.Math.Abs(target2.position.x-Object.position.x);
        ry = System.Math.Abs(target2.position.y-Object.position.y);

        l=lx+ly;
        r=rx+ry;

        if(l<0.2||r<0.2){
            GameObject obj = GameObject.Find ("Boll_35");//対応するノーツの名前に変える！！
           
            newParticle.Play();
            OffsetPosition.score_high += 300;
            Debug.Log("boll35_" + OffsetPosition.score_high);
            Destroy (obj);
            
        }
        }
}
