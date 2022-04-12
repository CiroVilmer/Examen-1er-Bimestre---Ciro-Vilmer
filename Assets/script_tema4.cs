using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_tema4 : MonoBehaviour
{

    public int cantidadUnidades, cantidadDiasTotales, cantidadDiasLluvia;

    
    int precioCombustible = 130;
    int recorridoDia = 90;
    int recorridoLluvia = 110;


    // Start is called before the first frame update
    void Start()
    {

        if(cantidadDiasTotales < 5 || cantidadDiasLluvia < 0 || cantidadDiasLluvia > cantidadDiasTotales)
        {
            Debug.Log("Error, chequee los valores ingresados");
        }
        else
        {
            int cantidadDiasSinLluvia = cantidadDiasTotales - cantidadDiasLluvia;
            float recorridoTotal = (recorridoDia * cantidadUnidades) * cantidadDiasSinLluvia + ((recorridoLluvia * cantidadUnidades) * cantidadDiasLluvia);
            float litrosCombustible = recorridoTotal / 15;
            float combustibleTotal = litrosCombustible * precioCombustible;

            Debug.Log("Una flota de " + cantidadUnidades + " unidades trabajando durante " + cantidadDiasTotales + " dias implicara un gasto de " + combustibleTotal + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
