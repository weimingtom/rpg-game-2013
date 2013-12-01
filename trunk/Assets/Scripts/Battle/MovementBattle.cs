using UnityEngine;
using System.Collections;

public class MovementBattle : MonoBehaviour {
	
	
	public GameObject stats;
	int damage;
	public TextMesh damageMesh;
	public GameObject playerOW;
	float timeText = 1f;			//Time the text can be seen
	
	bool damaged = false;
	
	bool jumping = false;
	
	public GameObject enemy;
	Vector3 dif;					//Difference between the enemy and the character position
	public bool attacking = false;
	float attTime = 2f;
	public GameObject world;		//Empty GameObject
	public GameObject emptyBattle;
	public BattleController battleController;
	public bool escaped = false;
	float escTime;	//time for scaping battle
	public Transform weapon;
	
	private Vector3 moveDirection;
	public float moveSpd = 8;

	private Vector3 forward;
	private Vector3 right;

	float delay = 1.6f;
	public MovementWorld mw;
	
	
	
	
	
	void Start () {
		stats = GameObject.FindWithTag("Stats");
	}
	
	
	void Update () {
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat))as CharactersStat;
		
		enemy = GameObject.FindWithTag("Enemy");
		//dif = transform.position - enemy.transform.position;
		
		//Walk
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		if(v==0 && h==0) UpdateDirections();
		moveDirection=forward*v + right*h;
		moveDirection.Normalize();
		moveDirection *= moveSpd;
		
		rigidbody.velocity = new Vector3 (moveDirection.x,rigidbody.velocity.y,moveDirection.z);
		if(moveDirection.magnitude!=0)transform.forward = moveDirection;
		
		//Jump
		if(Input.GetKeyDown(KeyCode.Space) && !jumping){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,8f,rigidbody.velocity.z);
			jumping = true;
		}


		if(Input.GetKeyDown(KeyCode.M)){
			Attack();
			attacking = true;
		}


		battleController.CheckEnemies();
		if(damaged){
			timeText -= Time.deltaTime;
			if(timeText<=0){
				damageMesh.text="";
				damaged = false;
				timeText = 1f;
			}
		}
		if(cs.hp<=0){
			cs.hp = 0;
			Destroy(damageMesh);
			Destroy(this.gameObject);
		}
		
		//Run from battle
		if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.KeypadEnter)){	
			escTime -= Time.deltaTime;
			if(escTime <= 0){
				escaped = true;
				world.SetActive(true);
				battleController.DestroyParty();
				emptyBattle.SetActive(false);
				playerOW.SetActive(true);
				mw.enabled = true;
			}
		}
		else{
			escTime = Random.Range(1f, 7f);	//time for scaping battle
		}
	}
	
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag.Equals("Floor")){
			jumping = false;
		}
	}
	
	
	public void CharacterDamage(){
		if(enemy == null) return;
		CharactersStat cs = stats.GetComponent(typeof(CharactersStat))as CharactersStat;
		Enemy en = enemy.GetComponent(typeof(Enemy)) as Enemy;
		damage = (int)((en.att - cs.def) * Random.Range(1f, 3f));
		if(damage <= 0) damage = 1;
		damageMesh.text = damage.ToString();
		cs.hp -= damage;
		damaged = true;
	}
	
	
	private void UpdateDirections(){
		forward = Camera.mainCamera.transform.TransformDirection(Vector3.forward);
		forward.y = 0;
		forward = forward.normalized;
		right = new Vector3(forward.z,0,-forward.x);
	}
	
	
	public void Attack(){
		if(!weapon.animation.isPlaying){
			weapon.animation.Play();
		}

	}
}
