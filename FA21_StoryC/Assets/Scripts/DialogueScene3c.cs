using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3c : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    //public Text Char2Chad;
    //public Text Char2ChadSpeech;
    public Text Char3Gwen;
    public Text Char3GwenSpeech;
    //public Text Char4Gregory;
    //public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    //public GameObject Image_Chad;
    public GameObject Image_Gwen;
    //public GameObject Image_Gregory;
    public GameObject Image_PJ;
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
        //Image_Chad.SetActive(false);
        Image_Gwen.SetActive(true);
        //Image_Gregory.SetActive(false);
        Image_PJ.SetActive(false);
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
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter a bedroom. There's a bed up against the left wall with a nightstand by it.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Deep claw marks similar to the ones on the door adorn the walls, paired with streaks of blood.";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The floorboards are worn and faded, and the room is eerily still...Nothing can be heard aside from your breathing.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1You.text = "Jeez, someone must really not like their room.";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 6)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "I wish my bedroom looked like this...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Image_Gwen.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Gwen.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "I guess, I can't really tell what he is looking at...";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
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
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
        {
           
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 12)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "I don't know man...she looks a little too scared...";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
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
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 101)
        {
            
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 102)
        {
            
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The woman strapped to the table begins to struggle harder when she notices you watching.";

        }
        else if (primeInt == 103)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Hearing the struggle, the scientist whips around to face you, brandishing a wickedly sharp bonesaw.";

        }
        else if (primeInt == 104)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A menacing whirring sound fills the air as he flicked it on and started advancing towards you guys as he yells-";

        }
        else if (primeInt == 105)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "YOU AREN'T SUPPOSED TO BE IN HERE!!!!!";

        }
        else if (primeInt == 106)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 107)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You spin on your heel and dash after Chad towards the next room, dragging Gregory behind you.";

        }
        else if (primeInt == 108)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The scientist's screams are arburptly cut off as the door slams shut behind you.";
            //Button_Next.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }


        else if (primeInt == 200)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {

            Char1You.text = "You";
            Char1YouSpeech.text = "Let's just move on, guys.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 203)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Glancing back, you watch the scientist slice into his victim. A chill passes over you as you watch.";
        }
        else if (primeInt == 204)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A spurt of blood is seen and followed by anguished screams. With a shudder, you step into the next room.";
            //Button_Next.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }


    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1You.text = "";
        Char1YouSpeech.text = "";
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
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
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
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