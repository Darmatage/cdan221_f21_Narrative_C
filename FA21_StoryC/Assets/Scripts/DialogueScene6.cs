using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6 : MonoBehaviour
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
    public GameObject Image_ChadScared;
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
        Image_Chad.SetActive(false);
        Image_ChadScared.SetActive(false);
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
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "Leaving the room, you and your friends enter a long hallway.";
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
            Char6Narration.text = "A few doors litter the sides of the hallway, and as soon as the door behind you slams shut...";
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
            Char6Narration.text = "...the dreary and overwhelming atmosphere begins to settle in.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Jesus...";
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
        else if (primeInt == 6)
        {
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "*Yells* AH! You scared me!!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 7)
        {
            Image_GregoryScared.SetActive(false);
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
            Char5PJSpeech.text = "What do you mean? I came in here before you did?";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_Gwen.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "We've been here the whole time...";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 9)
        {
            Image_Gwen.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Man, some of the shit in those rooms...";
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
            Image_Chad.SetActive(false);
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
            Char5PJSpeech.text = "They are coming in with the scares, but maybe it's getting to be a bit much...";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 11)
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
            Char4GregorySpeech.text = "I've been saying that since the beginning!!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 12)
        {
            Image_Gregory.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "I don't know...seems like it's just a really good haunted house?";
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
        else if (primeInt == 13)
        {
            Image_GwenScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Are you crazy?! This is totally real!";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 14)
        {
            Image_GwenScared.SetActive(false);
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
            Char5PJSpeech.text = "I kinda agree, there are haunted houses where actors can touch you.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 15)
        {
            Image_PJ.SetActive(false);
            Image_GregoryScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Sure, but they can't attempt to physically harm!!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 16)
        {
            Image_GregoryScared.SetActive(false);
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
            Char6Narration.text = "It's at this point, there is a banging on the door behind you. It grows louder and louder...";
        }
        else if (primeInt == 17)
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
            Char6Narration.text = "And all of a sudden...the lights go out.";
        }
        else if (primeInt == 18)
        {
            Image_ChadScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Whether or not this is real, let's just keep going!";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 19)
        {
            Image_ChadScared.SetActive(false);
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
            Char6Narration.text = "Going deeper into the hall, you realize: you're in a maze. The walls are ever twisting until...";
        }
        else if (primeInt == 20)
        {
            Image_ChadScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "....Which way do we go?";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
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
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Yeah, yeah...that sounds like a good idea.";
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
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "I think I hear someone!!!";
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
            Char6Narration.text = "Continuing down the hallway you see the glow of a red exit sign.";
        }
        else if (primeInt == 103)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "There it is!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 104)
        {
            Image_Gregory.SetActive(false);
            Image_Gwen.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "Gwen";
            Char3GwenSpeech.text = "Thank God!";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 105)
        {
            Image_Gwen.SetActive(false);
            Image_PJScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "PJ";
            Char5PJSpeech.text = "Guys wait-";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }

        else if (primeInt == 106)
        {
            Image_PJScared.SetActive(false);
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
            Char6Narration.text = "PJ is cut short by the sound of loud footsteps barreling down the hallway.";
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
            Char6Narration.text = "You hear a scream, then another scream. You go to the door, arm outstretched.";
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
            Char6Narration.text = "HAHAHA! And you thought you could escape...You'll never leave this place!";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Image_Gregory.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Yeah...I heard in mazes if you keep your hand on the right wall you'll get out.";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
            //gameHandler.AddPlayerStat(1);
        }

        else if (primeInt == 201)
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
            Char5PJSpeech.text = "That's total bs, but whatever, let's just go.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
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
            Char6Narration.text = "As you all continue down, you begin to hear another set of footsteps distantly behind you.";
        }
        else if (primeInt == 203)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Guys...";
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
        else if (primeInt == 204)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "I know, I hear it too. Let's just book it.";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "";
            Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 205)
        {
            Image_Chad.SetActive(false);
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
            Char6Narration.text = "You all begin to walk faster. The footsteps get louder as they close in on your group. Soon, you're running.";
        }
        else if (primeInt == 206)
        {
            Image_ChadScared.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Quickly!";
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
            Image_GregoryScared.SetActive(true);
            Image_ChadScared.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "";
            Char2ChadSpeech.text = "";
            Char3Gwen.text = "";
            Char3GwenSpeech.text = "";
            Char4Gregory.text = "Gregory";
            Char4GregorySpeech.text = "Look, a door!";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 208)
        {
            Image_GregoryScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Let's go!";
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
            Char6Narration.text = "Picking up the pace you all run to the door. The footsteps speed up.";
        }
        else if (primeInt == 210)
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
            Char6Narration.text = "Chad slams the door open as you all run through...however...";
        }
        else if (primeInt == 211)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "CHAD!!";
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
        else if (primeInt == 212)
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
            Char6Narration.text = "The figure grabs Chad and yanks him back, slamming the door closed behind you as you bang on it.";
        }
        else if (primeInt == 213)
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
            Char6Narration.text = "Chad's yells resonate behind the door, slowly fading away.";
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_SceneChange2.SetActive(true);
        }
    }
        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct()
        {
            Image_ChadScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Let's go left!";
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
            Button_Next.SetActive(true);
            allowSpace = true;

            gameHandler.AddPlayerStat(-1);

        }
        public void Choice1bFunct()
        {
            Image_ChadScared.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Let's go right!";
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
            SceneManager.LoadScene("Scene7");
        }

}
