#include <Wire.h>

#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,16,2);

#include "RTClib.h"

RTC_DS1307 RTC;

int n_dia;
int r_dia;
int n_mes;
int t_mes;
int n_anno;
int d_anno;
int t_siglo=6;

int Alarma1=1;
int Alarma2=2;

int HoraSet[30] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
int MinutoSet[30] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
int AlarmaSet[30] ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

int buzzer1=4;
int buzzer2=5;

int led1=6;
int led2=7;

int Sirena1=2;
int Sirena2=3;

int Contador1=0;
int Contador2=0;
int ActSirena1=0;
int ActSirena2=0;

String inputString = "";    
bool stringComplete = false; 
int Longitud=0;
String Inicio="";
String Fin="";

String HoraR="0";
String MinutoR="0";
String AlarmaR="0";
String Indice="0";
String Contenido="0";

int Contador=0;

void setup () 
{
   Wire.begin();
   RTC.begin();
   Serial.begin(9600); 
   
   pinMode(Sirena1, OUTPUT);
   pinMode(Sirena2, OUTPUT);

   pinMode(buzzer1, OUTPUT);
   pinMode(buzzer2, OUTPUT);

   pinMode(led1, OUTPUT);
   pinMode(led2, OUTPUT);

   digitalWrite(Sirena1, HIGH);
   digitalWrite(Sirena2, HIGH);

   lcd.init();
   lcd.backlight();            
   lcd.clear(); 

}

void loop()
{      
   DateTime now = RTC.now();
   
   Serial.print('I');
   Serial.print(now.hour(), DEC);
   Serial.print(':');
   Serial.print(now.minute(), DEC);
   Serial.print(':');
   Serial.print(now.second(), DEC);
   Serial.println('F');
   
   n_anno=(now.year()-2000);
   d_anno=n_anno/4;
   n_dia=now.day();
   n_mes=now.month();

   switch (n_mes) 
   {
      case 1:
        t_mes=0;
        break;
      case 2:
        t_mes=3;
        break;
      case 3:
        t_mes=3;
        break;
      case 4:
        t_mes=6;
        break;
      case 5:
        t_mes=1;
        break;
      case 6:
        t_mes=4;
        break;
      case 7:
        t_mes=6;
        break;
      case 8:
        t_mes=2;
        break;
      case 9:
        t_mes=5;
        break;
      case 10:
        t_mes=0;
        break;
      case 11:
        t_mes=3;
        break;
      case 12:
        t_mes=5;
        break;
      default: 
        t_mes=t_mes;
      break;
   }

   r_dia=n_dia+t_mes+n_anno+d_anno+t_siglo;
   r_dia = r_dia % 7;

   for(int i=0;i<30;i++)
   {
      if((r_dia==1 || r_dia==2 || r_dia==3 || r_dia==4 || r_dia==5) && now.hour()==HoraSet[i] && now.minute()==MinutoSet[i] && now.second()==0 && Alarma1==AlarmaSet[i])
      {
         ActSirena1=1;
      }

      if((r_dia==1 || r_dia==2 || r_dia==3 || r_dia==4 || r_dia==5) && now.hour()==HoraSet[i] && now.minute()==MinutoSet[i] && now.second()==0 && Alarma2==AlarmaSet[i])
      {
        ActSirena2=1;
      }
   }
   

   if(ActSirena1==1)
   {
      digitalWrite(Sirena1, LOW);
      digitalWrite(buzzer1, HIGH);
      digitalWrite(led1, HIGH);
      
      Contador1++;
   }

   if(Contador1==4)
   {
      digitalWrite(Sirena1, HIGH);
      digitalWrite(buzzer1, LOW);
      digitalWrite(led1, LOW);
      Contador1=0; 
      ActSirena1=0;
   }

   if(ActSirena2==1)
   {
      digitalWrite(Sirena2, LOW);
      digitalWrite(buzzer2, HIGH);
      digitalWrite(led2, HIGH);
      Contador2++;
   }

   if(Contador2==4)
   {
      digitalWrite(Sirena2, HIGH);
      digitalWrite(buzzer2, LOW);
      digitalWrite(led2, LOW);
      Contador2=0; 
      ActSirena2=0;
   }
   
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("H:"+String(HoraSet[Contador])+" M:"+String(MinutoSet[Contador])+" A:"+String(AlarmaSet[Contador]));
    lcd.setCursor(0,1);
    lcd.print("Cont:"+String(Contador));
    Contador++;

    if(Contador==30)
    {
      Contador=0;
    }
    
   
   delay(1000);
}

void Vectores(int Vector[30])
{
  for(int i=0;i<30;i++)
  {
    Serial.print((String(i))+":"+(String(Vector[i]))+"  ");
  }
  Serial.println(" ");
}


void serialEvent() 
{
  while (Serial.available()>0) 
  {
    char inChar = (char)Serial.read();
    inputString += inChar;
    
    if (inChar == '\n') 
    {
      stringComplete = true;
    }
  }

  if (stringComplete) 
  {
    inputString.trim();
    Longitud=inputString.length();

    if(Longitud==9)
    {
      Inicio=inputString.substring(0,1);
      Fin=inputString.substring(8,9);
      
      if(Inicio=="I" && Fin=="F")
      {
        Contenido=inputString.substring(1,8);
        
        if(Contenido=="SSSSSSS")
        {
          for(int i=0;i<30;i++)
          {
            HoraSet[i]=0;  
            MinutoSet[i]=0; 
            AlarmaSet[i]=0;     
          }
        }else
        {
          Indice=inputString.substring(1,3);
          HoraR=inputString.substring(3,5);
          MinutoR=inputString.substring(5,7);
          AlarmaR=inputString.substring(7,8);
  
          HoraSet[Indice.toInt()]=HoraR.toInt();
          MinutoSet[Indice.toInt()]=MinutoR.toInt();
          AlarmaSet[Indice.toInt()]=AlarmaR.toInt();
        }
      }
    }
      
    inputString = "";
    stringComplete = false;
  }
}
