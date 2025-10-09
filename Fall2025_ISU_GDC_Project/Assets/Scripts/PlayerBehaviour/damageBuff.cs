using UnityEngine;



public class MovementUp : MonoBehaviour
{
    public Collider2D powerUp;
    public float damage=1;
    public float duration=10;
    public float buff=1.5f;
    
    public Collider2D collider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (collider.gameObject.tag == "player")
        {
            if (duration > 0)
            {
                print("hello");
                damage *= buff;
                duration -= Time.deltaTime;
                print(damage);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("hello");
        
        

        
    }
}
