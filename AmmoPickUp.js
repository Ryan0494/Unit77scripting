var AmmoSound : AudioSource;

var ObjectiveComplete : GameObject;

function OnTriggerEnter (col : Collider) {
	AmmoSound.Play();
	ObjectiveComplete.SetActive(true);
	if (GlobalAmmo.LoadedAmmo == 0) {
		GlobalAmmo.LoadedAmmo += 5;
		this.gameObject.SetActive(false);
	}
	else {
	GlobalAmmo.CurrentAmmo += 5;
	this.gameObject.SetActive(false);
	}
}