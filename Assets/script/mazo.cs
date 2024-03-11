using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;

public class mazo : MonoBehaviour
{
    public GameObject[] mazos = new GameObject[42];
    public List<GameObject> hand = new List<GameObject>();
    public RawImage[] pics = new RawImage[10];
    private int Post_Robo = 0;
    public RawImage[] CortoAlcance= new RawImage[5];
    public RawImage[] MedioAlcance= new RawImage[5];
    public RawImage[] LargoAlcance= new RawImage[5];
    private void PosicionarCartas()
    {
        for (int i = 0; i< pics.Length; i++)
        {
            pics[i].texture = hand[i].GetComponent<SpriteRenderer>().sprite.texture;
            }
    }

   
    private void RobarCarta(int cartas)
    {
        for(int RoboRecorrido=0; RoboRecorrido<cartas;RoboRecorrido++)
        {
            hand.Add(mazos[Post_Robo]);
            Post_Robo++;
        }
    }

    private void Start()
    {
        Barajear_Carta();
        RobarCarta(10);
        PosicionarCartas(); 
    }
    private void Barajear_Carta()
    {
        for (int CartaRecorrido = 0; CartaRecorrido < mazos.Length; CartaRecorrido++) 
        {
            int CartaRandom = Random.Range(0, mazos.Length);
            GameObject card = mazos[CartaRecorrido];
            mazos[CartaRecorrido] = mazos[CartaRandom];
            mazos[CartaRandom]=card;    
        }
    }
}
