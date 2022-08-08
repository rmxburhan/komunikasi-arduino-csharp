char input;
String data;
int led = 13;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0)
  {
    input = Serial.read();
    data = input;
  }
  if(input == '#'){
    if(data == "ON#"){
      digitalWrite(led, HIGH);
    }
    else if(data == "OFF#"){
      digitalWrite(led, LOW);
    }
    c = 0;
    data = "";
  }
}
