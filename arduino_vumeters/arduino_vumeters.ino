// Arduino script for VUtiful Joe v1.0

// VUMeter 1
int VU1 = 5;
int VU1Val = 0;
// VUMeter 2
int VU2 = 6.;
int VU2Val = 0;

int LED1Pin = 2;
int LED1State = 1;
int LED2Pin = 3;
int LED2State = 1;

int VOLPin = 0;
int VOLVal = 1000; // high value to force a send on init

enum msgType_e {
      MSG_VOID,
      MSG_VU1,
      MSG_VU2,
      MSG_LED1,
      MSG_LEDR1,
      MSG_LED2,
      MSG_LEDR2
};

int m_readBytes[2];

void setup() {
 Serial.begin(9600);
 pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  //Read Buffer
  if (Serial.available() == 2) {
    m_readBytes[0] = Serial.read();
    m_readBytes[1] = Serial.read();

    switch(m_readBytes[0]) {
      case MSG_VU1:
        VU1Val = m_readBytes[1];
      break;
      case MSG_VU2:
        VU2Val = m_readBytes[1];
      break;
      case MSG_LED1:
        LED1State = m_readBytes[1];
      break;
      case MSG_LEDR1:
      break;
      case MSG_LED2:
        LED2State = m_readBytes[1];
      break;
      case MSG_LEDR2:
      break;
    }
  }


  //VU1Val = 60;
  //VU2Val = 60;
  analogWrite(VU1, VU1Val);
  analogWrite(VU2, VU2Val);

if(LED1State == 0) {
 digitalWrite(LED1Pin, LOW);
} else {
  digitalWrite(LED1Pin, HIGH);
}
if(LED2State == 0) {
 digitalWrite(LED2Pin, LOW);
} else {
  digitalWrite(LED2Pin, HIGH);
}

  // Volume read
  int newVal = map(analogRead(VOLPin), 0, 1023, 0, 100);
  if(newVal != VOLVal) {
    VOLVal = newVal;
    Serial.write(VOLVal);
  }
}
