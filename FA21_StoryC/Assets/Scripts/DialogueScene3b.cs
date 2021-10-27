using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    public Text Char2Chad;
    public Text Char2ChadSpeech; 
    //public Text Char3Gwen;
    //public Text Char3GwenSpeech;
    public Text Char4Gregory;
    public Text Char4GregorySpeech;
    //public Text Char5PJ;
    //public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    public GameObject Image_Chad;
    //public GameObject Image_Gwen
    public GameObject Image_Gregory;
    public GameObject Image_GregoryScared;
    //public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Button_SceneChange1;
    //public GameObject Button_SceneChange2;
    public GameObject Button_Next;
    public GameHandler gameHandler;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Image_Chad.SetActive(false);
        //Image_Gwen.SetActive(true);
        Image_Gregory.SetActive(false);
        Image_GregoryScared.SetActive(false);
        //Image_PJ.SetActive(true);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_SceneChange1.SetActive(false);
        //Button_SceneChange2.SetActive(false);
        Button_Next.SetActive(true);
    }

    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            Dialogue.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter a dark room- illuminated by only an eerie green light.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The unidentifiable goo glistens down the walls and the room is full of alchemy equipment and whirring machines.";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Sparks crack throughout the room, and a rainbow of colorful liquids weave in and out of tubes.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "It looks like a mad scientits lab, splashes of liquid are strewn around hazardly as you all walk in.";
        }
        else if (primeInt == 6)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Is that someone strapped to a table over there?";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Who is that behind her? Some sort of mad scientist?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "I guess, I can't really tell what he is looking at...";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Guys...she looks a little too scared to be an actress...is she okay?";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            //nextButton.SetActive(false);
            // allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 10)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "I don't know how I feel about this...maybe we should move on.";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Shhhh! Dude, let's just see what happens.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 12)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "I don't know man...she looks a little too scared...";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            Button_Next.SetActive(false);
            allowSpace = false;
            //Button_SceneChange1.SetActive(true);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Are those...tools?";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 101)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "What is he muttering to himself?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 102)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The woman strapped to the table begins to struggle harder when she notices you watching.";

        }
        else if (primeInt == 103)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Hearing the struggle, the scientist whips around to face you, brandishing a wickedly sharp bonesaw.";

        }
        else if (primeInt == 104)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A menacing whirring sound fills the air as he flicked it on and started advancing towards you guys as he yells-";

        }
        else if (primeInt == 105)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "YOU AREN'T SUPPOSED TO BE IN HERE!!!!!";

        }
        else if (primeInt == 106)
        {
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "GUYS, LET'S GET OUTTA HERE!!!!";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 107)
        {
            Image_GregoryScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You spin on your heel and dash after Chad towards the next room, dragging Gregory behind you.";

        }
        else if (primeInt == 108)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The scientist's screams are arburptly cut off as the door slams shut.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }
      

        else if (primeInt == 200)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Yeah, she's just a great actor, Greg. No need to get so scared.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {
            Image_Chad.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "I'm not so sure...";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {
            Image_Gregory.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Let's just move on, guys.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 203)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Glancing back, you watch the scientist slice into his victim. A chill passes over you as you watch.";
        }
        else if (primeInt == 204)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A spurt of blood is seen and followed by anguished screams.";
        }
        else if (primeInt == 205)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            //Char5PJ.text = "";
            //Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You quickly turn, nauseated by the sight, and move on.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }


    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        //Char5PJ.text = "";
        //Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "You stay, curious to see how the scene unfolds.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1You.text = "You";
        Char1YouSpeech.text = "I don't know, this seems too theatrical.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
        //Char5PJ.text = "";
        //Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4b");
    }

}