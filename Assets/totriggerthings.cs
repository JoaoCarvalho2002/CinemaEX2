using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class totriggerthings : MonoBehaviour
{
    [SerializeField]private CinemachineVirtualCamera vcam1;
    [SerializeField]private CinemachineVirtualCamera vcam2;
    private GameObject cam1 ;
    private GameObject cam2 ;
    // Start is called before the first frame update
    void Start()
    {
        cam1 = GameObject.Find("Virtual Camera1");
        cam2 = GameObject.Find("virtualcamtake2");
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision){
        if(collision.gameObject.name =="default1")
        {
            gameObject.SetActive(false);
            cam1.SetActive(false);

        }

    }
}
