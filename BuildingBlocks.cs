using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlocks: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public Material blockMaterial;
    public Material greenTransparent;
    public Material yellowTransparent;
    public Camera mainCamera;


    public void setMaterial(Material newMaterial)
    {
        this.blockMaterial = newMaterial;
    }
    void Update()

    {

        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit)
        {
            if (hitInfo.transform.tag.Equals("Base"))
            {
                transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + 0.5f, hitInfo.point.z);
            }
            if (hitInfo.transform.tag.Equals("MyCube"))
            {

                GetComponent<Renderer>().material = greenTransparent;
                transform.position = hitInfo.transform.position + hitInfo.normal;
            }
            else
            {
                GetComponent<Renderer>().material = yellowTransparent;
            }
        }
        else
        {
            //Debug.Log("No hit");
        }


        if (Input.GetMouseButtonUp(0))
        {
            #region Screen To World
          
            if (hit)
            {

                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.tag = "MyCube";
                cube.GetComponent<Renderer>().material = blockMaterial;



                if (hitInfo.transform.tag.Equals("Base"))
                {
                    cube.transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + 0.5f, hitInfo.point.z);
                }
                else
                {
                    cube.transform.position = hitInfo.transform.position + hitInfo.normal;
                    Debug.Log(hitInfo.normal);
                    Debug.Log(hitInfo.transform.position);
                   
                }
            }
            else
            {
                //Debug.Log("No hit");
            }
            #endregion
        }
    }
}