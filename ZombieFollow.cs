using UnityEngine;
using System.Collections;

public class ZombieFollow : MonoBehaviour {

	public GameObject ThePlayer;
	public float TargetDistance;
	public float AllowedRange = 10;
	public GameObject TheEnemy;
	public float EnemySpeed;
	public int AttackTrigger;


	public int IsAttacking;
	public GameObject ScreenFlash;
	public AudioSource Hurt01;
	public AudioSource Hurt02;
	public AudioSource Hurt03;
	public int PainSound;

	void Update() {
		

		if (AttackTrigger == 1) {
			if (IsAttacking == 0) {
				StartCoroutine (EnemyDamage ());
			}
			TheEnemy.GetComponent<Animation> ().Play ("Attacking");
		}
	}

	void OnTriggerEnter() {
		AttackTrigger = 1;
	}

	void OnTriggerExit() {
		AttackTrigger = 0;
	}


	IEnumerator EnemyDamage() {
		IsAttacking = 1;
		PainSound = Random.Range (1, 4);
		yield return new WaitForSeconds (0.9f);
		ScreenFlash.SetActive (true);
		GlobalHealth.PlayerHealth -= 1;
		if (PainSound == 1) {
			Hurt01.Play ();
		}
		if (PainSound == 2) {
			Hurt02.Play ();
		}
		if (PainSound == 3) {
			Hurt03.Play ();
		}
		yield return new WaitForSeconds (0.05f);
		ScreenFlash.SetActive (false);
		yield return new WaitForSeconds (1);
		IsAttacking = 0;

	}



}