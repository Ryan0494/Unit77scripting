var EnemyHealth : int = 20
;
var TheZombie : GameObject;

function DeductPoints (DamageAmount : int) {
	EnemyHealth -= DamageAmount;
}

function Update () {
	if (EnemyHealth <= 0) {
		TheZombie.GetComponent.<Animation>().Play("Dying");
		EndZombie();
	}
}

function EndZombie () {
	yield WaitForSeconds(3.0);
	Destroy(gameObject);
}