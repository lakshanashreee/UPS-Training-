package scannerpractices;
import java.util.Scanner;
public class CelsiusToFahrenheit {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Convert celsius to fahrenhiet 
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Celsius: ");
		float cel = sc.nextFloat();
		//int fahr = sc.nextInt();
		float fahr = (cel*9/5)+32;
		System.out.print("Converted Fahrenheit is: "+fahr);
		
		

	}

}
