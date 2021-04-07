using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.IO;

public class BricksSpawner : MonoBehaviour
{
    // Start is called before the first frame update
int max_height = 10;
int max_width = 10;

[SerializeField]
GameObject cube,wall,UIpanel,arPlane;

[SerializeField]
 Material cubeM;

private ARSessionOrigin aRSessionOrigin;
Vector3 height;

private Pose planeY;
    void Start()
    {
       
        aRSessionOrigin = FindObjectOfType<ARSessionOrigin>();
       
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(""+arPlane.transform.localPosition);
    }
    public void getSize(Slider slider){
        Debug.Log(""+slider.value);
        cube.transform.localScale = new Vector3(0.5f + (0.05f *slider.value),0.5f,0.5f); 
        //0.55,0.6,0.65,0.7,0.75
        Debug.Log("cube"+cube.transform.localScale);
    }
    public void setBrick(){
        UIpanel.SetActive(false);
        spawn();
    }
    void spawn()
    {
        Debug.Log("here");
        aRSessionOrigin.GetComponent<GroundPlane>().zz();
         height = aRSessionOrigin.GetComponent<GroundPlane>().heightPose;
          wall.transform.position = new Vector3(0,0,15f);
        Debug.Log(""+height);
        
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<5;j++)
            {
         Instantiate(cube,new Vector3((j*cube.transform.localScale.x),(i*0.5f),0f),Quaternion.identity).transform.SetParent(wall.transform);
        
        }
        }
          wall.transform.position = new Vector3(height.x,height.y/2,15f);
    //   wall.transform.position -= new Vector3(0,height.y,0);
        
        Debug.Log(""+wall.transform.position);
        Debug.Log(""+wall.transform.localPosition);    
        toJS();
    }
    void toJS(){
        Debug.Log(""+JsonUtility.ToJson(this));

       
       File.WriteAllText(Application.persistentDataPath + "/jsonwall.txt",JsonUtility.ToJson(this));
    }
    public void setRed(){
       cubeM.color = Color.red;
    }
     public void setBlue(){
cubeM.color = Color.blue;
    }
     public void setGreen(){
cubeM.color = Color.green;
    }
}
