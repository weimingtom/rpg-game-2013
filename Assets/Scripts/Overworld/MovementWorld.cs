using UnityEngine;
using System.Collections;

public class MovementWorld : MonoBehaviour {

	float movSpeed;
	float walkSpeed = 5f;
	float runSpeed = 7f;
	public bool walking = false;
	int randomN;
	public float randEncounterTime;
	public GameObject spawner;
	public GameObject battle;
	public GameObject emptyWorld;
	public GameObject playerBattle;
	public GameObject weapon;
	public BattleController battleController;
	public FadeInOut fade;
	public GameObject dungeon;
	public Transform charPosExitCave;
	public Transform charCavePosEntrance;
	public string currentWorld = "Overworld";
	
	public GameObject menu;
	public GameObject overWorld;
	
	
	void Start () {
		movSpeed = walkSpeed;
		randEncounterTime = Random.Range(7,15);
		menu.SetActive(false);
	}
	
	
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,0f,transform.forward.z * movSpeed);
		}
		
		if(Input.GetKey(KeyCode.S)){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,0f,-transform.forward.z * movSpeed);
		}
		
		if(Input.GetKey(KeyCode.D)){
			rigidbody.velocity = new Vector3(transform.right.x*movSpeed,0f,rigidbody.velocity.z);
		}
		
		if(Input.GetKey(KeyCode.A)){
			rigidbody.velocity = new Vector3(-transform.right.x*movSpeed,0f,rigidbody.velocity.z);
		}
		
		if(Input.GetKeyDown(KeyCode.Return)){
			menu.SetActive(true);
			DesactiveWorld();
			this.gameObject.SetActive(false);
		}
		
		if(Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)){
			movSpeed = runSpeed;
		}
		else{
			movSpeed = walkSpeed;
		}
		
		
		if(rigidbody.velocity.magnitude != 0){
			walking = true;
		}
		else{
			walking = false;
		}
		
		if(walking){
			randEncounterTime -= Time.deltaTime;
			if(randEncounterTime <= 0){
				//randEncounterTime = Random.Range(7,15);
				fade.enabled = true;
				playerBattle.SetActive(true);
				weapon.SetActive(true);
				this.enabled = false;
			}
		}else{
			randEncounterTime = Random.Range(7,15);
		}

	}
	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag.Equals("CaveEntrance")){
			dungeon.SetActive(true);
			currentWorld = "Dungeon";
			transform.position = charCavePosEntrance.position;
			overWorld.SetActive(false);

		}
		if(coll.gameObject.tag.Equals("CaveDoor")){
			overWorld.SetActive(true);
			currentWorld = "Overworld";
			transform.position = charPosExitCave.position;
			dungeon.SetActive(false);
		}
	}
	void DesactiveWorld(){
		if(currentWorld == "Overworld"){
			emptyWorld.SetActive(false);
		}else if(currentWorld == "Dungeon"){
			dungeon.SetActive(false);
		}
	}
}
