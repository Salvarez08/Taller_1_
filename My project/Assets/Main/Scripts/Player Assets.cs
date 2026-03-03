using UnityEngine;
using TMPro;

public class PlayerRigidbody : MonoBehaviour
{
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private float veloMinima = 3f;
    [SerializeField] private float veloMaxima = 10f;
    [SerializeField] private float veloRandom;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private string _nombre = "BRISA";
    [SerializeField] private int _edad = 18;
    [SerializeField] private int _año_actual = 2026;
    [SerializeField] private int _año_nacimiento;

    void Start()
    {
        _año_nacimiento = _año_actual - _edad;
        rb = GetComponent<Rigidbody2D>();

        veloRandom = Random.Range(veloMinima, veloMaxima);

        _saludo.text = $"Hola, mi nombre es {_nombre}, tengo {_edad} años y nací en el año {_año_nacimiento}";

        rb.AddForce(Vector2.right * veloRandom, ForceMode2D.Impulse);



        //float dirX = Random.Range(-1f, 1f);
        //float dirY = Random.Range(-1f, 1f); 
        //Vector2 direccionRandom = new Vector2(dirX, dirY).normalized;

    }
}
