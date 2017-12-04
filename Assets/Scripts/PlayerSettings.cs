using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Store all the major values for the player character: by Gengi Tapia

public class PlayerSettings : MonoBehaviour {

    //variables: CANNOT be accessed directly. use the public get~ or set~ functions below.

    //Timer - may be moved to LevelSettings
    private int levelTimer = 30; //normal level timer
    private int levelTimerFirst = 45; //extended timer for the first round
    private bool levelTimerFirstEnabled = false; //is the extended timer enabled?
    //Controller
    private bool controller_enabled = true;
    //PlayerHealth
    enum HP { KO, HURT, OKAY }; //values of health. 0 HP, 1 HP, 2 HP. Also used for display of health status in the UI
    private HP P1_L_HP;
    private HP P1_R_HP;
    private HP P2_L_HP;
    private HP P2_R_HP;
    //PlayerInventory
    enum Item { NOTHING, BOULDER, TREE, HUMAN, BOAR }; //list of carried items
    private Item P1_L_Item;
    private Item P1_R_Item;
    private Item P2_L_Item;
    private Item P2_R_Item;

    // Use this for initialization
    void Start () {
        nGame();
	}

    void nGame() {
        this.P1_L_HP = HP.OKAY;
        this.P1_R_HP = HP.OKAY;
        this.P2_L_HP = HP.OKAY;
        this.P2_R_HP = HP.OKAY;
        this.P1_L_Item = Item.NOTHING;
        this.P1_R_Item = Item.NOTHING;
        this.P2_L_Item = Item.NOTHING;
        this.P2_R_Item = Item.NOTHING;
        //TODO

        //set player positions
        //tell the level script to initialize level objects
    }
	
    //Methods:

    //Timer
    public int getTimer() {return this.levelTimer;}
    public int getTimerFirst() { return this.levelTimerFirst; }
    public bool getTimerFirstEnabled() { return this.levelTimerFirstEnabled; }
    public void setTimer(int time) {
        //keep the timer between 10 seconds and 2 minutes
        if (time < 10) throw new System.Exception("Timer was set below 10 seconds, prevent this in your script");
        if (time > 120) throw new System.Exception("Timer was set above 2 minutes, prevent this in your script");
        //preventing the level timer to be greater then the extended first round timer.
        if (time > this.levelTimerFirst) this.levelTimerFirst = time;
        this.levelTimer = time;
    }
    public void setTimerFirst(int time) {
        //preventing the first round timer to be less then the normal round timer
        if (this.levelTimer > time) this.levelTimer = time;
        this.levelTimerFirst = time;
    }
    public void setTimerFirstEnabled(bool enable) { this.levelTimerFirstEnabled = enable; }
    //Controller
    public bool getControllerEnabled() { return this.controller_enabled; }
    public void setControllerEnabled(bool enable) { this.controller_enabled = enable; }
    //HP
    public int getHP(int player, char side) {//returns an int
        if (player < 1 || player > 2) throw new System.Exception("Player is limited to 1 or 2 in getHP");
        if (!(side == 'L' || side == 'R')) throw new System.Exception("Side is limited to 'L' or 'R' in getHP");
        int HP;
        if (player == 1) {
            HP = side == 'L' ? (int)this.P1_L_HP : (int)this.P1_R_HP;
        }
        else {
            HP = side == 'L' ? (int)this.P2_L_HP : (int)this.P2_R_HP;
        }
        return HP;
    }
    public string getStatus(int player, char side) {//returns a string
        if (player < 1 || player > 2) throw new System.Exception("Player is limited to 1 or 2 in getStatus");
        if (!(side == 'L' || side == 'R')) throw new System.Exception("Side is limited to 'L' or 'R' in getStatus");
        string HP;
        if (player == 1) {
            HP = side == 'L' ? this.P1_L_HP.ToString() : this.P1_R_HP.ToString();
        }
        else {
            HP = side == 'L' ? this.P2_L_HP.ToString() : this.P2_R_HP.ToString();
        }
        return HP;
    }
    public void setHP(int player, char side, int value) {
        if (player < 1 || player > 2) throw new System.Exception("Player is limited to 1 or 2 in setHP");
        if (!(side == 'L' || side == 'R')) throw new System.Exception("Side is limited to 'L' or 'R' in setHP");
        HP character;
        if (player == 1) {
            character = side == 'L' ? this.P1_L_HP += value: this.P1_R_HP += value;
        }
        else {
            character = side == 'L' ? this.P2_L_HP += value: this.P2_R_HP += value;
        }
        //check if dead
    }
}
