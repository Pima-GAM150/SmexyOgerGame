using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour {

    public PlayerSettings settings;
    public Slider StamBar;
    public GameObject StamMax;
    private Vector3 StamMaxScale = new Vector3(1, 0, 0);
    private float Delay;
    private int stamina;
    private int stamMax;
    private int threshold;
    private bool tired = false; //only allows you to lose stam once while under threshold

    void Start () {
        settings = settings.GetComponent<PlayerSettings>();
        this.stamina = this.stamMax = settings.getStam();
        if (this.stamina > 100) this.stamina = 100;
        threshold = (int)(this.stamMax * 0.45f);
    }
	void Update () {
        Delay -= Time.deltaTime;
        //timer counts 5 seconds, else updates every 0.1 sec with +1 stam.
        if (Delay <= 0) {
            setDelayRegen();
            addStam(1);
        }	
	}
    void setDelayRegen() {//called for delay tick
        this.Delay = 0.1f;
    }
    void setDelayAction() {//called after an action is made
        this.Delay = 5;
    }
    void addStam(int value) {
        this.stamina += value;
        if (this.stamina > threshold && tired == true) {
            tired = false;
            threshold = threshold = (int)(stamMax * 0.45f);
        }
        if (this.stamina >= this.stamMax) this.stamina = this.stamMax;
        if (this.stamina > 100) this.stamina = 100;
        updateBar();
    }
    void useStam(int value) {
        this.stamina -= value;
        if (this.stamina <= 0) this.stamina = 0;
        setDelayAction();
        if (this.stamina < threshold && tired == false) {
            tired = true;
            settings.setStam(-5);
            this.stamMax = settings.getStam();
        }
        updateBar();
    }
    void eat(string item) {
        if (item == "SHEEP") {
            settings.setStam(40);
            this.stamMax = settings.getStam();
            addStam(40);
        }
        else if (item == "HUMAN") {
            settings.setStam(70);
            this.stamMax = settings.getStam();
            addStam(70);
        }
        else throw new System.Exception("Only 'SHEEP' or 'HUMAN' valid arguments in StaminaBar.eat()");
        updateBar();
    }
    void updateBar() {
        StamBar.value = this.stamina;

        float scale = (float)(100 / this.stamMax);
        if (scale > 1.0f) scale = 1.0f;
        this.StamMaxScale.x = scale;
        StamMax.transform.localScale = StamMaxScale;
    }
}
