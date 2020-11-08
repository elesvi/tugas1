using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{

	//public Transform Player;
	private NavMeshAgent agent;
	public float playerDistance;
	public float speed;
	private Transform player;
	private float rotationSpeed = 2;
	Rigidbody rigidbody;
	bool follow;
	public LayerMask obslayer;
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		agent = GetComponent<NavMeshAgent>();

	}

	void Update()
	{
//		
//		if(Vector3.Distance(transform.position,player.position) > playerDistance)
//		{
//			
			transform.position = Vector3.MoveTowards (transform.position, player.position, speed * Time.deltaTime);
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rotationSpeed * Time.deltaTime);
//	
//		}




	}
	void Look()
	{
		
		RaycastHit hitInfo ;
		Ray ray = new Ray (transform.position, player.position - transform.position);

//		if (Physics.Raycast (ray, out hitInfo)) 
//		{
//			Vector3 lookDir = new Vector3 ();
//			Vector3 targetRotation = Quaternion.LookRotation (lookDir - transform.position).eulerAngles;
//			targetRotation = new Vector3 (0, targetRotation.y, 0);
//
//			transform.rotation = Quaternion.Euler (targetRotation);
//		}
		if (Physics.Raycast (ray,out hitInfo)) 
		{
//			Vector3 lookDir = new Vector3 ();
//			Vector3 targetRotation = Quaternion.LookRotation (lookDir - transform.position).eulerAngles;
//			targetRotation = new Vector3 (0, targetRotation.y, 0);
//
//			transform.rotation = Quaternion.Euler (targetRotation);

				//transform.position = Vector3.MoveTowards (transform.position, player.position, speed * Time.deltaTime);

			
		}



	}

}