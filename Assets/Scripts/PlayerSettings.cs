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
    private int P1_Stam;
    private int P2_Stam;
    //PlayerInventory
    enum Item { NOTHING, BOULDER, TREE, HUMAN, SHEEP }; //list of carried items
    private Item P1_L_Item;
    private Item P1_R_Item;
    private Item P2_L_Item;
    private Item P2_R_Item;
    private int currentTeam = 0; //change this after UI change
    public GameObject Oni1;
    public GameObject Oni2;
    private Vector3 Oni1_Title_T = new Vector3(806.73f, 17.8f, 288.6f);
    private Vector3 Oni1_Title_R = new Vector3(0f, -10.96f, 0f);
    private Vector3 Oni1_Start_T = new Vector3(800.7f, 15f, 722.2f);
    private Vector3 Oni1_Start_R = new Vector3(0f, -171.6f, 0f);
    private Vector3 Oni2_Title_T = new Vector3(854.6f, 17.8f, 330.4f);
    private Vector3 Oni2_Title_R = new Vector3(0f, -87.7f, 0f);
    private Vector3 Oni2_Start_T = new Vector3(292.33f, 15f, 82.2f);
    private Vector3 Oni2_Start_R = new Vector3(0f, 60.23f, 0f);

    // Use this for initialization
    void Start() {
        //nGame();
        Oni1.transform.position = Oni1_Title_T;
        Oni1.transform.eulerAngles = Oni1_Title_R;
        Oni2.transform.position = Oni2_Title_T;
        Oni2.transform.eulerAngles = Oni2_Title_R;
    }

    public void nGame() {
        this.P1_L_HP = HP.OKAY;
        this.P1_R_HP = HP.OKAY;
        this.P2_L_HP = HP.OKAY;
        this.P2_R_HP = HP.OKAY;
        this.P1_L_Item = Item.NOTHING;
        this.P1_R_Item = Item.NOTHING;
        this.P2_L_Item = Item.NOTHING;
        this.P2_R_Item = Item.NOTHING;
        this.P1_Stam = 112;
        this.P2_Stam = 112;
        this.currentTeam = 1;
        Oni1.transform.position = Oni1_Start_T;
        Oni1.transform.eulerAngles = Oni1_Start_R;
        Oni2.transform.position = Oni2_Start_T;
        Oni2.transform.eulerAngles = Oni2_Start_R;
        //TODO
        //tell the level script to initialize level objects
    }

    //Methods:

    //Timer
    public int getTimer() { return this.levelTimer; }
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
            character = side == 'L' ? this.P1_L_HP += value : this.P1_R_HP += value;
        }
        else {
            character = side == 'L' ? this.P2_L_HP += value : this.P2_R_HP += value;
        }
        //check if dead
    }
    public void setStam(int value) {//checks itself for upper/lower limits
        if (currentTeam == 1) {
            this.P1_Stam += value;
            if (P1_Stam > 112) this.P1_Stam = 112;
            if (P1_Stam < 0) this.P1_Stam = 0;
        }
        else {
            this.P2_Stam += value;
            if (P2_Stam > 112) this.P2_Stam = 112;
            if (P2_Stam < 0) this.P2_Stam = 0;
        }
    }
    public int getStam() {
        return currentTeam == 1 ? this.P1_Stam : this.P2_Stam;
    }
    public void setTeam(int side) {
        if (!(side == 1 || side == 2)) throw new System.Exception("ERROR: side is limited to 1 or 2");
        else {
            this.currentTeam = side;
        }
    }
    public int getTeam() {
        return this.currentTeam;
    }
}
