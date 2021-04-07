using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class GroundPlane : MonoBehaviour
{
    // Start is called before the first frame update

    private ARRaycastManager aRRaycast;
    
        List<ARRaycastHit> hits;

        public Vector3 heightPose;
        private Vector2 touchPosition;
        [SerializeField]
        GameObject cube;

        GameObject ex;
    void Start()
    {
  
        hits = new List<ARRaycastHit>();
          Debug.Log(aRRaycast);
        aRRaycast = this.GetComponent<ARRaycastManager>();
          Debug.Log(aRRaycast);
    }
    
    // Update is called once per frame
    void Update()
    {
       

     }   
public void zz(){
     var center = Camera.current.ViewportToScreenPoint(new Vector3(0.5f,0.5f));
      
  

     if(aRRaycast.Raycast(center,hits,TrackableType.Planes)){
         
         heightPose = hits[0].pose.position;
         if(ex == null)
         {
}
    }

}}
