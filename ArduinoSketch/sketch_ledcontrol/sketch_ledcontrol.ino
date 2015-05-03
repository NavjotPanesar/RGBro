/*
http://stackoverflow.com/questions/15803986/fading-arduino-rgb-led-from-one-color-to-the-other
 * LedBrightness sketch
 * controls the brightness of LEDs on "analog" (PWM) output ports.
 */

class rgb_color {

  private:
    int my_r;
    int my_g;
    int my_b;
  public:
    rgb_color (int red, int green, int blue)
      :
        my_r(red),
        my_g(green),
        my_b(blue)
    {
    }
    rgb_color ()
      :
        my_r(0),
        my_g(0),
        my_b(0)
    {
    }

    int r() const {return my_r;}
    int b() const {return my_b;}
    int g() const {return my_g;}
};

/*instances of fader can fade between two colors*/
class fader {

  private:
    int r_pin;
    int g_pin;
    int b_pin;
    rgb_color prev_color;

  public:
    /* construct the fader for the pins to manipulate.
     * make sure these are pins that support Pulse
     * width modulation (PWM), these are the digital pins
     * denoted with a tilde(~) common are ~3, ~5, ~6, ~9, ~10 
     * and ~11 but check this on your type of arduino. 
     */ 
    fader( int red_pin, int green_pin, int blue_pin)
      :
        r_pin(red_pin),
        g_pin(green_pin),
        b_pin(blue_pin),
        prev_color(0,0,0)
    {
    }

    void fade( 
               const rgb_color& out,
               unsigned n_steps = 256,  //default take 256 steps
               unsigned time    = 10)   //wait 10 ms per step
    {
      int red_diff   = out.r() - prev_color.r();
      int green_diff = out.g() - prev_color.g();
      int blue_diff  = out.b() - prev_color.b();
      for ( unsigned i = 0; i < n_steps; ++i){
        /* output is the color that is actually written to the pins
         * and output nicely fades from in to out.
         */
        rgb_color output ( prev_color.r() + i * red_diff / n_steps,
                           prev_color.g() + i * green_diff / n_steps,
                           prev_color.b() + i * blue_diff/ n_steps);
        /*put the analog pins to the proper output.*/
        analogWrite( r_pin, output.r() );
        analogWrite( g_pin, output.g() );
        analogWrite( b_pin, output.b() );
        delay(time);
      }
      prev_color = out; //record this color as the new previous color for the next time
    }

};

/*

 * Serial Port Monitor
 *
 * 
 */
//Setup Output

#define redPin 5
#define grnPin 6
#define bluPin 3

//Setup message bytes
byte inputByte_0;
byte inputByte_1;
byte inputByte_2;
byte inputByte_3;
byte inputByte_4;



fader f (redPin, grnPin, bluPin); 
//Setup

void setup() {
  
  pinMode(redPin, OUTPUT);
  pinMode(grnPin, OUTPUT);
  pinMode(bluPin, OUTPUT);
  Serial.begin(9600);
  f.fade( rgb_color(100,60,10));
}

//Main Loop
int numColors;
int currentColor = 0;
int crossfadeDelay = 0;
rgb_color* colorsList;
bool crossfade = false;
void loop() {
  
  if(crossfade){
  
    f.fade(colorsList[currentColor]);
    currentColor++;
    if(currentColor >= numColors){
        currentColor = 0;
    }
    delay(crossfadeDelay*1000);
  }
  //Read Buffer
  if (Serial.available() == 5) 
  {
    //Read buffer
    inputByte_0 = Serial.read();
    delay(100);    
    inputByte_1 = Serial.read();
    delay(100);      
    inputByte_2 = Serial.read();
    delay(100);      
    inputByte_3 = Serial.read();
    delay(100);
    inputByte_4 = Serial.read();   
  }
  //Check for start of Message
  if(inputByte_0 == 16)
  {        
       //Detect Command type
       switch (inputByte_1) 
       {
          case 125:
          {
              numColors = inputByte_2;
              crossfadeDelay = inputByte_3;
              colorsList = new rgb_color[numColors];
              int index = 0;
              if (Serial.available() == numColors*3){
                  for(;index < numColors; index++){
                      byte r = Serial.read();
                      byte g = Serial.read();
                      byte b = Serial.read();
                      colorsList[index] = rgb_color(r,g,b);
                  }
              }
              crossfade = true;
            break;
          }
          case 126:
              f.fade( rgb_color(inputByte_2,inputByte_3,inputByte_4));
              crossfade = false;
            break;
          case 128:
            //Say hello
            Serial.print("HELLO FROM ARDUINO");
            break;
        } 
        //Clear Message bytes
        inputByte_0 = 0;
        inputByte_1 = 0;
        inputByte_2 = 0;
        inputByte_3 = 0;
        inputByte_4 = 0;
        //Let the PC know we are ready for more data
        Serial.print("-READY TO RECEIVE");
  }
  
  
}

