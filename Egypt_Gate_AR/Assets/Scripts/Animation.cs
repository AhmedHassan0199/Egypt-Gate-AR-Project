using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    public Animator anim;
    bool f=false,t=true;
    public int counter;
    public GameObject greet,greet2,kingName,KingRole,KingDesc,KingFam,bye,nextBTN,readyBTN,talkingbox,character;
    float height,initialHeight;
    public  RectTransform rect,canvas;
    public string Name;
    public string Role;
    public string Family;
    public string Desc;
    string Language="Russian";

    
    // Start is called before the first frame update
    void Start()
    {
        height=canvas.rect.height;
        initialHeight=rect.transform.position.y;
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
        nextBTN.SetActive(t);
        readyBTN.SetActive(f);
        counter=0;

    }

    // Update is called once per frame

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
            //rect.transform.Translate(0,-1800,1);
            Debug.Log("CANVAS : "+canvas.rect.height);
            
            Debug.Log("BEFORE : "+rect.transform.position.y);
            rect.transform.position=new Vector3(rect.transform.position.x,height/2,rect.transform.position.z);
            Debug.Log("AFTER : "+rect.transform.position.y);
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
            rect.transform.Translate(0,1800,0);
            
            Debug.Log("BEFORE : "+rect.transform.position.y);
            rect.transform.position=new Vector3(rect.transform.position.x,initialHeight,rect.transform.position.z);
            Debug.Log("AFTER : "+rect.transform.position.y);
            
            KingRole.SetActive(f);
            KingFam.SetActive(t);
            anim.SetBool("Role_to_Family",t);
        }
        else if(counter==4)
        {
            //text position
            rect.transform.Translate(0,-1800,0);

            Debug.Log("BEFORE : "+rect.transform.position.y);
            rect.transform.position=new Vector3(rect.transform.position.x,height/2,rect.transform.position.z);
            Debug.Log("AFTER : "+rect.transform.position.y);

            KingFam.SetActive(f);
            KingDesc.SetActive(t);
            anim.SetBool("Family_to_Desc",t);
        }
        else if(counter==5)
        {
            rect.transform.Translate(0,1800,1);

            Debug.Log("BEFORE : "+rect.transform.position.y);
            rect.transform.position=new Vector3(rect.transform.position.x,initialHeight,rect.transform.position.z);
            Debug.Log("AFTER : "+rect.transform.position.y);
            

            KingDesc.SetActive(f);
            bye.SetActive(t);
            nextBTN.SetActive(f);
            readyBTN.SetActive(t);
           anim.SetBool("Desc_to_Final",t);
        }
        counter++;
    }
   public void onReadyClick()
   {
       character.SetActive(f);
       talkingbox.SetActive(f);
   }





    public void SetPharaohName(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Name = NewText;
        
        message.data = "SetName: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetPharaohRole(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Role= NewText;
        
        message.data = "SetRole: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetPharaohFamily(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Family = NewText;
        
        message.data = "SetFamily: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetPharaohDesc(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Desc  = NewText;
        
        message.data = "SetDesc: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }

    
    public void SetLanguage(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Language = NewText;
        
        message.data = "SetLanguage: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);

        switch(Language)
        {
            case "Russian":
                greet.GetComponent<Text>().text="???????????? ???????? ?????????? ?????????? ?????????? ?????? ???????????? ???????????? ???????????? ?????? ??????????";
                greet2.GetComponent<Text>().text="?????????????????? ?????? ?????????? ?????? ?? ?????? ?? ?????????? ??????????, ????????????????????, ???????????????? ???? ???????? ???? ?????????? ?????????????????? ??????????????????.";
                kingName.GetComponent<Text>().text="?????????? ???? ?????????????? ?????? ??????????????, ???????????????? ???? ??????????????????????.";
                KingRole.GetComponent<Text>().text="?????????? ???? ?????????????? ???????? ???????????????????????????????? ???????? ??????????????.";
                KingFam.GetComponent<Text>().text="?????????? ???? ?????????????? ???????????????????????????????? ???????? ???????????????? ??????????????.";
                KingDesc.GetComponent<Text>().text="?????????? ???? ?????????????? ?????????????? ???????????????? ???????????????????????????????? ???????? ??????????????.";
                bye.GetComponent<Text>().text="?? ?????????????? ???????? ??????????, ??????????????, ????????????????????, ?????????????????? ???????????? ?????????? ?? ?????????????????????????????? ???????????? ?? ???????????? ?? ????????????.";
            break;

            case "French":
             greet.GetComponent<Text>().text="Bonjour Je m'appelle Kemet. Kemet ??tait le nom de l'Egypte il y a des milliers d'ann??es";
                greet2.GetComponent<Text>().text="Laisse moi t'emmener faire un tour dans notre sc??ne, alors s'il vous pla??t suivez-moi avec votre mobile.";
                kingName.GetComponent<Text>().text="Vous trouverez ici le nom du pharaon que vous avez scann??";
                KingRole.GetComponent<Text>().text="Vous trouverez ici le r??le du pharaon que vous avez scann??.";
                KingFam.GetComponent<Text>().text="Vous trouverez ici la dynastie du pharaon que vous avez scann??e";
                KingDesc.GetComponent<Text>().text="Vous trouverez ici une br??ve description du pharaon que vous avez scann??";
                bye.GetComponent<Text>().text="je te laisse ici, Veuillez donc placer votre appareil photo face ?? la statue num??ris??e et pr??t ?? ??tre utilis??";
            break;
            
            case "Spanish":
             greet.GetComponent<Text>().text=" Hola Mi nombre es kemet Kemet era el nombre de Egipto hace miles de a??os.";
                greet2.GetComponent<Text>().text="D??jame llevarte de gira en nuestra escena, as?? que s??gueme con tu m??vil.";
                kingName.GetComponent<Text>().text="Aqu?? encontrar?? el nombre del fara??n que escane??";
                KingRole.GetComponent<Text>().text="Aqu?? encontrar?? el papel del fara??n que escane??.";
                KingFam.GetComponent<Text>().text="Aqu?? encontrar??s la dinast??a del fara??n que escaneaste";
                KingDesc.GetComponent<Text>().text="Aqu?? encontrar?? una breve descripci??n del fara??n que escane??";
                bye.GetComponent<Text>().text="Te dejo aqui As?? que coloque su c??mara frente a la estatua escaneada y listo para presionar";
            break;

           case "German":
             greet.GetComponent<Text>().text=" Hallo Mein Name ist Kemet Kemet war ??gyptens Name vor Tausenden von Jahren";
                greet2.GetComponent<Text>().text="Ich nehme dich mit auf eine Tour in unserer Szene, also folge mir bitte mit deinem Handy.";
                kingName.GetComponent<Text>().text="Hier finden Sie den Namen des Pharaos, den Sie gescannt haben";
                KingRole.GetComponent<Text>().text="Hier finden Sie die von Ihnen gescannte Rolle des Pharaos.";
                KingFam.GetComponent<Text>().text="Hier finden Sie die Dynastie des Pharaos, die Sie gescannt haben";
                KingDesc.GetComponent<Text>().text="Hier finden Sie eine kurze Beschreibung des Pharaos, den Sie gescannt haben";
                bye.GetComponent<Text>().text="Ich werde dich hier lassen, Bitte richten Sie Ihre Kamera also auf die gescannte Statue und machen Sie sie druckbereit";
            break; 
            
            default:
            break;
        }

    }

}
