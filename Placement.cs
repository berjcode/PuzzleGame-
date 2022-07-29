using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    Camera sideCamera;
    Vector2 firsPosition;
    GameObject[] boxArray;
    //Level Control
    int placedPiece = 1;
    int totalPiece = 12;


    private void OnMouseDrag()
    {
        Vector3 pozisyon= sideCamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;


    }



    void Start()
    {
        sideCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        firsPosition=transform.position;
        boxArray = GameObject.FindGameObjectsWithTag("Box");
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach(GameObject Box in boxArray)
            {
                if(Box.name==gameObject.name)
                {
                    float mesafe = Vector3.Distance(Box.transform.position, transform.position);
                    {
                        if(mesafe<=1)
                        {
                            transform.position = Box.transform.position;
                            Number();
                            this.enabled = false;
                            Destroy(this);

                        }
                        else
                        {
                            transform.position = firsPosition;
                        }
                    }
                }
            }
        }
    }

    // Level Control
    public void Number()
    {
        placedPiece++;
        if (placedPiece == totalPiece)
        {
            Debug.Log("Sonraki Bölüme Geç.");
        }
    }
}
