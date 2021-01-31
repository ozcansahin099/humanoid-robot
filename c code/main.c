#include <16f877A.h>   
#include <math.h>

#fuses XT,NOWDT,NOLVP,NOPROTECT,NOBROWNOUT,NOLVP,NOPUT,NOCPD
#USE delay(clock=4000000)
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7, parity=N, stop=1)

//#use fast_io (A) //trisleri kendimiz ayarlayalim
#use fast_io (B)
#byte INTCON=0x0B
#byte PIE1=0x8C





int16 distance,time;


long s1=650,s2=650,s3=650,s4=650,s5=650,s6=650,s7=650,s8=650,s9=650,s10=650,s11=650,s12=650,s13=650,s14=650,s15=650,s16=650; //darbe genislik sureleri, mikrosaniye cinsinden
long veri; //kesme ile gelen data
int sira=1; //gelen verininin hangi servoya gönderildiği bilgisini tutar


void main(){

   setup_psp(PSP_DISABLED);
   setup_timer_1(T1_INTERNAL|T1_DIV_BY_8);
   setup_timer_2(T2_DIV_BY_16,255,1);
   setup_adc_ports(NO_ANALOGS);    
   setup_adc(ADC_OFF);
    
    INTCON=0b11000000; //global ve peripheral kesmeler aktif
    PIE1=0b00100000; //uart kesmesi ayarlandı.kesme etkin hale getirildi
    
    
    set_tris_b(0b00000000);
    output_b(0x00);
    delay_ms(1000);
 
 while(1){
output_high(pin_a0);//trig=pin_a0
delay_us(15);
output_low(pin_a0);
while(!input(pin_a1));//echo=pin_a1
set_timer1(0);
while(input(pin_a1));
time=get_timer1();
distance=time/58;

if(distance<10)
{

 

}

      //1.kol
      output_high(pin_b0);
      delay_us(s1);
      output_low(pin_b0);

      output_high(pin_b1);
      delay_us(s2);
      output_low(pin_b1);

      output_high(pin_b2);
      delay_us(s3);
      output_low(pin_b2);
      
      output_high(pin_b3);
      delay_us(s4);
      output_low(pin_b3);
      
      output_high(pin_b4);
      delay_us(s5);
      output_low(pin_b4);
      
      
      //2.kol
      output_high(pin_c0);
      delay_us(s6);
      output_low(pin_c0);
      
      output_high(pin_c1);
      delay_us(s7);
      output_low(pin_c1);
      
      output_high(pin_c2);
      delay_us(s8);
      output_low(pin_c2);
      
      output_high(pin_c3);
      delay_us(s9);
      output_low(pin_c3);
      
      output_high(pin_c4);
      delay_us(s10);
      output_low(pin_c4);
      
      
      //1.bacak
      output_high(pin_b5);
      delay_us(s11);
      output_low(pin_b5);
      
      output_high(pin_b6);
      delay_us(s12);
      output_low(pin_b6);

      output_high(pin_b7);
      delay_us(s13);
      output_low(pin_b7);
      
      
      
      //2.bacak
      output_high(pin_d0);
      delay_us(s14);
      output_low(pin_d0);
      
      output_high(pin_d1);
      delay_us(s15);
      output_low(pin_d1);

      output_high(pin_d2);
      delay_us(s16);
      output_low(pin_d2);
delay_ms(100);

}
}#INT_RDA
void seri_data_geldi(){
veri=getc();


if(veri==200){ //sira ilk motorun
   sira=1;
}
if(veri==201){//sira ikinci motorun
   sira=2;
}
if(veri==202){//sira ucuncu motorun
   sira=3;
}
if(veri==203){//sira dördüncü motorun
  sira=4;
}

if(veri==204)
{
sira=5;
}
if(veri==205)
{
sira=6;
}
if(veri==206)
{
sira=7;
}
if(veri==207)
{
sira=8;
}
if(veri==208)
{
sira=9;
}
if(veri==209)
{
sira=10;
}
if(veri==210)
{
sira=11;
}
if(veri==211)
{
sira=12;
}
if(veri==212)
{
sira=13;
}
if(veri==213)
{
sira=14;
}
if(veri==214)
{
sira=15;
}
if(veri==215)
{
sira=16;
}








if(veri<200){
if(sira==1){
   s1=10*veri+540;
}
if(sira==2){
   s2=10*veri+540;
}
if(sira==3){
   s3=10*veri+540;
}
if(sira==4)
{
 s4=10*veri+540;
}

if(sira==5)
{
 s5=10*veri+540;
}
if(sira==6)
{
 s6=10*veri+540;
}
if(sira==7)
{
 s7=10*veri+540;
}
if(sira==8)
{
 s8=10*veri+540;
}
if(sira==9)
{
 s9=10*veri+540;
}
if(sira==10)
{
 s10=10*veri+540;
}
if(sira==11)
{
 s11=10*veri+540;
}
if(sira==12)
{
 s12=10*veri+540;
}
if(sira==13)
{
 s13=10*veri+540;
}
if(sira==14)
{
 s14=10*veri+540;
}
if(sira==15)
{
 s15=10*veri+540;
}
if(sira==16)
{
 s16=10*veri+540;
}


}
output_toggle(pin_a1); //kesme geldi belirteci
}






