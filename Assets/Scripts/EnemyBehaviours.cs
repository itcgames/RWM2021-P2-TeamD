using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviours : MonoBehaviour
{
	public float m_movement_speed = 0.5f;

	public bool m_wander = true;
	public bool m_player_detected = false;

	public float m_radius_view_distance = 0.1f;
	public float m_view_distance = 1.0f;
	public float m_FoV = 90;

	private Rigidbody2D rb;
	public Vector3 direction;

	GameObject m_player;

	public const float NEW_WANDER_DIR_WAIT = 10;
	float m_current_wait_time = NEW_WANDER_DIR_WAIT;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		direction = new Vector3(0, 0, 0);

		m_player = GameObject.FindGameObjectWithTag("Player");

		Physics2D.queriesStartInColliders = false;
		Physics2D.queriesHitTriggers = false;
	}

	void Update()
	{
		if (m_player != null)
		{
			DetectPlayer();
			FollowPlayer();
		}

		rb.velocity = direction * m_movement_speed;

		if (m_wander && m_current_wait_time <= 0)
			GetWanderDirection();

		if (m_wander && m_current_wait_time > 0)
			m_current_wait_time -= Time.deltaTime;
		else
			m_current_wait_time = NEW_WANDER_DIR_WAIT;

		transform.rotation = Quaternion.Euler(
				new Vector3(0.0f, 0.0f, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg));
	}

	void DetectPlayer()
	{
		if (Vector3.Distance(transform.position, m_player.transform.position) < m_view_distance)
		{
			Vector3 dirToPlayer = (m_player.transform.position - transform.position).normalized;

			if (Vector3.Angle(direction, dirToPlayer) < m_FoV / 2)
			{

				RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, dirToPlayer, m_view_distance);

				if (raycastHit2D.collider != null)
				{

					if (raycastHit2D.collider.gameObject.GetComponent<Player>() != null)
					{
						m_player_detected = true;
						direction = dirToPlayer;
					}
					else
					{
						m_player_detected = false;
					}
				}
			}
		}

		if (Vector3.Distance(transform.position, m_player.transform.position) < m_radius_view_distance)
		{
			Vector3 dirToPlayer = (m_player.transform.position - transform.position).normalized;

			RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, dirToPlayer, m_radius_view_distance);

			if (raycastHit2D.collider != null)
			{
				if (raycastHit2D.collider.gameObject.GetComponent<Player>() != null)
				{
					m_player_detected = true;
					direction = dirToPlayer;
				}
				else
				{
					m_player_detected = false;
				}
			}
		}
	}

	void FollowPlayer()
	{
		if (m_player_detected)
			m_wander = false;
		else 
			m_wander = true;
	}

	void GetWanderDirection()
    {
		direction.x = Random.Range(-1, 2);
		direction.y = Random.Range(-1, 2);
		direction.z = 0;
    }
}
