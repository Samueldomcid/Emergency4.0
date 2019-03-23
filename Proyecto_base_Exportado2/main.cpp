/*
 * Fecha: 23/03/2019	Hack For Good 2019
 *
 * Emergency 4.0	Simulacion de instalacion	Prototipo V0.0
 * Autores: Samuel Dominguez Cid, Juan Jose Jimenez Rama, Manuel Delgado Lara, Jose Angel Blanco Genil, Pablo Lopez Cortes
 */
#include "mbed.h"

Serial pc(USBTX,USBRX);

//Entradas analogicas:
AnalogIn milm35_1(A0);
AnalogIn milm35_2(A1);
AnalogIn milm35_3(A2);
AnalogIn milm35_4(A3);

#define	zona1	0x00
#define	zona2	0x01
#define zona3	0x02
#define zona4	0x03
#define sensor1 0x00
#define sensor2 0x01
#define sensor3 0x02
#define sensor4 0x03

int temp [4][1];
//Temporizadores:
Ticker tiempo_visual_studio;

//Funciones:
void enviar_visual (void);


void enviar_visual (void)
{
  temp[0][0] = milm35_1.read()*100;
  temp[1][0] = milm35_2.read()*100;
  temp[2][0] = milm35_3.read()*100;
  temp[3][0] = milm35_4.read()*100;
    for (int i=0; i<4; i++){
      pc.putc((char)0x50);
      pc.putc((char) i);
      pc.putc((char) 0);
      pc.putc((char) temp[i][0]);
      pc.putc((char) 0xE0);
    }
}
/*+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+*/
/*+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ FUNCION PRINCIPAL +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-*/
/*+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+*/

int main()
{
    tiempo_visual_studio.attach(&enviar_visual,1);  //Icializamos y le asignamos Ticker tiempo_visual_studio a la funcion enviar_visual (cada 1 seg).

    while(1){
    }
}
