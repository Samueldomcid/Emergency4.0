/*
 * Fecha: 23/03/2019	Hack For Good 2019
 *
 * Emergency 4.0	Controlador de Señales	Prototipo V0.0
 */
#include "mbed.h"

Ticker	timer1;

//Conexion Serie via UART a PC
Serial	pc	(SERIAL_TX, SERIAL_RX);

DigitalOut	SenalS0N0(D5);
DigitalOut	SenalS1N0(D6);
DigitalOut	SenalS2N0(D7);
DigitalOut	SenalS3N0(D8);
                         //Envio de Datos


bool Senal[4][1]={false,false,false,false};
bool ZonaAfectada[4][1]={false,false,false,false};
bool Manual[4][1]={false,false,false,false};				//Matriz encargada de la salida
void    myirq           (void);
void 	Reset   		(void);
void    EnviaDatos      (void);
void 	ActualizaSenal 	(void);
void 	RedirigeSenal	(void);
/////////////////////FUNCION PRICIPAL MAIN/////////////////////////////////////////////////////////////////
int     main   ()
{
	Reset();       //Realizo un reset
    timer1.attach(&EnviaDatos,0.25); //Activo una interrupcion para envio de datos
    pc.attach(&myirq, Serial::RxIrq);   //Activa Interrupcion por comunicacion serie RxIrq

    while(1)
    {
    }
}
/*
 * Realiza una inicializacion de la direccion de las indicaciones hacia la salida mas cercana
 */
void Reset (void)
{
	for (int i=0;i<4;i++)   //Inicializa las señales Luminosas
	{
		for(int n=0;n<1;n++)
			{
				Manual[i][n]=0;
				Senal[i][n]=0;
			}
	}
	for (int i=0;i<4;i++)   //Inicializa las señales Luminosas
	{
		for(int n=0;n<1;n++)
		{
			ZonaAfectada[i][n]=0;
		}
	}
}
//////////////////////FUNCION QUE CONTROLA LA RECEPCION POR PUERTO SERIE////////////////////////////////////
void    myirq   ()
{
	static char c[5];   //Recepcion de 5 caracteres
    if(pc.readable())   //Interrupcion creada por dato de recepcion?
    {
        c[0]=c[1];
        c[1]=c[2];
        c[2]=c[3];
        c[3]=c[4];
        c[4]=pc.getc();   //Actualizo los datos series de entrada
        if(c[4]== 0xE0)
        {
            switch(c[0])
            {
            case 0xFF:
            	Reset();
            	break;
            case 0x20: //Cambio en señal deseada
            	Senal[(int)c[1]][(int)c[2]]= (bool) c[3];//1^Senal[(int)c[1]][(int)c[2]]; //Actualiza el buffer de la senal
            	Manual[(int)c[1]][(int)c[2]]=1^Manual[(int)c[1]][(int)c[2]];
            	ActualizaSenal();           //Modifica el estado de la senal
            	break;
            case 0x10: //Zona afectada
            	ZonaAfectada[(int)c[1]][(int)c[2]]=(bool) c[3];                                                                                                                //1^ZonaAfectada[(int)c[1]][(int)c[2]]; //Modifica el estado de la señal
            	RedirigeSenal();
            	ActualizaSenal();
            	break;
            }
        }
    }
}
/*
 * Se encarga de modificar la direccion de la senal en funcion del sector
 */
void RedirigeSenal (void)
{
	for(int i=0; i<4; i++)
	{
		for(int n=0; n<1; n++)
		{
			if (Manual[i][n]==false)
			{
				Senal[i][n]=ZonaAfectada[i][n];
			}
		}
	}
}
/*
 * Se encarga de actualizar las señalizaciones externas por medio de comunicacion one wire
 *
 * Futura mejora por medios wifi
 */
void	ActualizaSenal (void)
{
	SenalS0N0.write(!Senal[0][0]);
	SenalS1N0.write(!Senal[1][0]);
	SenalS2N0.write(!Senal[2][0]);
	SenalS3N0.write(!Senal[3][0]);
}
/*
 * Interrupcion encargada del envio de datos por puerto serie al SCADA
 */
void    EnviaDatos      (void)
{
	for (int i=0;i<4;i++)			// Recorre sectores
	{
		for(int n=0;n<1;n++)		//Recorres numeros
		{
			pc.putc((char)0x30);    //Envia el id de la comunicacion de actializacion de señales
			pc.putc((char)i);     	//Envia el sector de la Senal
			pc.putc((char)n);     	//Envia el numero de la Senal
			pc.putc(Senal[i][n]); 	//Envia el estado de la Senal
			pc.putc((char)0xE0);    //Envia el valor 0xE0 para comprobar final de trama
		}
	}
}
