using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject Panel;
    public List<GameObject> AllArTexts;
    public List<Transform> AllTextTransforms;
    public Transform Camera;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 CameraPos=Camera.position;
        AllTextTransforms[0].position=new Vector3(CameraPos.x-0.6f,CameraPos.y+0.4f,CameraPos.z+13);
        AllTextTransforms[1].position=new Vector3(CameraPos.x+7.76f,CameraPos.y-3.75f,CameraPos.z+2.51f);
        AllTextTransforms[2].position=new Vector3(CameraPos.x-4.87f,CameraPos.y-3.38f,CameraPos.z+12.7f);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        Panel.SetActive(false);
        for(int i=0;i<AllArTexts.Count;i++)
        {
            AllArTexts[i].transform.position=AllTextTransforms[i].position;
            AllArTexts[i].SetActive(true);
        }
    }
}
