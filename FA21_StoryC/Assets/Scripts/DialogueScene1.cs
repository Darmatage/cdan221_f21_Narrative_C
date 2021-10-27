using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    public Text Char2Chad;
    public Text Char2ChadSpeech;
    public Text Char3Gwen;
    public Text Char3GwenSpeech;
    public Text Char4Gregory;
    public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    public GameObject Image_Chad;
    public GameObject Image_Gwen;
    public GameObject Image_Gregory;
    public GameObject Image_PJ;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Button_SceneChange1;
    //public GameObject Button_SceneChange2;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(false);
        Image_Gregory.SetActive(false);
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
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The start of the semester has been an absolute whirlwind.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You're entering your junior year at Sunnyvale Community College";
        }
        else if (primeInt == 4)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "In spite of flying under the social radar for years you found yourself a group of friends.";
        }
        else if (primeInt == 5)
        {
            Char1You.text = "";
            Char1YouSpeech.text = ""; 
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A group formed from a statistics study group, you are all very different.";
        }
        else if (primeInt == 6)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Despite this you all became close, and decided to come to a travelling haunted house.";
        }
        else if (primeInt == 7)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Finding a travelling one has set up in Sunnyvale, you all decided to check it out.";
        }
        else if (primeInt == 8)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Jeez, look at the size of this place. I wonder how big the inside is.";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Guys, I'm literally so excited. This is going to be so sick.";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 10)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "I hope you all don't get scared. If anyone pees themselves, they're walking home!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 11)
        {
            Image_Chad.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Oh please- If anyone's going to pee themselves or cry it'll be you.";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 12)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "If you need a hand to hold, you can just grab mine~";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 13)
        {
            Image_Gwen.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Guys- It might be scary, but you have to remember it's all effects.";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 14)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Fake effects and underpaid actors. It's no big deal...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 15)
        {
            Image_Gregory.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "I like the darkness surrounding this place...It makes me feel at home.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            //nextButton.SetActive(false);
            // allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 16)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "And who knows, I heard places like this will hire real criminals.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 17)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "No way! That means it'll be extra scary, I can't wait!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 18)
        {
            Image_Chad.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "No, that's not cool! What if one of them tries to kill us?!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 19)
        {
            Image_Gregory.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "PJ";
            Char6Narrator.text = "What do you think, it's definitely real, right?";
            Char6Narration.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            //Button_SceneChange1.SetActive(true);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Image_PJ.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "See! I told you it's not real, that's way to dangerous!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

            nextButton.SetActive(true);
            allowSpace = true;
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 101)
        {
            Image_PJ.SetActive(true);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "*scoffs* Whatever.";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 102)
        {
            Image_PJ.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "God that's so twisted...Like are you okay in the head?";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 103)
        {

            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "If you have anything you want to talk about, just let me know and we can grab coffee and vent.";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 104)
        {
            Image_PJ.SetActive(true);
            Image_Gwen.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Are any of us really 'okay in the head'?";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 105)
        {
            Image_PJ.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Yeah, actually. Like, I'm literally fine.";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 106)
        {
            Image_PJ.SetActive(true);
            Image_Gwen.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Oh well lucky you, I guess.";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 107)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "*Jeez maybe we should just go inside before this takes a genuinely scary turn...";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 108)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Alright, are we ready to head in, guys?";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 109)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "And with that, the group headed inside, ready to face the terrors that awaited them...";
            nextButton.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Image_PJ.SetActive(true);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Exactly, why would I lie about something like this...you know how into horror I am.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            nextButton.SetActive(true);
            allowSpace = true;
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 201)
        {
            Image_PJ.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "You both are definitely lying just to scare us!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 201)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "With all the saftey protocols there is no WAY that could happen!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {
            Image_Chad.SetActive(true);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Hell yeah, bro! Let's do this!!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 203)
        {
            Image_Chad.SetActive(false);
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Let's just get this over with...I have a test I need to study for tonight...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 204)
        {
            Image_Chad.SetActive(false);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "And with that, the group headed inside, ready to face the terrors that awaited them...";
            nextButton.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

    }
        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct()
    {
        Char1You.text = "You";
        Char1YouSpeech.text = "I mean...";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
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
        Char1YouSpeech.text = "100% It's Real";
        Char2Chad.text = "";
        Char2ChadSpeech.text = "";
        Char3Gwen.text = "";
        Char3GwenSpeech.text = "";
        Char4Gregory.text = "";
        Char4GregorySpeech.text = "";
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
        SceneManager.LoadScene("Scene2");
    }
    
}