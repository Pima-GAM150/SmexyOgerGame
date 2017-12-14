//****** Donations are greatly appreciated.  ******
//****** You can donate directly to Jesse through paypal at  https://www.paypal.me/JEtzler   ******

var target : Transform;

function Update () {

}

function OnTriggerEnter (col : Collider) {

	if(col.gameObject.tag == "teleport") {
		this.transform.position = target.position;
	}
}