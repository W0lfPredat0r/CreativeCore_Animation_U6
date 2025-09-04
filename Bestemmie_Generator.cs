using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;

public class Bestemmie_Generator : MonoBehaviour
{
    //{
    //    private void Update()
    //    {
    //        if (Input.GetKeyUp(KeyCode.H))
    //            Invoke(nameof(PrintMessage), 2);
    //    }

    //    public void PrintMessage()
    //    {
    //        print("Hello World");
    //    }

    //public KeyCode evocaSanto;
    //public string bestemmia;
    //public int delay;

    //    private void Update()
    //{
    //    if (Input.GetKeyDown(evocaSanto))
    //        Invoke(nameof(PrintMessage), delay);
    //}

    //public void PrintMessage()
    //{
    //    print(bestemmia);
    //}

    //public KeyCode evocazione;
    //public int delay;
    //public int numberOfTimes;
    //[Space]
    //public int[] bestemmie;
    //private void Update()
    //{
    //    if (Input.GetKeyDown(evocazione))
    //        StartCoroutine(TestCorutine());
    //}


    //public IEnumerator TestCorutine()
    //{
    //    for (int i = 0; i < bestemmie.Length; i++)
    //    {
    //        yield return new WaitForSeconds(delay);
    //        bestemmie[i] = i * 2;
    //        print(bestemmie[i]);
    //        delay *= 2;
    //    }
    //}

    //public KeyCode push;
    //public float[] array;
    //public int start;
    //public int increment;
    //public int delay;
    //public void Update()
    //{
    //   if (Input.GetKeyDown(push))
    //    {
    //        StartCoroutine(HalfNumber(start, array.Length, increment));
    //    }
    //}
    //public IEnumerator HalfNumber(int _start, int _end,int _increment)
    //{
    //    for (int i = _start; i < _end; i+= _increment)
    //    {
    //        yield return new WaitForSeconds(delay);
    //        array[i] = (float)i / 2;
    //        print(array[i]);
    //    }
    //}

    //public int number;


    //public void Start()
    //{
    //    if (number %2 == 0)
    //    {
    //        Debug.Log("il numero " + number + " è pari");
    //    }
    //    else
    //    {
    //        Debug.Log("il numero " + number + " è dispari");
    //    }
    //}

    //public List<int> intlist = new List<int>();

    //private void Start()
    //{
    //    intlist.Add(1);
    //}

    public KeyCode yara;
    public int[] numbers;

    public void Update()
    {
        if (Input.GetKeyDown(yara))
        {
            int bossetti = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > bossetti)
                    bossetti=numbers[i];
            }
            Debug.Log(bossetti + " è il più grande");
        }
    }
}