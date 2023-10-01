using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dz1 : MonoBehaviour
{
    public float Speed = 10f;
    public GameObject sphere;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    sphere.SetActive(!sphere.activeSelf);
            //transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            //Debug.Log(sphere.gameObject.activeSelf);
            //if (sphere.activeSelf == false)
            //{
            //    sphere.SetActive(true);
            //}
            //if (sphere.activeSelf == true)
            //{
            //    sphere.SetActive(false);
            //}
            //Debug.Log(sphere.gameObject.activeSelf);
        //}
        
        //if (Input.GetKey(KeyCode.F) && this.gameObject.activeSelf == false)
        //{
        //    this.gameObject.SetActive(true);
        //}
        
    }
   public void  actsphere()
    {
        sphere.SetActive(!sphere.activeSelf);
    }
    public void actcube()
    {
        cube.SetActive(!cube.activeSelf);
    }

}
