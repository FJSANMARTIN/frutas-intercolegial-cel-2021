using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos : MonoBehaviour
{
    //se definen los combos con sus respectivos arrays
    private int[] combo1 = new int[] {1,1,1,1};
    private int[] combo2 = new int[] { 2, 2, 2, 2 };
    private int[] combo3 = new int[] { 2, 2, 1, 1 };
    private int[] combo4 = new int[] { 1, 1, 2, 2 };
    private int[] combo5 = new int[] { 2, 1, 2, 1 };
    private int[] combo6 = new int[] { 1, 2, 1, 2 };

    //se crea una array temporal en donde se almacena lo que el player toca
    public int[] temp = new int[4];

    [SerializeField]bool seLleno = false;

    //al principio seria cero porque es la primera vez que se declara
    int ultimaPosicion =0;

    //se crean los contadores auxiliares de los combos
    [SerializeField] int counC1 = 0;
    [SerializeField] int counC2 = 0;
    [SerializeField] int counC3 = 0;
    [SerializeField] int counC4 = 0;
    [SerializeField] int counC5 = 0;
    [SerializeField] int counC6 = 0;

    public puntos Puntos;

    bool seEncontroIgualdad;

    bool seTerminoelCiclo;
    void Start()
    {
        
    }

    
    void Update()
    {
        //si los cuatro valores fueron rellenados
        
        if(seLleno == true)
        {
            //se crea el bucle que va a comparar a todos los combos
            for (int k = 0; k < 4; k++)
            {  
                //compara con el ciclo del combo 1
                for (int j = 0; j < 4; j++)
                {
                    if (temp[k] == combo1[j])
                    {
                        counC1++;
                        
                    }
                    k++;
                }
               
            }

            for (int k = 0; k < 4; k++)
            {
                //compara con el ciclo del combo 2
                for (int m = 0; m < 4; m++)
                {
                    if (temp[k] == combo2[m])
                    {
                        counC2++;
                        
                    }
                    k++;
                }
               
            }
            for (int k = 0; k < 4; k++)
            {
                //compara con el ciclo del combo 3
                for (int m = 0; m < 4; m++)
                {
                    if (temp[k] == combo3[m])
                    {
                        counC3++;
                       
                    }
                    k++;
                }
               
            }
            for (int k = 0; k < 4; k++)
            {
                // compara con el ciclo del combo 4
                for (int n = 0; n < 4; n++)
                {
                    if (temp[k] == combo4[n])
                    {
                        counC4++;
                       
                    }
                    k++;
                }
                

            }
            for (int k = 0; k < 4; k++)
            {
                //compara con el ciclo del combo 5
                for (int p = 0; p < 4; p++)
                {
                    if (temp[k] == combo5[p])
                    {
                        counC5++;
                        
                    }
                    k++;
                }
                

            }
            for (int k = 0; k < 4; k++)
            {
                // compara con el ciclo del combo 6
                for (int q = 0; q < 4; q++)
                {
                    if (temp[k] == combo6[q])
                    {
                        counC6++;
                        
                    }

                    k++;
                }
                
            }
            seTerminoelCiclo = true;
        }

        if(counC1 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(1);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
             resetArrayTemporal();

        }
        if (counC2 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(2);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
        }
        if (counC3 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(3);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
        }
        if (counC4 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(4);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
        }
        if (counC5 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(5);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
        }
        if (counC6 == 4)
        {
            seEncontroIgualdad = true;
            seTerminoelCiclo = false;
            Puntos.AddPoints(6);
            seLleno = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
        }
        //TO DO:falta el que es cuando todos son 0 cuando se toco el obstaculo



        //este else siempre estara ultimo porque significa que si ninguno de los de arriba se 
        //ejecuto , ninguno obtuvo 4 digitos
        else if(seEncontroIgualdad == false && seTerminoelCiclo == true)
        {
            seLleno = false;
            seTerminoelCiclo = false;
            ultimaPosicion = 0;
            resetCounts();
            resetArrayTemporal();
            Debug.Log("No se realizo ningun combo");
        }
        
    }





    public bool AddTemp(int variableFOV)
    {
        if(seLleno == false)
        {
            seEncontroIgualdad = false;
            //TO DO: si el parametro es 3 significa que toco un obstaculo y eso hace que se
            //reinicie el combo
            if(variableFOV == 3)
            {
                resetArrayTemporal();
                resetCounts();
                seLleno = true;
            }
            //aca se pregunta la ultima posicion rellenada del array
            
            if (ultimaPosicion < 4)
            {
                temp[ultimaPosicion] = variableFOV;
                //y le suma una posicion mas porque la anterior ya fue rellenada
                ultimaPosicion++;
            }
            //si ya fueron rellenadas las cuatros se devuelve el valor seLleno en true
            if(ultimaPosicion == 4)
            {
                seLleno = true;
            }
        }





        return seLleno;
    }


    void resetCounts()
    {
         counC1 = 0;
         counC2 = 0;
         counC3 = 0;
         counC4 = 0;
         counC5 = 0;
         counC6 = 0;
    }

    void resetArrayTemporal()
    {
        temp[0] = 0;
        temp[1] = 0;
        temp[2] = 0;
        temp[3] = 0;
    }

}
