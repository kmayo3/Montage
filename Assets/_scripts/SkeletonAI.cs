using UnityEngine;
using System.Collections;

public class SkeletonAI : MonoBehaviour {
	public float speed = 1f;
	public int rotationSpeed;

	public static float maxHealth = 2;
	public static float currentHealth = 2;
	
	void Start() 
	{
		//target = GameObject.Find("Player").transform;
	}
	
	void Update() 
	{    
		Vector3 target = GameObject.FindGameObjectWithTag("Player").transform.position;
		if (target != null) {
			if (Vector3.Distance (this.transform.position, target) < 5) {
				Vector3 dir = target - this.transform.position;
				// Only needed if objects don't share 'z' value.
				dir.z = 0.0f;
				if (dir != Vector3.zero) 
				//transform.rotation = Quaternion.Slerp ( transform.rotation, 
				//                                     Quaternion.FromToRotation (Vector3.right, dir), 
				//                                   rotationSpeed * Time.deltaTime);
				
				//Move Towards Target
					this.transform.position += (target - this.transform.position).normalized 
						* speed * Time.deltaTime;
			}
		}
		
		GetComponent<Rigidbody2D>().velocity = Vector3.zero;
	}
}
