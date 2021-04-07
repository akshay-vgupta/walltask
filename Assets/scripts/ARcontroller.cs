using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    ARSession arSession;

    [SerializeField]
    GameObject wall, UIPanel;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reset(){
            arSession.Reset();
        if(UIPanel.activeInHierarchy==false){
            UIPanel.SetActive(true);
        }
       foreach (Transform child in wall.transform) {
     GameObject.Destroy(child.gameObject);
 }


            
    }
}
