using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1You;
    public Text Char1YouSpeech;
    //public Text Char2Chad;
    //public Text Char2ChadSpeech;
    public Text Char3Gwen;
    public Text Char3GwenSpeech;
    public Text Char4Gregory;
    public Text Char4GregorySpeech;
    public Text Char5PJ;
    public Text Char5PJSpeech;
    public Text Char6Narrator;
    public Text Char6Narration;
    public GameObject Dialogue;
    //public GameObject Image_Chad;
    //public GameObject Image_ChadScared;
    public GameObject Image_Gwen;
    public GameObject Image_GwenScared;
    public GameObject Image_Gregory;
    public GameObject Image_GregoryScared;
    public GameObject Image_PJ;
    public GameObject Image_PJScared;
    public GameObject Image_BG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    //public GameObject Choice1c;
    public GameObject Button_SceneChange1;
    public GameObject Button_SceneChange2;
    //public GameObject Button_SceneChange3;
    public GameObject Button_Next;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;



    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        //Image_Chad.SetActive(false);
        //Image_ChadScared.SetActive(false);
        Image_Gwen.SetActive(false);
        Image_GwenScared.SetActive(false);
        Image_Gregory.SetActive(false);
        Image_GregoryScared.SetActive(false);
        Image_PJ.SetActive(false);
        Image_PJScared.SetActive(false);
        Image_BG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        //Choice1c.SetActive(false);
        Button_SceneChange1.SetActive(false);
        Button_SceneChange2.SetActive(false);
        //Button_SceneChange3.SetActive(false);
        Button_Next.SetActive(true);
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
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Turning around you see a dark room. At the end a bright exit sign can be seen.";
        }
        else if (primeInt == 3)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The only light that shines is from the sign. Yet, you can hear the footsteps start up behind you.";
        }
        else if (primeInt == 4)
        {
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "GUYS WHAT JUST HAPPENED???";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Image_GwenScared.SetActive(true);
            Image_GregoryScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "OMG, OMG, OMG, CHAD IS STILL IN THERE!";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 6)
        {
            Image_PJScared.SetActive(true);
            Image_GwenScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "This is messed up...";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 7)
        {
            Image_PJScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "GUYS WE DON'T HAVE TIME TO WORRY ABOUT CHAD, WE HAVE TO GET OUT OF HERE!";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "SHHH...Listen...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The footsteps are drawing closer with every second, but...wait..";
        }
        else if (primeInt == 10)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Your stomach drops when a faint shuffling can be heard somewhere in the darkness.";
        }
        else if (primeInt == 11)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "I just want to go home...";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 12)
        {
            Image_GwenScared.SetActive(false);
            Image_GregoryScared.SetActive(true);
            Char1You.text = "You";
            Char1YouSpeech.text = "I don't know...maybe it's just a really good haunted house?";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "I never should have come with you guys...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 13)
        {
            Image_GregoryScared.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "This place used to resonate with me, but the vibes are just..off now...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 14)
        {
            Image_GwenScared.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Guys, there's noises coming from both ways, what should we do?";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            Button_Next.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            //Choice1c.SetActive(true);
        }

        else if (primeInt == 100)
        {
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Okay";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 101)
        {
            Image_Gwen.SetActive(false);
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Can we please just start moving? I'm so sick of this place...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 102)
        {
            Image_GregoryScared.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Let's just go...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 103)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Alright guys, everyone hang onto each other and we'll move slow and steady.";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 104)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You creep forwards, the rest of the crew close on your heels.";
        }

        else if (primeInt == 105)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "A surge of hope rushes through you as the exit sign glows brighter with every step.";
        }

        else if (primeInt == 106)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Guys...I think we're gonna make it!";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
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
            //Button_SceneChange2.SetActive(true);
        }
        else if (primeInt == 107)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Oh thank God.";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 108)
        {
            Image_Gregory.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Shhh! Guys, what happened to being quiet???";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 109)
        {
            Image_Gwen.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "You're talking too, therefore you are apart of the problem.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 110)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Guys! Keep it together...";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

            if (gameHandler.CheckPlayerStat() <= 0)
            {
                primeInt = 149;
            }
            else if (gameHandler.CheckPlayerStat() > 0)
            {
                primeInt = 249;
            }

        }
        else if (primeInt == 150)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "You hear a scream, then another scream. You go to the door, arm outstretched.";
        }
        else if (primeInt == 151)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Suddenly, you feel a hand wrap around your shirt collar and drag you backwards.";
        }
        else if (primeInt == 152)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Your head hits the ground hard, and as you're swimming in and out of consciousness...";
        }
        else if (primeInt == 153)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "...you feel yoursef being dragged back into the depths of the house. The last thing you hear before you pass out is,";
            //Button_Next.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange2.SetActive(true);
        }
        else if (primeInt == 154)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "You will never get out of this place alive...";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Are you serious?!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }

        else if (primeInt == 201)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "In what world does making a mad dash through a room past something make sense?";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {
            Image_Gwen.SetActive(true);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "I dunno, I think they're onto something...";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 203)
        {
            Image_Gwen.SetActive(false);
            Image_PJ.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "I'm all for it, I love the adrenaline.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 204)
        {
            Image_GregoryScared.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Oh god...we're all gonna die...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 205)
        {
            Image_GregoryScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Pull yourself together, Greg. What's the worst that can happen?";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 206)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "Chad";
            //Char2ChadSpeech.text = "Quickly!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Grabbing Gregory's clammy hand, you take off towards the door. Your footsteps echoing through the room.";
        }
        else if (primeInt == 207)
        {
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Guys, I think I just heard something next to me!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 208)
        {
            Image_GregoryScared.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "Let's go!";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "For the love of God, Greg! JUST SHUT UP AND RUN!";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 209)
        {
            Image_Gwen.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The door draws closer and closer, and you switch into a full sprint.";

            if (gameHandler.CheckPlayerStat() <= 0)
            {
                primeInt = 149;
            }
            else if (gameHandler.CheckPlayerStat() > 0)
            {
                primeInt = 249;
            }


        }
        
        else if (primeInt == 250)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The dread pools into your stomach as you get closer and closer to the door.";
        }
        else if (primeInt == 251)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "As you reach the door, the cool autumn air hits you all as you immediately slam the door behind you.";
        }
        else if (primeInt == 252)
        {
            Char1You.text = "";
            Char1YouSpeech.text = "";
            //Char2Chad.text = "";
            //Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You all breathe a sigh of relief as you walk away from the house.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange2.SetActive(true);
        }
        
    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Image_GwenScared.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "Guys- let's just move quietly and slowly so we can avoid whatever is in here...";
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
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
        Button_Next.SetActive(true);
        allowSpace = true;

        gameHandler.AddPlayerStat(-1);

    }
    public void Choice1bFunct()
    {
        Image_GwenScared.SetActive(false);
        Char1You.text = "You";
        Char1YouSpeech.text = "I say we book it...if we rush the door there's no way whatever is here can catch us.";
        //Char2Chad.text = "";
        //Char2ChadSpeech.text = "";
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
        Button_Next.SetActive(true);
        allowSpace = true;

        gameHandler.AddPlayerStat(1);

    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene_Lose1");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene_Win1");
    }

}
