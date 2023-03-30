
  //include SoftwareSerial library
  #include <SoftwareSerial.h>
  SoftwareSerial GPRS(7,8);
  
  void setup()
   {
    GPRS.begin(9600); // GSM Module Baud rate – communication speed
    Serial.begin(9600); // Baud rate of Serial Monitor in the IDE app
    Serial.println ("Text Messege Module Ready & Verified");
    delay(100);
   }
  
  void loop()
    {  
     // reply only when you receive data:
     if (Serial.available()>0)
        {  
        // writes in the string all the inputs till a comma
        String phone_number = Serial.readStringUntil(':'); // writes in the string all the inputs till a comma
        //Reads incoming serial data
        Serial.read(); 
        String message = Serial.readStringUntil('\n');
        SendMessage(message,phone_number);
        }
      }
  
  void SendMessage(String message,String phone_number)
    {
    Serial.println ("Sending Message please wait….");
    GPRS.println("AT+CMGF=1"); //Text Mode initialisation
    delay(1000);
    Serial.println ("Set SMS Number");
    GPRS.println("AT+CMGS=\""+phone_number+"\"\r"); // Receiver’s Mobile Number
    delay(1000);
    Serial.println ("Set SMS Content");
    GPRS.println(message);// Messsage content
    delay(100);
    Serial.println ("Done");
    GPRS.println((char)26);// delay(1000);
    Serial.println ("Message sent succesfully");
    }
