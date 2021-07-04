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
                greet.GetComponent<Text>().text="Привет Меня зовут кемет Кемет был именем Египта тысячи лет назад";
                greet2.GetComponent<Text>().text="Позвольте мне взять вас в тур в нашей сцене, пожалуйста, следуйте за мной со своим мобильным телефоном.";
                kingName.GetComponent<Text>().text="Здесь вы найдете имя фараона, которого вы сканировали.";
                KingRole.GetComponent<Text>().text="Здесь вы найдете роль отсканированного вами фараона.";
                KingFam.GetComponent<Text>().text="Здесь вы найдете просканированную вами династию фараона.";
                KingDesc.GetComponent<Text>().text="Здесь вы найдете краткое описание отсканированного вами фараона.";
                bye.GetComponent<Text>().text="Я оставлю тебя здесь, Поэтому, пожалуйста, поместите камеру лицом к отсканированной статуе и готово к печати.";
            break;

            case "French":
             greet.GetComponent<Text>().text="Bonjour Je m'appelle Kemet. Kemet était le nom de l'Egypte il y a des milliers d'années";
                greet2.GetComponent<Text>().text="Laisse moi t'emmener faire un tour dans notre scène, alors s'il vous plaît suivez-moi avec votre mobile.";
                kingName.GetComponent<Text>().text="Vous trouverez ici le nom du pharaon que vous avez scanné";
                KingRole.GetComponent<Text>().text="Vous trouverez ici le rôle du pharaon que vous avez scanné.";
                KingFam.GetComponent<Text>().text="Vous trouverez ici la dynastie du pharaon que vous avez scannée";
                KingDesc.GetComponent<Text>().text="Vous trouverez ici une brève description du pharaon que vous avez scanné";
                bye.GetComponent<Text>().text="je te laisse ici, Veuillez donc placer votre appareil photo face à la statue numérisée et prêt à être utilisé";
            break;
            
            case "Spanish":
             greet.GetComponent<Text>().text=" Hola Mi nombre es kemet Kemet era el nombre de Egipto hace miles de años.";
                greet2.GetComponent<Text>().text="Déjame llevarte de gira en nuestra escena, así que sígueme con tu móvil.";
                kingName.GetComponent<Text>().text="Aquí encontrará el nombre del faraón que escaneó";
                KingRole.GetComponent<Text>().text="Aquí encontrará el papel del faraón que escaneó.";
                KingFam.GetComponent<Text>().text="Aquí encontrarás la dinastía del faraón que escaneaste";
                KingDesc.GetComponent<Text>().text="Aquí encontrará una breve descripción del faraón que escaneó";
                bye.GetComponent<Text>().text="Te dejo aqui Así que coloque su cámara frente a la estatua escaneada y listo para presionar";
            break;

           case "German":
             greet.GetComponent<Text>().text=" Hallo Mein Name ist Kemet Kemet war Ägyptens Name vor Tausenden von Jahren";
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
