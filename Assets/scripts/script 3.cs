using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
   {

for(int num1=1;num1<11;num1++)
{    int s = Multyplie(num1,5);
Debug.Log("5 x "+num1+"="+s);

}

 
int   Multyplie (int num1,int num2)
{
return num1*num2;
}

   }}