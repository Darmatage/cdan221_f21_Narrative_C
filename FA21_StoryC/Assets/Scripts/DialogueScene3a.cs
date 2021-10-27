using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    public Text Char2Chad;
    public Text Char2ChadSpeech;
    //public Text Char3Gwen;
    //public Text Char3GwenSpeech;
    //public Text Char4Gregory;
    //public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    public GameObject Image_Chad;
    //public GameObject Image_Gwen;
    //public GameObject Image_Gregory;
    public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Button_SceneChange1;
    //public GameObject Button_SceneChange2;
    public GameObject nextButton;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Image_Chad.SetActive(false);
        //Image_Gwen.SetActive(false);
        //Image_Gregory.SetActive(false);
        Image_PJ.SetActive(false);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_SceneChange1.SetActive(false);
        //Button_SceneChange2.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
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
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter a stark white room-the only color visible aside from the linoleum floors are the walls streaked in blood.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Mangled piles of discarded bones and cartilage are placed throughout the room.";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A slightly metallic scent fills the air as you see mysterious slabs of meat strewn from the cielings.";
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
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A singlular wall holds a large glass window looking into a neighboring room with wickedly sharp tools.";
        }
        else if (primeInt == 6)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Woah! Check out the special effects in this place. It's so realistic!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Image_Chad.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "This is so sick...it resonates with me on such a deep level. Like aren't we all just chunks of meat? So poetic...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "???";
            Char6Narration.text = "HELP ME!!";
        }
        else if (primeInt == 9)
        {
            Image_Chad.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Did you say something?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
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
            Image_Chad.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Nah, man. I'm just taking it all in.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "???";
            Char6Narration.text = "OVER HERE!!";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 12)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You notice a visibly distraught and bloodied woman banging on the glass window.";
        }
        else if (primeInt == 13)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "???";
            Char6Narration.text = "PLEASE HELP ME I'M BEGGING YOU!!";
            nextButton.SetActive(false);
            allowSpace = false;
            //Button_SceneChange1.SetActive(true);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Dude...she's like, the living representation of my internal monologue...";
            Char6Narrator.text = "";
            Char6Narration.text = "";

            nextButton.SetActive(true);
            allowSpace = true;
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 101)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Bro...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
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
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You approach the window, PJ and Chad following closely behind.";

        }
        else if (primeInt == 103)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "???";
            Char6Narration.text = "PLEASE GET ME OUT OF HERE!!";

        }
        else if (primeInt == 104)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Chad begins to help you search for the entrance into the next room, her cries echoing in your ear.";

        }
        else if (primeInt == 105)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A pang of fear shoots through you as you realize her acting was a bit too convincing for your liking.";

        }
        else if (primeInt == 106)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "???";
            Char6Narration.text = "I'M BEGGING YOU- PLEASE! AAAAAAGHHHHH!!!";
        }
        else if (primeInt == 107)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "In your search for a way into the room, you failed to notice a shadowy figure sneaking up behind her.";

        }
        else if (primeInt == 108)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Her pleas for help are cut short by a sharp scream as she's dragged deeper into the room.";

        }
        else if (primeInt == 109)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Woah...That was so poetic...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }
        else if (primeInt == 110)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "I don't know man, she seemed almost too scared...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 111)
        {
            Image_PJ.SetActive(true);
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "It's kinda lame that that was the only thing set to happen in this room...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 112)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Yeah. Dude...like, what was that about?";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 113)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "That was just some bogus scene...Let's just move on.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 114)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "In spite of feeling uneasy, you all carry on to the next room.";
            nextButton.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }


        else if (primeInt == 200)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Yeah, what a disapopointment...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Hopefully the next room will have something worthwhile in it...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 201)
        {
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "And on that note, you guys continue onto the next room that awaits you...";
            nextButton.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1You.text = "You";
        Char1YouSpeech.text = "She's kinda a good actor. Let's go check out whats happening.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;

    }
    public void Choice1bFunct()
    {
        Char1You.text = "You";
        Char1YouSpeech.text = "This is so cliche...a butcher's shop? They could've done something much cooler. Let's move on.";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "";
        Char6Narration.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;

    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4a");
    }

}
