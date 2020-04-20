using UnityEngine;
using UnityEngine.UI;
public class Target : MonoBehaviour {
	public float Starthealth = 50f;
    private float health;
	public GameObject enemy;
    public Image healthBar;
    public void Start()
    {
        health = Starthealth;
    }
    public void TakeDamge(float amount)
	{
        health -= amount;
        healthBar.fillAmount = health / Starthealth;
		if (health <= 0f)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(enemy);
	}
}
