using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{//  Level England Control 

    public GameObject winMenuUl;

    int totelPiece = 5;
    int firstPiece = 0;

    public void  LevelEnglandFinish()
    {
        firstPiece++;

        if(firstPiece == totelPiece)
        {
            Debug.Log("OYUN biti");
           winMenuUl.SetActive(true);
        }
    }

 
}

