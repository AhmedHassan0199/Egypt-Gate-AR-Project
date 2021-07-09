using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
=======
using UnityEngine.UI;
>>>>>>> Stashed changes

public class Animation : MonoBehaviour
{
    public Animator anim;
    bool f=false,t=true;
    public int counter;
<<<<<<< Updated upstream
    public GameObject greet,greet2,kingName,KingRole,KingDesc,KingFam,bye;
    // Start is called before the first frame update
    void Start()
    {
=======
    public GameObject greet,greet2,kingName,KingRole,KingDesc,KingFam,bye,nextBTN,readyBTN,skipBTN,talkingbox,character;
    public GameObject KingDescTextMesh,KingNameTextMesh,KingRoleTextMesh,KingFamilyTextMesh;
    public GameObject KingDescExample,KingNameExample,KingRoleExample,KingFamilyExample;
    public GameObject NextButtonText,ReadyButtonText,SkipButtonText;
    float height,initialHeight;
    public  RectTransform rect,canvas;
    public string Name ="";
    public string Role = "";
    public string Family = "";
    public string Desc = "";
    public string Language;
    bool Ready=false;

    
    // Start is called before the first frame update
    void Start()
    {
        height=canvas.rect.height;
        initialHeight=rect.transform.position.y;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        counter=0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
=======
        nextBTN.SetActive(t);
        readyBTN.SetActive(f);
        counter=0;

        SetLanguageTexts();
        
        
    }
    void Update() {
        
        if(Ready)
        {
            
            KingDescTextMesh=PrepareTexts(KingDescTextMesh,Desc,KingDescExample);
            KingNameTextMesh=PrepareTexts(KingNameTextMesh,Name,KingNameExample);
            KingRoleTextMesh=PrepareTexts(KingRoleTextMesh,Role,KingRoleExample);
            KingFamilyTextMesh=PrepareTexts(KingFamilyTextMesh,Family,KingFamilyExample);
            
        }

    }
    GameObject WrapText(GameObject KingTextMesh)
    {
        
        TextMesh x=KingTextMesh.GetComponent<TextMesh>();
        string builder = "";
        float rowLimit = 5f; //find the sweet spot
        string[] parts = x.text.Split(' ');
        x.text="";
        for (int i = 0; i < parts.Length; i++)
        {
            x.text += parts[i] + " ";
            if (x.GetComponent<Renderer>().bounds.extents.x > rowLimit)
            {
                x.text = builder.TrimEnd() + System.Environment.NewLine + parts[i] + " ";
            }
            builder = x.text;
        }
        return KingTextMesh;
    }

    // Update is called once per frame
    public void onSkipClick()
    {
        rect.transform.position=new Vector3(rect.transform.position.x,initialHeight,rect.transform.position.z);
            
        greet.SetActive(f); 
        greet2.SetActive(f);  
        kingName.SetActive(f); 
        KingRole.SetActive(f);
        KingFam.SetActive(f);
        KingDesc.SetActive(f);
        bye.SetActive(t);
        nextBTN.SetActive(f);
        readyBTN.SetActive(t);
        skipBTN.SetActive(f);
        character.SetActive(f);
    }


>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            //rect.transform.Translate(0,-1800,1);
            rect.transform.position=new Vector3(rect.transform.position.x,height/2,rect.transform.position.z);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            rect.transform.position=new Vector3(rect.transform.position.x,initialHeight,rect.transform.position.z);
            
>>>>>>> Stashed changes
            KingRole.SetActive(f);
            KingFam.SetActive(t);
            anim.SetBool("Role_to_Family",t);
        }
        else if(counter==4)
        {
<<<<<<< Updated upstream
            //text position
=======
            
            rect.transform.position=new Vector3(rect.transform.position.x,height/2,rect.transform.position.z);
            
>>>>>>> Stashed changes
            KingFam.SetActive(f);
            KingDesc.SetActive(t);
            anim.SetBool("Family_to_Desc",t);
        }
        else if(counter==5)
        {
<<<<<<< Updated upstream
            KingDesc.SetActive(f);
            bye.SetActive(t);
           anim.SetBool("Desc_to_Final",t);
        }
        counter++;
    }
=======
            
            rect.transform.position=new Vector3(rect.transform.position.x,initialHeight,rect.transform.position.z);
            
            KingDesc.SetActive(f);
            bye.SetActive(t);
            nextBTN.SetActive(f);
            readyBTN.SetActive(t);
            skipBTN.SetActive(f);
            anim.SetBool("Desc_to_Final",t);
        }
        counter++;
    }
    GameObject PrepareTexts(GameObject textToPrepare,string textParam,GameObject ExampleToRemove)
    {
        ExampleToRemove.SetActive(f);
        textToPrepare.GetComponent<TextMesh>().text=textParam;
        textToPrepare=WrapText(textToPrepare);
        textToPrepare.SetActive(t);

        return textToPrepare;
    }
   public void onReadyClick()
   {
        character.SetActive(f);
        talkingbox.SetActive(f);

        KingDescTextMesh=PrepareTexts(KingDescTextMesh,Desc,KingDescExample);
        KingNameTextMesh=PrepareTexts(KingNameTextMesh,Name,KingNameExample);
        KingRoleTextMesh=PrepareTexts(KingRoleTextMesh,Role,KingRoleExample);
        KingFamilyTextMesh=PrepareTexts(KingFamilyTextMesh,Family,KingFamilyExample);

        Ready=true;

   }



    public void SetName(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Name = NewText;
        
        message.data = "SetName: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetRole(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Role= NewText;
        
        message.data = "SetRole: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetFamily(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Family = NewText;
        
        message.data = "SetFamily: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }
    public void SetDesc(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Desc  = NewText;
        
        message.data = "SetDesc: " + NewText;

        FlutterUnityPlugin.Messages.Send(message);
    }

    void SetLanguageTexts()
    {
        
        switch(Language)
        {

            case "English":
                greet.GetComponent<Text>().text="Hello My name is Kemet. Kemet was Egypt's name thousands of years ago.";
                greet2.GetComponent<Text>().text="Let me take you on a tour in our scene, So please follow me with your mobile.";
                kingName.GetComponent<Text>().text="Here you will find the name of the pharaoh that you scanned";
                KingRole.GetComponent<Text>().text="Here you will find the role of the pharaoh that you scanned";
                KingFam.GetComponent<Text>().text="Here you will find the dynasty of the pharaoh that you scanned";
                KingDesc.GetComponent<Text>().text="Here you will find a short description of the pharaoh that you scanned";
                bye.GetComponent<Text>().text="I will leave you here, Please place your camera facing the scanned statue and press ready";

                NextButtonText.GetComponent<Text>().text="Next";
                ReadyButtonText.GetComponent<Text>().text="Ready";
                SkipButtonText.GetComponent<Text>().text="Skip";

            break;

            case "Russian":
                greet.GetComponent<Text>().text="Привет Меня зовут кемет. Кемет был именем Египта тысячи лет назад";
                greet2.GetComponent<Text>().text="Позвольте мне взять вас в тур в нашей сцене, пожалуйста, следуйте за мной со своим мобильным телефоном.";
                kingName.GetComponent<Text>().text="Здесь вы найдете имя фараона, которого вы сканировали.";
                KingRole.GetComponent<Text>().text="Здесь вы найдете роль отсканированного вами фараона.";
                KingFam.GetComponent<Text>().text="Здесь вы найдете просканированную вами династию фараона.";
                KingDesc.GetComponent<Text>().text="Здесь вы найдете краткое описание отсканированного вами фараона.";
                bye.GetComponent<Text>().text="Я оставлю тебя здесь, Поэтому, пожалуйста, поместите камеру лицом к отсканированной статуе и готово к печати.";

                NextButtonText.GetComponent<Text>().text="Следующий";
                ReadyButtonText.GetComponent<Text>().text="Готовый";
                SkipButtonText.GetComponent<Text>().text="Пропускать";

            break;

            case "French":
                greet.GetComponent<Text>().text="Bonjour Je m'appelle Kemet. Kemet était le nom de l'Egypte il y a des milliers d'années";
                greet2.GetComponent<Text>().text="Laisse moi t'emmener faire un tour dans notre scène, alors s'il vous plaît suivez-moi avec votre mobile.";
                kingName.GetComponent<Text>().text="Vous trouverez ici le nom du pharaon que vous avez scanné";
                KingRole.GetComponent<Text>().text="Vous trouverez ici le rôle du pharaon que vous avez scanné.";
                KingFam.GetComponent<Text>().text="Vous trouverez ici la dynastie du pharaon que vous avez scannée";
                KingDesc.GetComponent<Text>().text="Vous trouverez ici une brève description du pharaon que vous avez scanné";
                bye.GetComponent<Text>().text="je te laisse ici, Veuillez donc placer votre appareil photo face à la statue numérisée et prêt à être utilisé";

                NextButtonText.GetComponent<Text>().text="Suivant";
                ReadyButtonText.GetComponent<Text>().text="Prêt";
                SkipButtonText.GetComponent<Text>().text="Sauter";
            break;
            
            case "Spanish":
                greet.GetComponent<Text>().text=" Hola Mi nombre es kemet. Kemet era el nombre de Egipto hace miles de años.";
                greet2.GetComponent<Text>().text="Déjame llevarte de gira en nuestra escena, así que sígueme con tu móvil.";
                kingName.GetComponent<Text>().text="Aquí encontrará el nombre del faraón que escaneó";
                KingRole.GetComponent<Text>().text="Aquí encontrará el papel del faraón que escaneó.";
                KingFam.GetComponent<Text>().text="Aquí encontrarás la dinastía del faraón que escaneaste";
                KingDesc.GetComponent<Text>().text="Aquí encontrará una breve descripción del faraón que escaneó";
                bye.GetComponent<Text>().text="Te dejo aqui Así que coloque su cámara frente a la estatua escaneada y listo para presionar";
                
                NextButtonText.GetComponent<Text>().text="Próximo";
                ReadyButtonText.GetComponent<Text>().text="Listo";
                SkipButtonText.GetComponent<Text>().text="Saltar";
            break;

           case "German":
                greet.GetComponent<Text>().text=" Hallo Mein Name ist. Kemet Kemet war Ägyptens Name vor Tausenden von Jahren";
                greet2.GetComponent<Text>().text="Ich nehme dich mit auf eine Tour in unserer Szene, also folge mir bitte mit deinem Handy.";
                kingName.GetComponent<Text>().text="Hier finden Sie den Namen des Pharaos, den Sie gescannt haben";
                KingRole.GetComponent<Text>().text="Hier finden Sie die von Ihnen gescannte Rolle des Pharaos.";
                KingFam.GetComponent<Text>().text="Hier finden Sie die Dynastie des Pharaos, die Sie gescannt haben";
                KingDesc.GetComponent<Text>().text="Hier finden Sie eine kurze Beschreibung des Pharaos, den Sie gescannt haben";
                bye.GetComponent<Text>().text="Ich werde dich hier lassen, Bitte richten Sie Ihre Kamera also auf die gescannte Statue und machen Sie sie druckbereit";

                NextButtonText.GetComponent<Text>().text="Nächster";
                ReadyButtonText.GetComponent<Text>().text="Bereit";
                SkipButtonText.GetComponent<Text>().text="Überspringen";
            break; 
            
            case "Arabic":
                greet.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("مرحبا اسمي كيميت. كيميت كان اسم مصر منذ آلاف السنين");
                greet2.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix(" اسمح لي أن أخذك في جولة في تطبيقنا ، لذا من فضلك اتبعني بهاتفك");
                kingName.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("ستجد هنا اسم الفرعون الذي قمت بمسحه ضوئيًا");
                KingRole.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("هنا سوف تجد وظيفة الفرعون الذي قمت بمسحه ضوئيًا");
                KingFam.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("ستجد هنا سلالة الفرعون الذي قمت بمسحه ضوئيًا");
                KingDesc.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("ستجد هنا وصفًا موجزًا ​​للفرعون الذي قمت بمسحه ضوئيًا");
                bye.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("سأتركك هنا. لذا يرجى وضع الكاميرا في مواجهة التمثال و اضغط علي مستعد");

                NextButtonText.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("التالي");
                ReadyButtonText.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("مستعد");
                SkipButtonText.GetComponent<Text>().text=ArabicSupport.ArabicFixer.Fix("تخطي");
                

                Name=ArabicSupport.ArabicFixer.Fix(Name,false,false);
                Desc=ArabicSupport.ArabicFixer.Fix(Desc,false,false);
                Role=ArabicSupport.ArabicFixer.Fix(Role,false,false);
                Family=ArabicSupport.ArabicFixer.Fix(Family,false,false);
                
                
            break;
            default:
            break;
        }

    }
    

    public void SetLanguage(string text)
    {
        FlutterUnityPlugin.Message message = FlutterUnityPlugin.Messages.Receive(text);

        string NewText = message.data.ToString();

        Language = NewText;
        
        SetLanguageTexts();

        message.data = "SetLanguage: " + NewText;
        
        FlutterUnityPlugin.Messages.Send(message);
    }

>>>>>>> Stashed changes
}
