using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Since there are six of us working on scripts, we want to store major variables,
that other people will use, in one place. Thats what PlayerSettings is for.
This is how you can access those PlayerSettings*/

public class Example : MonoBehaviour {
    /*the type of variable is the name of the script. Instead of int or string, etc.
    make it public. In Unity you'll drag the 'PlayerSettings' object onto this script to make that connection.
    you can see that on the Example Object in the main scene*/
    //
    public PlayerSettings settings;

    void Function () {
        /*Even with it set properly above, you need to do .GetComponent<ScriptName>()
        anything following are the functions that are within that script. Here I'm setting the timer*/
        settings.GetComponent<PlayerSettings>().setTimer(40);
        /*you need to do the above everytime you call a function... it's a pain
        BUT you can do something like the below to make it shorter to type.*/
        PlayerSettings shorter = settings.GetComponent<PlayerSettings>();
        /*BUT it can only be done inside a Function, you can't use .GetComponent on a global variable.
        which is why it's down here, inside the Function, instead of at the top, outside the Function.*/

        //Here's how you'd use the shorter version.
        shorter.setTimerFirstEnabled(true);
        //if you copy/paste these scripts, don't call it "shorter" lol

        //When you use a get~ function, you need to store it in a local variable.
        int Timer = shorter.getTimer();

        /*If you're doing a script that actually counts down the timer you'd countdown your local variable
        when you need to start your timer again, run the getTimer function again.
        we shouldn't need to store temporary variables in the PlayerSettings script*/
    }
}
