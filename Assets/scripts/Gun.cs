using UnityEngine;

public class Gun : MonoBehaviour {
	public float damage= 10f;
	public float range = 100f;
	public GameObject Player;
	public Camera fpscam;
    public ParticleSystem muzzleFlash;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}
	void Shoot()
	{
        muzzleFlash.Play();
		RaycastHit hit;

		 if(Physics.Raycast(Player.transform.position, fpscam.transform.forward, out hit, range))
		 {
			Debug.Log(hit.transform.name);

			Target target = hit.transform.GetComponent<Target>();
			if(target != null)
			{
				target.TakeDamge(damage);
			}
		 }
	}
}
