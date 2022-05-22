// Aquí se colocan las variables globales
int rojo, verde, azul;

// Este código se ejecuta una sola vez
// Generalmente sirve para configuración
void setup() {
  // Configurar la velocidad de transmisión del puerto serial
  Serial.begin(9600);
  // Configurar los pines del Arduino como salida
  pinMode(3, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);

  // Manda a valor "bajo" todo lo conectado a los pines
  rojo = LOW; verde = LOW; azul = LOW;
  digitalWrite(3, rojo);
  digitalWrite(5, verde);
  digitalWrite(6, azul);
}

// Este código se ejecuta una y otra vez en un ciclo sin fin
// Generalmente sirve para colocar el programa principal
void loop() {
  // Preguntar si el puerto serial esta disponible
  if(Serial.available() > 0)
  {
    // Leer lo que venga del puerto serial
    int opc = Serial.read();
    switch(opc)
    {
      case 'a':
        if(rojo == HIGH) rojo = LOW;
        else rojo = HIGH;
        digitalWrite(3, rojo);
        break;
      case 'b':
        if(verde == HIGH) verde = LOW;
        else verde = HIGH;
        digitalWrite(5, verde);
        break;
      case 'c':
        if(azul == HIGH) azul = LOW;
        else azul = HIGH;
        digitalWrite(6, azul);
        break;
    }
  }
}
