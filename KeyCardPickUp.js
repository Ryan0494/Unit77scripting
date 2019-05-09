var ObjectiveComplete : GameObject;
var PickUpSound : AudioSource;

function OnTriggerEnter (col : Collider) {
	PickUpSound.Play();
	ObjectiveComplete.SetActive(true);
	this.gameObject.SetActive(false);
}