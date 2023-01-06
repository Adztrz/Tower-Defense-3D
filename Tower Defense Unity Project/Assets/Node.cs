using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 offset;

    private GameObject turret;


    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't Build There ");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);

            
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor; 
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }



    void Update()
    {
        
    }
}
