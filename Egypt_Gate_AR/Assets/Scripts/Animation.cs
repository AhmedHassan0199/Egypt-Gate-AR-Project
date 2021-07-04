using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator anim;
    bool f=false,t=true;
    public int counter;
    public GameObject greet,greet2,kingName,KingRole,KingDesc,KingFam,bye;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("Hello_to_Steady",f);
        anim.SetBool("Steady_to_King",f);
        anim.SetBool("King_to_Role",f);
        anim.SetBool("Role_to_Family",f);
        anim.SetBool("Family_to_Desc",f);
        anim.SetBool("Desc_to_Final",f);
        greet.SetActive(t);
        greet2.SetActive(f);
        kingName.SetActive(f);
        KingRole.SetActive(f);
        KingDesc.SetActive(f);
        KingFam.SetActive(f);
        bye.SetActive(f);
        counter=0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void onBtnClick()
    {
        if(counter==0)
        {
            greet.SetActive(f);
            greet2.SetActive(t);
            anim.SetBool("Hello_to_Steady",t);
        }
        else if(counter==1)
        {
            //text position
            greet2.SetActive(f);
            kingName.SetActive(t);
            anim.SetBool("Steady_to_King",t);
        }
        else if(counter==2)
        {
            //text position
            kingName.SetActive(f);
            KingRole.SetActive(t);
           anim.SetBool("King_to_Role",t);
        }
        else if(counter==3)
        {
            KingRole.SetActive(f);
            KingFam.SetActive(t);
            anim.SetBool("Role_to_Family",t);
        }
        else if(counter==4)
        {
            //text position
            KingFam.SetActive(f);
            KingDesc.SetActive(t);
            anim.SetBool("Family_to_Desc",t);
        }
        else if(counter==5)
        {
            KingDesc.SetActive(f);
            bye.SetActive(t);
           anim.SetBool("Desc_to_Final",t);
        }
        counter++;
    }
}
