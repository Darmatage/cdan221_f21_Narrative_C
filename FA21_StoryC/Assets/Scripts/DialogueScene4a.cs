using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4a : MonoBehaviour
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
    public GameObject Button_Next;
    //public GameHandler gameHandler;
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
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You enter a dimly lit room, with plain gray cinder block walls that are lined with industrial machinery.";
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
            Char6Narration.text = "Chains and sparking wires dangle from the ceiling,";
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
            Char6Narration.text = "and the moonlight pours in from a singular skylight.";
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
            Char6Narration.text = "Yellow tape adorns the cement floor, and the room is eerily still.";
        }
        else if (primeInt == 6)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "What the hell? The last room was such a bust, and now this one is just empty?? What did we even pay for?";
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
            Char5PJSpeech.text = "The last room dragged when it came to the scare factor, don't get me wrong. But the SFX definitely made up for it.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 8)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = "Are you guys sure this is the right room? Did we miss a door?";
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
        else if (primeInt == 9)
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
            Char6Narration.text = "The menacing rattle of chains pierced through the air, snapping you all out of your confused silence.";
            // Turn off "Next" button, turn on "Choice" buttons
            //nextButton.SetActive(false);
            // allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 10)
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
            Char5PJSpeech.text = "What was that?";
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
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The noise starts to seemingly draw closer to your group, and you scan the shadowed corners of the room, trying to find the source of the noise. ";
            Button_Next.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); 
            Choice1b.SetActive(true);
            //Button_SceneChange1.SetActive(true);
        }
     
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
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
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "You hold your ground, curious as to what the sound is.";
        }
        else if (primeInt == 101)
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
            Char5PJSpeech.text = "I donÅ't have the best feeling about thisÅ...";
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
            Char6Narration.text = "Your heart races as the sound draws closer and closerÅ. A flash of blue and red leaps out of the shadows towards youÅ";

        }
        else if (primeInt == 103)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "AAAGGHHHHH!!!!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 104)
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
            Char6Narration.text = "A man stumbles towards you, bloodied protective goggles hanging off of one side of his face.";

        }
        else if (primeInt == 105)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "OH HELL NO!";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 106)
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
            Char5PJSpeech.text = " Look at the anguish in his eyesÅ, I feel like this on the insideÅ.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 107)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Now is not the time but we need to get you help, man.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 108)
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
            Char5PJSpeech.text = "Ew, what happened to his arms??";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 109)
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
            Char6Narrator.text = "Narrator";
            Char6Narration.text = "The man draws closer, chains trailing behind him, his arms mangled and bloodied stumps.";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }
        else if (primeInt == 110)
        {
            Image_PJ.SetActive(false);
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
            Char6Narrator.text = "";
            Char6Narration.text = "YOU SEE MY ARMS? YOURS WILL LOOK THE SAME BY THE TIME THE MACHINEÅS DONE WITH YA!";
        }
        else if (primeInt == 111)
        {
            Image_PJ.SetActive(false);
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
            Char6Narration.text = "He advances, and you can feel his rancid breath on your face";
        }
        else if (primeInt == 112)
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
            Char5PJ.text = "P.J";
            Char5PJSpeech.text = "Why do his wounds look so real?";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 113)
        {
            Image_Chad.SetActive(true);
            Image_PJ.SetActive(false);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Hey, man. Between us, how does that costume work? Are your arms, like, underneath the shirt?";
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
            Char6Narration.text = "The man growls and advances further, the chains at his feet seeming to slow him down a bit.";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Button_SceneChange1.SetActive(true);
        }

        else if (primeInt == 114)
        {
            Char1You.text = "You";
            Char1YouSpeech.text = "Guys, this is kinda boringÅ he's the only dude in this room";
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
            //Button_SceneChange1.SetActive(true);

        }
        else if (primeInt == 115)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Yeah, let's just go.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 116)
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
            Char6Narration.text = "And with that, the three of you move towards the next door, the man stumbling behind you.";
            Button_Next.SetActive(false);
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
            Char5PJSpeech.text = "This feeling of fearÅ it makes me feel more alive than I have in yearsÅ.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
       else if (primeInt == 201)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "WeÅ're getting you some serious help after all of thisÅ...";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 202)
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
            Char5PJSpeech.text = "Maybe we should stay and check it out- I think this could be neat.";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 203)
        {
            Image_PJ.SetActive(false);
            Char1You.text = "You";
            Char1YouSpeech.text = " I don't know, dude.";
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
        else if (primeInt == 204)
        {
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "Maybe we should get out of hereÅ. Like to find a real jump scare or something.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
        }
        else if (primeInt == 205)
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
            Char5PJSpeech.text = "FineeeeÅ.";
            Char6Narrator.text = "";
            Char6Narration.text = "";

        }
        else if (primeInt == 206)
        {
            Image_PJ.SetActive(false);
            Image_Chad.SetActive(true);
            Char1You.text = "";
            Char1YouSpeech.text = "";
            Char2Chad.text = "Chad";
            Char2ChadSpeech.text = "LetÅ's roll.";
            //Char3Gwen.text = "";
            //Char3GwenSpeech.text = "";
            //Char4Gregory.text = "";
            //Char4GregorySpeech.text = "";
            Char5PJ.text = "";
            Char5PJSpeech.text = "";
            Char6Narrator.text = "";
            Char6Narration.text = "";
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
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "You are intruiged by the noise getting closer.";
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
        //Char3Gwen.text = "";
        //Char3GwenSpeech.text = "";
        //Char4Gregory.text = "";
        //Char4GregorySpeech.text = "";
        Char5PJ.text = "";
        Char5PJSpeech.text = "";
        Char6Narrator.text = "Narrator";
        Char6Narration.text = "The chains rattle violently, getting louder ad louder with every second.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }



    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene5a");
    }
    

}