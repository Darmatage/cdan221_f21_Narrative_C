using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5b : MonoBehaviour
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
    public GameObject Image_GregoryScared;
    public GameObject Image_PJ;
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
        Image_Chad.SetActive(false);
        Image_Gwen.SetActive(false);
        Image_Gregory.SetActive(false);
        Image_GregoryScared.SetActive(false);
        Image_PJ.SetActive(false);
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
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter the room and are greeted by a huge plume of pungent smoke.";
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
            Char6Narration.text = "Once it clears, you see the interior of a peculiar hut. Two doors sit on the other end of the room.";
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
            Char6Narration.text = "A bright red exit sign sits above one, and the other is a blank door.";
            //gameHandler.AddPlayerStat(1);
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
            Char6Narration.text = "Shelves of unmarked herbs and liquids line the walls, with books scattered about. As far as you see, it's empty.";
        }
        else if (primeInt == 6)
        {
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Ooh, it looks so witchy in here...I love it!!";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 7)
        {
            Image_Gwen.SetActive(false);
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
            Char5PJSpeech.text = "I wonder if there are, like, organs or something in some of these jars...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Chad.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Dude, stop being gross.";
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
            Image_GregoryScared.SetActive(true);
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "I don't like this at all...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 10)
        {
            Image_Chad.SetActive(true);
            Image_GregoryScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "If you're gonna keep killing the fun, the exit is right over there.";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
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
            Char4GregorySpeech.text = "Whatever...";
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
            Char1You.text = "You";
            Char1YouSpeech.text = "You all can keep going, but I think I'll bring our buddy Greg outside.";
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
        else if (primeInt == 101)
        {
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "You both are such bummers...";
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

        else if (primeInt == 102)
        {
            Image_Gwen.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Thanks for taking one for the team, dude. I appreciate it.";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 103)
        {
            Image_PJ.SetActive(true);
            Image_Chad.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "We'll catch you guys outside.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 104)
        {
            Image_PJ.SetActive(false);
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
            Char6Narration.text = "You put your hand on Gregory's shoulder and start moving towards the door.";
        }

        else if (primeInt == 105)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Thanks...It means a lot.";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 106)
        {
            Image_Gregory.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Anytime.";
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
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
            //Button_SceneChange2.SetActive(true);
        }
        else if (primeInt == 107)
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
            Char6Narration.text = "You push open the door, and you both step outside.";
        }
        else if (primeInt == 108)
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
            Char6Narration.text = "Suddenly, you feel a hand wrap arund your shirt collar and drag you backwards.";
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
            Char6Narration.text = "Your head hits the ground hard, and as you're swimming in and out of consciousness...";
        }
        else if (primeInt == 110)
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
            Char6Narration.text = "...you feel yoursef being dragged back into the depths of the house. The last thing you hear before you pass out is,";
            //Button_Next.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange2.SetActive(true);
        }
        else if (primeInt == 111)
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
            Char6Narrator.text = "";
            Char6Narration.text = "You're never gonna get out of this place alive...";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Don't worry Greg, all this is just staged to make you scared.";
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
            //gameHandler.AddPlayerStat(1);
        }

        else if (primeInt == 201)
        {
            Image_Chad.SetActive(true);
            Image_Gregory.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Exactly, so no need to wimp out on us now!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
        {
            Image_Chad.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Yeah! Besides, I can totally feel that we are getting close to the end...";
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
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Okay I guess...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 204)
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
            Char5PJSpeech.text = "Yo check this cauldron, it looks like they have real ingredients in here...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 205)
        {
            Image_PJ.SetActive(false);
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
            Char6Narration.text = "Just as PJ finishes, you all hear what sounds like cackling getting closer...";
        }
        else if (primeInt == 206)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "I think the witches are coming to check on their brew; c'mon let's keep going.";
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
        else if (primeInt == 207)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Yeah...I agree, I'm not really in the mood to meet any witches...";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 208)
        {
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
            Char6Narration.text = "As you all file into the next room, you can swear you hear the laughter right behind you.";
        }
        else if (primeInt == 209)
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
            Char6Narration.text = "Just as you close the door, you see a few figures entering the room, cackling menacingly...";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange2.SetActive(true);
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
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
        Char6Narration.text = "You sigh and look at the rest of the group.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
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
        Char6Narration.text = "You sigh and roll your eyes, looking around.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene_Lose1");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene6");
    }

}
